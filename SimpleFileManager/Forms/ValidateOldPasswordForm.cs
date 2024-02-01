using SimpleFileManager.Forms;
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

namespace USBAT.Forms
{
    public partial class ValidateOldPasswordForm : Form
    {
        private BitlockerService bitlocker;

        public ValidateOldPasswordForm()
        {
            InitializeComponent();
            bitlocker = BitlockerService.Instance;
        }

        private void ValidateOldPasswordForm_Load(object sender, EventArgs e)
        {
            configShowUpValidateProgress(false);
        }

        private void configShowUpValidateProgress(bool isStart)
        {
            prgValidate.Visible = isStart;
            txtCurrentPassword.ReadOnly = isStart;
            btnValidate.Visible = !isStart;
            btnValidate.Enabled = !isStart;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            configShowUpValidateProgress(true);
            process();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(prgValidate.Value < prgValidate.Maximum)
            {
                prgValidate.PerformStep();
            } else
            {
                timer1.Stop();
                validate();
                configShowUpValidateProgress(false);
            }
        }

        private void process()
        {
            timer1.Start();
        }

        private void validate()
        {
            string password = bitlocker.encodeBase64Password(txtCurrentPassword.Text);
            bool validated = bitlocker.validOldPassword(password);
            if(validated)
            {
                DialogResult result = MessageBox.Show("Mật khẩu hợp lệ", "Thông báo", MessageBoxButtons.OK);
                if(result == DialogResult.OK)
                {
                    ChangePasswordForm changePasswordForm = new ChangePasswordForm(password);
                    changePasswordForm.Show();
                    changePasswordForm.FormClosing += new FormClosingEventHandler(this.formClosingEvent);
                }
            } else
            {
                MessageBox.Show("Mật khẩu không đúng", "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void formClosingEvent(object sender, FormClosingEventArgs args)
        {
            this.Close();
        }
    }
}

