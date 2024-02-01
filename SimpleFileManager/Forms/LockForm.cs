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
    public partial class LockForm : Form
    {
        BitlockerService bitlocker;

        public LockForm()
        {
            InitializeComponent();
            bitlocker = BitlockerService.Instance;
        }

        private void LockForm_Load(object sender, EventArgs e)
        {
            configShowUpLockProgress(false);
        }

        private void configShowUpLockProgress(bool isStart)
        {
            prgLock.Visible = isStart;
            btnLock.Visible = !isStart;
            btnLock.Enabled = !isStart;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            configShowUpLockProgress(true);
            process();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(prgLock.Value == prgLock.Maximum)
            {
                prgLock.PerformStep();
            } else
            {
                timer1.Stop();
                lockDrive();
                prgLock.Value = 0;
            }
        }

        private void process()
        {
            timer1.Start();
        }

        private void lockDrive()
        {
            bool locked = bitlocker.lockDrive();
            if(locked)
            {
                DialogResult result = MessageBox.Show("Khóa thành công", "Thông báo", MessageBoxButtons.OK);
                if(result == DialogResult.OK)
                {
                    this.Close();
                }
            } else
            {
                MessageBox.Show("Đã có lỗi xảy ra", "Lỗi", MessageBoxButtons.OK);
            }
        } 
    }
}
