using SimpleFileManager.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFileManager.Forms
{
    public partial class NewFolderForm : Form
    {
        private string rootPath;
        private bool isRemovable;
        private FileManagementService fileManagement;

        public NewFolderForm(string rootPath, bool isRemovable)
        {
            InitializeComponent();
            this.rootPath = rootPath;
            this.isRemovable = isRemovable;
            fileManagement = FileManagementService.Instance;
        }

        private void NewFolderForm_Load(object sender, EventArgs e)
        {
            configRootPathText();
            configShowUpCreateButton();
            configShowUpCreateProcess(false);
        }

        private void configRootPathText()
        {
            if(File.Exists(this.rootPath))
            {
                FileInfo rootPathInfo = new FileInfo(this.rootPath);
                txtRootPath.Text = rootPathInfo.DirectoryName;
            } else
            {
                txtRootPath.Text = this.rootPath;
            }
        }

        private void configShowUpCreateProcess(bool isStart)
        {
            prgNewFolder.Visible = isStart;
            btnNewRemFolder.Visible = !isStart;
            btnNewRemFolder.Enabled = !isStart;
            btnNewSysFolder.Visible = !isStart;
            btnNewSysFolder.Enabled = !isStart;
        }

        private void configShowUpCreateButton()
        {
            btnNewRemFolder.Enabled = isRemovable;
            btnNewRemFolder.Visible = isRemovable;
            btnNewSysFolder.Enabled = !isRemovable;
            btnNewSysFolder.Visible = !isRemovable;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewSysFolder_Click(object sender, EventArgs e)
        {
            configShowUpCreateProcess(true);
            process();
        }

        private void btnNewRemFolder_Click(object sender, EventArgs e)
        {
            configShowUpCreateProcess(true);
            process();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(prgNewFolder.Value < prgNewFolder.Maximum)
            {
                prgNewFolder.PerformStep();
            } else
            {
                timer1.Stop();
                createFolder();
            }
        }

        private void process()
        {
            timer1.Start();
        }

        private void createFolder()
        {
            string folderName = txtFolderName.Text.Equals("") ? "New Folder" : txtFolderName.Text;
            String newFolder = $"{rootPath}/{folderName}";
            fileManagement.createFolder(newFolder);
            DialogResult result = MessageBox.Show("Tạo folder thành công", "Thông báo", MessageBoxButtons.OK);
            if(result.Equals(DialogResult.OK))
            {
                this.Close();
            }
        }
    }
}
