using SimpleFileManager.Models;
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

namespace SimpleFileManager
{
    public partial class NewFileForm : Form
    {
        private String rootPath;
        private bool isRemovable;
        private FileManagementService fileManagement;
        private BitlockerService bitlocker;

        public NewFileForm(string rootPath, bool isRemovable)
        {
            InitializeComponent();
            this.fileManagement = FileManagementService.Instance;
            this.bitlocker = BitlockerService.Instance;
            this.rootPath = rootPath;
        }

        private void NewResForm_Load(object sender, EventArgs e)
        {
            cbExtenstion.DataSource = new ComboExtension[]
            {
                new ComboExtension{Id = 1, Value = "txt"},
                new ComboExtension{Id = 2, Value = "pdf"}
            };
            configCreateButton();
            configRootPathTextField();
            configShowUpCreateProcess(false);
        }

        private void configShowUpCreateProcess(bool isStart)
        {
            prgCreate.Visible = isStart;
            btnNewRemFile.Visible = !isStart;
            btnNewRemFile.Enabled = !isStart;
            btnNewSysFile.Enabled = !isStart;
            btnNewSysFile.Visible = !isStart;
        }

        private void configRootPathTextField()
        {
            if(File.Exists(this.rootPath))
            {
                FileInfo rootInfo = new FileInfo(this.rootPath);
                txtRootPath.Text = rootInfo.DirectoryName;
            } else if(Directory.Exists(this.rootPath))
            {
                txtRootPath.Text = this.rootPath;
            }
        }

        private void configCreateButton()
        {
            btnNewRemFile.Enabled = isRemovable;
            btnNewRemFile.Visible = isRemovable;
            btnNewSysFile.Enabled = !isRemovable;
            btnNewSysFile.Visible = !isRemovable;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewRemFile_Click(object sender, EventArgs e)
        {
            configShowUpCreateProcess(true);
            process();
        }

        private void btnNewSysFile_Click(object sender, EventArgs e)
        {
            configShowUpCreateProcess(true);
            process();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(prgCreate.Value < prgCreate.Maximum)
            {
                prgCreate.PerformStep();
            } else
            {
                timer1.Stop();
                newFile();
            }
        }

        private void process()
        {
            timer1.Start();
        }

        private void newFile()
        {
            string extension = cbExtenstion.Text.Replace(".", "");
            string fileName = txtNewRes.Text.Equals("") ? "New File" : txtNewRes.Text;
            String newFile = $"{txtRootPath.Text}/{fileName}.{extension}";
            fileManagement.createFile(newFile);
            DialogResult result = MessageBox.Show("Tạo file thành công", "Thông báo", MessageBoxButtons.OK);
            if(result.Equals(DialogResult.OK))
            {
                this.Close();
            }
        }

    }

    
}
