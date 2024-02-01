namespace USBAT.Forms
{
    partial class LockForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LockForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.prgLock = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(202, 112);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 34);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLock
            // 
            this.btnLock.Image = ((System.Drawing.Image)(resources.GetObject("btnLock.Image")));
            this.btnLock.Location = new System.Drawing.Point(186, 46);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(142, 60);
            this.btnLock.TabIndex = 1;
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bạn có muốn khóa USB-AT?";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // prgLock
            // 
            this.prgLock.Location = new System.Drawing.Point(186, 46);
            this.prgLock.Name = "prgLock";
            this.prgLock.Size = new System.Drawing.Size(142, 60);
            this.prgLock.TabIndex = 3;
            // 
            // LockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(511, 179);
            this.Controls.Add(this.prgLock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLock);
            this.Controls.Add(this.btnCancel);
            this.Name = "LockForm";
            this.Text = "Lock";
            this.Load += new System.EventHandler(this.LockForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar prgLock;
    }
}