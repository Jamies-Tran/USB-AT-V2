using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleFileManager.Helper;
using SimpleFileManager.Services;
using SimpleFileManager.Forms;
using USBAT.Forms;

namespace SimpleFileManager
{
    public partial class UsbAtForm : Form
    {
        private FileManagementService fileManagement;
        private BitlockerService bitlocker;
        private string systemPath = "";
        private string remPath = PathHelper.defaultRemovablePath;
        private bool isFile = false;
        private bool isMoveUp = false;
        private bool isMoveDown = false;
        private bool isSysDelete = false;
        private bool isRemDelete = false;
        private string currentlySelectedItemName = "";
        private string sysCurrenPath = "";
        private string remCurrenPath = "";
        private bool isLock = true;

        public UsbAtForm()
        {
            InitializeComponent();
            this.fileManagement = FileManagementService.Instance;
            this.bitlocker = BitlockerService.Instance;
            isLock = bitlocker.isLock();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            configComboBoxData();
            configSysCurrentPath();
            remCurrenPath = remPath;
            loadFilesAndDirectoriesSystem();
            loadFilesAndDirectoriesRemovable();
            configShowUpButtonUpAndDown();
            configShowUpDeleteButton();
            configShowUpLockButton();
            configEnableRomButton();
            configLabelPath();
        }

        private void configComboBoxData()
        {
            DriveInfo[] systemDrives = DriveInfo.GetDrives()
                .Where(d => !d.DriveType.Equals(DriveType.Removable) && d.IsReady).ToArray();
            cbDrive.DataSource = systemDrives;
            cbDrive.Text = systemDrives.First().Name;
        }

        private void configMainForm()
        {
            configSysCurrentPath();
            isLock = bitlocker.isLock();
            loadFilesAndDirectoriesSystem();
            loadFilesAndDirectoriesRemovable();
            configShowUpButtonUpAndDown();
            configShowUpDeleteButton();
            configShowUpLockButton();
            configEnableRomButton();
            configLabelPath();
        }

        private void configSysCurrentPath()
        {
            systemPath = cbDrive.Text;
            sysCurrenPath = systemPath;
        }

        private void configLabelPath()
        {
            lbPath.Text = sysCurrenPath;
            lbRemPath.Text = remCurrenPath;
        }

        private void configEnableRomButton()
        {
            btnRemBack.Enabled = !isLock;
            btnRemNewFile.Enabled = !isLock;
            btnRemDelete.Enabled = !isLock;
            btnRemNewFolder.Enabled = !isLock;
        }

        // show move up and down button
        private void configShowUpButtonUpAndDown()
        {
            btnMoveDown.Enabled = !isLock && isMoveDown;
            btnMoveUp.Enabled = !isLock && isMoveUp;
        }

        private void configShowUpDeleteButton()
        {
            btnSysDelete.Enabled = isSysDelete;
            btnRemDelete.Enabled = isRemDelete;
        }

        private void configShowUpLockButton()
        {
            btnUnlockDrive.Enabled = isLock;
            btnUnlockDrive.Visible = isLock;
            btnLockDrive.Visible = !isLock;
            btnLockDrive.Enabled = !isLock;
        }

