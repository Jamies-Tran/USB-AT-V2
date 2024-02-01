namespace SimpleFileManager.Forms
{
    partial class NewFolderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewFolderForm));
            this.txtRootPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFolderName = new System.Windows.Forms.TextBox();
            this.btnNewRemFolder = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNewSysFolder = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.prgNewFolder = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // txtRootPath
            // 
            this.txtRootPath.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtRootPath.Location = new System.Drawing.Point(85, 6);
            this.txtRootPath.Name = "txtRootPath";
            this.txtRootPath.ReadOnly = true;
            this.txtRootPath.Size = new System.Drawing.Size(275, 20);
            this.txtRootPath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Root Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Folder Name";
            // 
            // txtFolderName
            // 
            this.txtFolderName.Location = new System.Drawing.Point(85, 33);
            this.txtFolderName.Name = "txtFolderName";
            this.txtFolderName.Size = new System.Drawing.Size(275, 20);
            this.txtFolderName.TabIndex = 3;
            // 
            // btnNewRemFolder
            // 
            this.btnNewRemFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnNewRemFolder.Image")));
            this.btnNewRemFolder.Location = new System.Drawing.Point(118, 59);
            this.btnNewRemFolder.Name = "btnNewRemFolder";
            this.btnNewRemFolder.Size = new System.Drawing.Size(242, 35);
            this.btnNewRemFolder.TabIndex = 7;
            this.btnNewRemFolder.UseVisualStyleBackColor = true;
            this.btnNewRemFolder.Click += new System.EventHandler(this.btnNewRemFolder_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(12, 59);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNewSysFolder
            // 
            this.btnNewSysFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnNewSysFolder.Image")));
            this.btnNewSysFolder.Location = new System.Drawing.Point(118, 59);
            this.btnNewSysFolder.Name = "btnNewSysFolder";
            this.btnNewSysFolder.Size = new System.Drawing.Size(242, 35);
            this.btnNewSysFolder.TabIndex = 9;
            this.btnNewSysFolder.UseVisualStyleBackColor = true;
            this.btnNewSysFolder.Click += new System.EventHandler(this.btnNewSysFolder_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // prgNewFolder
            // 
            this.prgNewFolder.Location = new System.Drawing.Point(118, 59);
            this.prgNewFolder.Name = "prgNewFolder";
            this.prgNewFolder.Size = new System.Drawing.Size(242, 35);
            this.prgNewFolder.TabIndex = 10;
            // 
            // NewFolderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(376, 109);
            this.Controls.Add(this.prgNewFolder);
            this.Controls.Add(this.btnNewSysFolder);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNewRemFolder);
            this.Controls.Add(this.txtFolderName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRootPath);
            this.Name = "NewFolderForm";
            this.Text = "New Folder";
            this.Load += new System.EventHandler(this.NewFolderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRootPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFolderName;
        private System.Windows.Forms.Button btnNewRemFolder;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNewSysFolder;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar prgNewFolder;
    }
}