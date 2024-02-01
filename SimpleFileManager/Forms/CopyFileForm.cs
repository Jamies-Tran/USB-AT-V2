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
    public partial class CopyFileForm : Form
    {
        private string source;
        private string destination;
        private string extension;
        private FileManagementService fileManagement;

        public CopyFileForm(string source, string destination)
        {
            InitializeComponent();
            this.source = source;
            this.destination = destination;
            this.fileManagement = FileManagementService.Instance;
        }

        private void CopyForm_Load(object sender, EventArgs e)
        {
            configShowFilePath();
            configShowUpCopyProgress(false);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            configShowUpCopyProgress(true);
            process();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (prgCopy.Value < prgCopy.Maximum)
            {
                prgCopy.PerformStep();
            }
            else
            {
                timer1.Stop();
                copy();
            }
        }

        private void configShowUpCopyProgress(bool isStart)
        {
            prgCopy.Visible = isStart;
            btnCopy.Visible = !isStart;
            btnCopy.Enabled = !isStart;
        }

        private void configShowFilePath()
        {
            FileInfo sourceInfo = new FileInfo(this.source);
            string name = sourceInfo.Name.Replace(sourceInfo.Extension, "");
            extension = sourceInfo.Extension;
            txtSource.Text = this.source;
            txtFileName.Text = name;
            if (File.Exists(this.destination))
            {
                FileInfo desInfo = new FileInfo(this.destination);
                txtFilePath.Text = desInfo.DirectoryName;
            } else 
            {
                txtFilePath.Text = this.destination;
            }
            
        }

        private void process()
        {
            timer1.Start();
        }



        private void copy()
        {
            
            string src = txtSource.Text;
            string fileNameRemoveExtension = txtFileName.Text;
            if (fileNameRemoveExtension.Contains("."))
            {
                fileNameRemoveExtension = fileNameRemoveExtension
                    .Replace(fileNameRemoveExtension.Substring(fileNameRemoveExtension.IndexOf(".")), "");
            }
            string des = $"{txtFilePath.Text}/{fileNameRemoveExtension}{this.extension}";
            fileManagement.copy(src, des);
            DialogResult result = MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK);
            if(result.Equals(DialogResult.OK))
            {
                this.Close();
            }
        }
    }
}
