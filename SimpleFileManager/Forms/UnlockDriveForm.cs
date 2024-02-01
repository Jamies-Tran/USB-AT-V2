using SimpleFileManager.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using USBAT.Forms;

namespace SimpleFileManager.Forms
{
    public partial class UnlockDriveForm : Form
    {
        private BitlockerService bitlocker;

        public UnlockDriveForm()
        {
            InitializeComponent();
            this.bitlocker = BitlockerService.Instance;
            this.configUnlockProgress(false);
        }

        private void configUnlockProgress(bool isStart)
        {
            prgUnlock.Visible = isStart;
            btnUnlock.Visible = !isStart;
            btnUnlock.Enabled = !isStart;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            
            configUnlockProgress(true);
            progressing();
        }

        private void progressing() 
        {
            timer1.Start();
        }

        private void unlock()
        {
            string password = bitlocker.encodeBase64Password(txtPassword.Text);
            if (prgUnlock.Value == prgUnlock.Maximum)
            {
                bitlocker.unlock(password);
                bool isLock = bitlocker.isLock();
                if (!isLock)
                {
                    DialogResult result = MessageBox.Show("Mở khóa thành công", "Thông báo", MessageBoxButtons.OK);
                    if (DialogResult.OK == result)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu");
                    configUnlockProgress(false);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(prgUnlock.Value <  prgUnlock.Maximum)
            {
                prgUnlock.PerformStep();
            } else
            {
                timer1.Stop();
                unlock();
                prgUnlock.Value = 0;
            }
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            ValidateOldPasswordForm validateOldPasswordForm = new ValidateOldPasswordForm();
            validateOldPasswordForm.Show();
        }
    }
}
