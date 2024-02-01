namespace SimpleFileManager.Forms
{
    partial class UnlockDriveForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnlockDriveForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnUnlock = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.prgUnlock = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(61, 12);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(266, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // btnUnlock
            // 
            this.btnUnlock.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUnlock.Image = ((System.Drawing.Image)(resources.GetObject("btnUnlock.Image")));
            this.btnUnlock.Location = new System.Drawing.Point(163, 38);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(164, 36);
            this.btnUnlock.TabIndex = 2;
            this.btnUnlock.UseVisualStyleBackColor = false;
            this.btnUnlock.Click += new System.EventHandler(this.btnUnlock_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(61, 38);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 36);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // prgUnlock
            // 
            this.prgUnlock.Location = new System.Drawing.Point(163, 38);
            this.prgUnlock.Name = "prgUnlock";
            this.prgUnlock.Size = new System.Drawing.Size(164, 36);
            this.prgUnlock.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Orange;
            this.linkLabel1.Location = new System.Drawing.Point(257, 77);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(70, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Đổi mật khẩu";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // UnlockDriveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(344, 98);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.prgUnlock);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUnlock);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label1);
            this.Name = "UnlockDriveForm";
            this.Text = "Unlock Your Drive";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnUnlock;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ProgressBar prgUnlock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}