        public void loadFilesAndDirectoriesSystem()
        {
            DirectoryInfo fileList;
            string tempFilePath = "";
            FileAttributes fileAttr = File.GetAttributes(sysCurrenPath);
            
            try
            {
                if((fileAttr & FileAttributes.Directory ) == FileAttributes.Directory)
                {
                    fileList = new DirectoryInfo(sysCurrenPath);
                    FileInfo[] files = fileList.GetFiles(); // GET ALL THE FILES
                    DirectoryInfo[] dirs = fileList.GetDirectories(); // GET ALL THE DIRS
                    string fileExtension = "";
                    lvSystem.Items.Clear();

                    for (int i = 0; i < files.Length; i++)
                    {
                        fileExtension = files[i].Extension.ToUpper();
                        switch(fileExtension)
                        {
                            case ".MP3":
                            case ".MP2":
                                lvSystem.Items.Add(files[i].Name, 5);
                                break;
                            case ".EXE":
                            case ".COM":
                                lvSystem.Items.Add(files[i].Name, 7);
                                break;

                            case ".MP4":
                            case ".AVI":
                            case ".MKV":
                                lvSystem.Items.Add(files[i].Name, 6);
                                break;
                            case ".PDF":
                                lvSystem.Items.Add(files[i].Name, 4);
                                break;
                            case ".DOC":
                            case ".DOCX":
                                lvSystem.Items.Add(files[i].Name, 3);
                                break;
                            case ".PNG":
                            case ".JPG":
                            case ".JPEG":
                                lvSystem.Items.Add(files[i].Name, 9);
                                break;

                            default:
                                lvSystem.Items.Add(files[i].Name, 8);
                                break;
                        }
                        
                    }

                    for (int i = 0; i < dirs.Length; i++)
                    {
                        lvSystem.Items.Add(dirs[i].Name, 10);
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Không có quyền để mở file/folder này", "Lỗi", MessageBoxButtons.OK);
                DirectoryInfo dir = new DirectoryInfo(sysCurrenPath);
                sysCurrenPath = dir.Parent.Name;
                systemPath = dir.Parent.Name;
           
            }
        }

        public void loadFilesAndDirectoriesRemovable()
        {
            if(!bitlocker.isLock())
            {
                DirectoryInfo fileList;
                string tempFilePath = "";
                FileAttributes fileAttr = File.GetAttributes(remCurrenPath);
                try
                {
                    if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
                    {
                        fileList = new DirectoryInfo(remCurrenPath);
                        FileInfo[] files = fileList.GetFiles(); // GET ALL THE FILES
                        DirectoryInfo[] dirs = fileList.GetDirectories(); // GET ALL THE DIRS
                        string fileExtension = "";
                        lvRemovable.Items.Clear();

                        for (int i = 0; i < files.Length; i++)
                        {
                            fileExtension = files[i].Extension.ToUpper();
                            switch (fileExtension)
                            {
                                case ".MP3":
                                case ".MP2":
                                    lvRemovable.Items.Add(files[i].Name, 5);
                                    break;
                                case ".EXE":
                                case ".COM":
                                    lvRemovable.Items.Add(files[i].Name, 7);
                                    break;

                                case ".MP4":
                                case ".AVI":
                                case ".MKV":
                                    lvRemovable.Items.Add(files[i].Name, 6);
                                    break;
                                case ".PDF":
                                    lvRemovable.Items.Add(files[i].Name, 4);
                                    break;
                                case ".DOC":
                                case ".DOCX":
                                    lvRemovable.Items.Add(files[i].Name, 3);
                                    break;
                                case ".PNG":
                                case ".JPG":
                                case ".JPEG":
                                    lvRemovable.Items.Add(files[i].Name, 9);
                                    break;

                                default:
                                    lvRemovable.Items.Add(files[i].Name, 8);
                                    break;
                            }

                        }

                        for (int i = 0; i < dirs.Length; i++)
                        {
                            if (!dirs[i].Name.Equals("System Volume Information"))
                            {
                                lvRemovable.Items.Add(dirs[i].Name, 10);
                            }
                        }
                    }
                }
                catch (Exception e)
                {

                }
            }
        }

        public void systemLoadButtonAction()
        {
            sysRemoveBackSlash();
            systemPath = sysCurrenPath;
            loadFilesAndDirectoriesSystem();
            configLabelPath();
        }

        public void remLoadButtonAction()
        {
            remRemoveBackSlash();
            remPath = remCurrenPath;
            loadFilesAndDirectoriesRemovable();
            isFile = false;
        }

        private void openFile(string file)
        {
            Process.Start(file);
            //systemPath = sysCurrenPath;
        }

        public void sysRemoveBackSlash()
        {
            string path = sysCurrenPath;
            if (path.LastIndexOf("\\") == path.Length - 1 && path.LastIndexOf(":") != path.Length - 2)
            {
                sysCurrenPath = path.Substring(0, path.Length - 1);
            }
        }

        public void remRemoveBackSlash()
        {
            string path = remCurrenPath;
            if (path.LastIndexOf("\\") == path.Length - 1)
            {
                sysCurrenPath = path.Substring(0, path.Length - 1);
            }
        }

        public void sysGoBack()
        {
            try
            {
                sysRemoveBackSlash();
                string path = sysCurrenPath;
                if(path.LastIndexOf(":") != path.Length - 2)
                {
                    path = path.Substring(0, path.LastIndexOf("\\"));
                }
                
                this.isFile = false;
                sysCurrenPath = path;
                sysRemoveBackSlash();
            }
            catch(Exception e)
            {

            }
        }

        public void remGoBack()
        {
            try
            {
                remRemoveBackSlash();
                string path = remCurrenPath;
                path = path.Substring(0, path.LastIndexOf("\\"));
                this.isFile = false;
                remCurrenPath = path;
                remRemoveBackSlash();
            }
            catch (Exception e)
            {

            }
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            systemLoadButtonAction();
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            currentlySelectedItemName = e.Item.Text;
            isMoveDown = true;
            isMoveUp = false;
            isSysDelete = true;
            isRemDelete = false;
            configShowUpButtonUpAndDown();
            configShowUpDeleteButton();
            sysCurrenPath = $"{systemPath}\\{currentlySelectedItemName}";
            configLabelPath();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            if(File.Exists(sysCurrenPath))
            {
                openFile(sysCurrenPath);
                FileInfo fileInfo = new FileInfo(sysCurrenPath);
                sysCurrenPath = fileInfo.DirectoryName;
            }
            systemLoadButtonAction();
            
        }

        private void sysBackButton_Click(object sender, EventArgs e)
        {
            sysGoBack();
            systemLoadButtonAction();
        }

        private void lvRemovable_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            currentlySelectedItemName = e.Item.Text;
            isMoveUp = true;
            isMoveDown = false;
            isRemDelete = true;
            isSysDelete = false;
            configShowUpButtonUpAndDown();
            configShowUpDeleteButton();
            remCurrenPath = $"{remPath}\\{currentlySelectedItemName}";
            configLabelPath();
        }

        private void lvRemovable_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (File.Exists(remCurrenPath))
            {
                openFile(remCurrenPath);
                FileInfo fileInfo = new FileInfo(remCurrenPath);
                remCurrenPath = fileInfo.DirectoryName;
            }
            remLoadButtonAction();
        }

