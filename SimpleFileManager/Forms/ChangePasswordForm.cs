using SimpleFileManager.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFileManager.Forms
{
    public partial class ChangePasswordForm : Form
    {
        private BitlockerService bitlocker;
        private string encodedPasswordString;

        public ChangePasswordForm(string encodedPasswordString)
        {
            InitializeComponent();
            bitlocker = BitlockerService.Instance;
            this.encodedPasswordString = encodedPasswordString;
        }

        private void UnlockProgressForm_Load(object sender, EventArgs e)
        {
            configShowUpChangeProgress(false);
        }

        private void configShowUpChangeProgress(bool isStart)
        {
            prgChangePass.Visible = isStart;
            txtNewPassword.ReadOnly = isStart;
            btnChange.Visible = !isStart;
            btnChange.Enabled = !isStart;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thay đổi password?", "Thông báo", MessageBoxButtons.OKCancel);
            if(result.Equals(DialogResult.OK))
            {
                configShowUpChangeProgress(true);
                process();
            } else if(result.Equals(DialogResult.Cancel))
            {
                restore();
                this.Close();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(prgChangePass.Value < prgChangePass.Maximum)
            {
                prgChangePass.PerformStep();
            } else
            {
                timer1.Stop();
                changePass();
            }
        }

        private void process()
        {
            timer1.Start();
        }

        private void changePass()
        {
            string newPass = bitlocker.encodeBase64Password(txtNewPassword.Text);
            bool changed = bitlocker.changePassphrase(newPass);
            if(changed)
            {
                DialogResult result = MessageBox.Show("Password đã thay đổi", "Thông báo", MessageBoxButtons.OK);
                if(result == DialogResult.OK)
                {
                    this.Close();
                }
            } else
            {
                MessageBox.Show("Không thể thay đổi password", "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void restore()
        {
            bitlocker.cancelChangePassword(txtNewPassword.Text);
        }
    }
}
