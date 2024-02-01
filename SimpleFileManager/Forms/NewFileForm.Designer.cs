namespace SimpleFileManager
{
    partial class NewFileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewFileForm));
            this.txtNewRes = new System.Windows.Forms.TextBox();
            this.btnNewSysFile = new System.Windows.Forms.Button();
            this.btnNewRemFile = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbExtenstion = new System.Windows.Forms.ComboBox();
            this.txtRootPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.prgCreate = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // txtNewRes
            // 
            this.txtNewRes.Location = new System.Drawing.Point(66, 38);
            this.txtNewRes.Name = "txtNewRes";
            this.txtNewRes.Size = new System.Drawing.Size(206, 20);
            this.txtNewRes.TabIndex = 0;
            // 
            // btnNewSysFile
            // 
            this.btnNewSysFile.Image = ((System.Drawing.Image)(resources.GetObject("btnNewSysFile.Image")));
            this.btnNewSysFile.Location = new System.Drawing.Point(115, 64);
            this.btnNewSysFile.Name = "btnNewSysFile";
            this.btnNewSysFile.Size = new System.Drawing.Size(242, 35);
            this.btnNewSysFile.TabIndex = 1;
            this.btnNewSysFile.UseVisualStyleBackColor = true;
            this.btnNewSysFile.Click += new System.EventHandler(this.btnNewSysFile_Click);
            // 
            // btnNewRemFile
            // 
            this.btnNewRemFile.Image = ((System.Drawing.Image)(resources.GetObject("btnNewRemFile.Image")));
            this.btnNewRemFile.Location = new System.Drawing.Point(115, 64);
            this.btnNewRemFile.Name = "btnNewRemFile";
            this.btnNewRemFile.Size = new System.Drawing.Size(242, 35);
            this.btnNewRemFile.TabIndex = 2;
            this.btnNewRemFile.UseVisualStyleBackColor = true;
            this.btnNewRemFile.Click += new System.EventHandler(this.btnNewRemFile_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(9, 64);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbExtenstion
            // 
            this.cbExtenstion.FormattingEnabled = true;
            this.cbExtenstion.Location = new System.Drawing.Point(278, 37);
            this.cbExtenstion.Name = "cbExtenstion";
            this.cbExtenstion.Size = new System.Drawing.Size(79, 21);
            this.cbExtenstion.TabIndex = 4;
            // 
            // txtRootPath
            // 
            this.txtRootPath.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtRootPath.Location = new System.Drawing.Point(66, 12);
            this.txtRootPath.Name = "txtRootPath";
            this.txtRootPath.ReadOnly = true;
            this.txtRootPath.Size = new System.Drawing.Size(291, 20);
            this.txtRootPath.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Root Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "File Name";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // prgCreate
            // 
            this.prgCreate.Location = new System.Drawing.Point(115, 64);
            this.prgCreate.Name = "prgCreate";
            this.prgCreate.Size = new System.Drawing.Size(242, 34);
            this.prgCreate.TabIndex = 8;
            // 
            // NewFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(361, 110);
            this.Controls.Add(this.prgCreate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRootPath);
            this.Controls.Add(this.cbExtenstion);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNewRemFile);
            this.Controls.Add(this.btnNewSysFile);
            this.Controls.Add(this.txtNewRes);
            this.Name = "NewFileForm";
            this.Text = "New File";
            this.Load += new System.EventHandler(this.NewResForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewRes;
        private System.Windows.Forms.Button btnNewSysFile;
        private System.Windows.Forms.Button btnNewRemFile;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbExtenstion;
        private System.Windows.Forms.TextBox txtRootPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar prgCreate;
    }
}