        private void btnRomBack_Click(object sender, EventArgs e)
        {
            remGoBack();
            remLoadButtonAction();
        }

        private void btnSysDelete_Click(object sender, EventArgs e)
        {
            if(isSysDelete)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa dữ liệu?", "Thông báo", MessageBoxButtons.OKCancel);
                if(result.Equals(DialogResult.OK))
                {
                    fileManagement.delete(sysCurrenPath);
                    sysGoBack();
                    systemLoadButtonAction();
                }
            }
        }

        private void btnRemDelete_Click(object sender, EventArgs e)
        {
            if (isRemDelete)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa dữ liệu?", "Thông báo", MessageBoxButtons.OKCancel);
                if (result.Equals(DialogResult.OK))
                {
                    fileManagement.delete(remCurrenPath);
                    remGoBack();
                    remLoadButtonAction();
                }
            }
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            CopyFileForm copyForm = new CopyFileForm(sysCurrenPath, remCurrenPath);
            copyForm.Show();
            copyForm.FormClosing += new FormClosingEventHandler(this.usbAtForm_Formclosing);
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            CopyFileForm copyForm = new CopyFileForm(remCurrenPath, sysCurrenPath);
            copyForm.Show();
            copyForm.FormClosing += new FormClosingEventHandler(this.usbAtForm_Formclosing);
        }

        private void btnSysNewFile_Click(object sender, EventArgs e)
        {
            NewFileForm newResForm = new NewFileForm(sysCurrenPath, false);
            newResForm.Show();
            newResForm.FormClosing += new FormClosingEventHandler(this.usbAtForm_Formclosing);
        }

        private void btnRemNewFile_Click(object sender, EventArgs e)
        {
            NewFileForm newResForm = new NewFileForm(remCurrenPath, true);
            newResForm.Show();
            newResForm.FormClosing += new FormClosingEventHandler(this.usbAtForm_Formclosing);
        }

        private void btnSysNewFolder_Click(object sender, EventArgs e)
        {
            NewFolderForm newFolderForm = new NewFolderForm(sysCurrenPath, false);
            newFolderForm.Show();
            newFolderForm.FormClosing += new FormClosingEventHandler(this.usbAtForm_Formclosing);
        }

        private void btnRemNewFolder_Click(object sender, EventArgs e)
        {
            NewFolderForm newFolderForm = new NewFolderForm(remCurrenPath, true);
            newFolderForm.Show();
            newFolderForm.FormClosing += new FormClosingEventHandler(this.usbAtForm_Formclosing);

        }

        private void btnUnlockDrive_Click(object sender, EventArgs e)
        {
            UnlockDriveForm unlockDriveForm = new UnlockDriveForm();
            unlockDriveForm.FormClosing += new FormClosingEventHandler(this.usbAtForm_Formclosing);
            unlockDriveForm.Show();
        }

        private void usbAtForm_Formclosing(object sender, FormClosingEventArgs e)
        {
            configMainForm();
        }

        private void cbDrive_SelectedIndexChanged(object sender, EventArgs e)
        {
            configSysCurrentPath();
            loadFilesAndDirectoriesSystem();
        }

        private void btnLockDrive_Click(object sender, EventArgs e)
        {
            LockForm lockForm = new LockForm();
            lockForm.Show();
            lockForm.FormClosing += new FormClosingEventHandler(this.usbAtForm_Formclosing);
        }
    }
}
