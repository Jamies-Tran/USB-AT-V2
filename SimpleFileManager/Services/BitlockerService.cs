using SimpleFileManager.Helper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Management.Automation;
using System.Security;

namespace SimpleFileManager.Services
{
    public class BitlockerService
    {
        public static BitlockerService Instance { get { return new BitlockerService(); } private set { } }

        private string pathString = @"\\.\ROOT\CIMv2\Security\MicrosoftVolumeEncryption";
        private ManagementScope scope;
        private ManagementPath path;

        private BitlockerService() 
        {
            scope = new ManagementScope(pathString);
            path = new ManagementPath(pathString) { ClassName= "Win32_EncryptableVolume" };
        }

        public void unlock(string password = "")
        {
            try
            {
                ObjectQuery query = new ObjectQuery($"SELECT * FROM Win32_EncryptableVolume WHERE DriveLetter = '{PathHelper.defaultRemovablePath}'");
                using(ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query))
                {
                    ManagementObjectCollection collections = searcher.Get();
                    foreach (ManagementObject collection in collections)
                    {
                        if (collection.Properties["DriveLetter"].Value.ToString() != PathHelper.defaultRemovablePath) continue;
                        Object[] methodArgs = { password };
                        collection.InvokeMethod("UnlockWithPassPhrase", methodArgs);
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        public bool isLock()
        {
            bool isLock = false;
            path.Server = Environment.MachineName;
            ObjectQuery query = new ObjectQuery($"SELECT * FROM Win32_EncryptableVolume WHERE DriveLetter = '{PathHelper.defaultRemovablePath}'");
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query))
            {
                ManagementObjectCollection collections = searcher.Get();
                foreach(ManagementObject collection in collections)
                {
                    if (collection.Properties["DriveLetter"].Value.ToString() != PathHelper.defaultRemovablePath) continue;
                    isLock = collection.Properties["ProtectionStatus"].Value.ToString() == "2";
                }
            }
            return isLock;
        }

        public bool validOldPassword(string oldPass)
        {
            bool result = false;
            using(PowerShell ps = PowerShell.Create())
            {
                ps.AddScript($"Unlock-BitLocker -MountPoint \"{PathHelper.defaultRemovablePath}\" -Password (ConvertTo-SecureString -AsPlainText -Force -String \"{oldPass}\")");
                ps.Invoke();
                ps.Commands.Clear();

                ps.AddScript($"Disable-BitLocker -MountPoint \"{PathHelper.defaultRemovablePath}\"");
                ps.Invoke();
                result = !ps.HadErrors;
            }
            return result;
        }

        public void cancelChangePassword(string oldPassword)
        {
            using(PowerShell ps = PowerShell.Create())
            {
                ps.AddScript($"Enable-BitLocker -MountPoint \"{PathHelper.defaultRemovablePath}\" -PasswordProtector -Password (ConvertTo-SecureString -AsPlainText -Force -String \"{oldPassword}\")");
                ps.Invoke();
            }
        }

        public bool changePassphrase(string newPass)
        {
            bool result = false;
            using (PowerShell ps = PowerShell.Create())
            {

                ps.AddScript($"Enable-Bitlocker -MountPoint \"{PathHelper.defaultRemovablePath}\" -Password (ConvertTo-SecureString -AsPlainText -Force -String \"{newPass}\")");
                ps.Invoke();
                if (ps.HadErrors)
                {
                    result = false;
                } else
                {
                    result = true;
                }

            }
            return result;
        }

        public string encodeBase64Password(string password)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            String encodeBase64 = Convert.ToBase64String(bytes);
            return encodeBase64;
        }

        public bool lockDrive()
        {
            bool result = false;
            using(PowerShell ps = PowerShell.Create())
            {
                ps.AddScript($"Lock-Bitlocker -MountPoint \"{PathHelper.defaultRemovablePath}\"");
                ps.Invoke();
                if(ps.HadErrors)
                {
                    result = false;
                } else
                {
                    result = true;
                }
            }
            return result;
        } 
    }
}
