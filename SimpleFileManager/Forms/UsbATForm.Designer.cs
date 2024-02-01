namespace SimpleFileManager
{
    partial class UsbAtForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsbAtForm));
            this.btnSysBack = new System.Windows.Forms.Button();
            this.lvSystem = new System.Windows.Forms.ListView();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.lvRemovable = new System.Windows.Forms.ListView();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnRemDelete = new System.Windows.Forms.Button();
            this.btnRemBack = new System.Windows.Forms.Button();
            this.btnSysDelete = new System.Windows.Forms.Button();
            this.btnSysNewFile = new System.Windows.Forms.Button();
            this.btnRemNewFile = new System.Windows.Forms.Button();
            this.btnSysNewFolder = new System.Windows.Forms.Button();
            this.btnRemNewFolder = new System.Windows.Forms.Button();
            this.btnUnlockDrive = new System.Windows.Forms.Button();
            this.btnLockDrive = new System.Windows.Forms.Button();
            this.lbRemPath = new System.Windows.Forms.Label();
            this.lbPath = new System.Windows.Forms.Label();
            this.cbDrive = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSysBack
            // 
            this.btnSysBack.Image = ((System.Drawing.Image)(resources.GetObject("btnSysBack.Image")));
            this.btnSysBack.Location = new System.Drawing.Point(11, 13);
            this.btnSysBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnSysBack.Name = "btnSysBack";
            this.btnSysBack.Size = new System.Drawing.Size(92, 63);
            this.btnSysBack.TabIndex = 0;
            this.btnSysBack.UseVisualStyleBackColor = true;
            this.btnSysBack.Click += new System.EventHandler(this.sysBackButton_Click);
            // 
            // lvSystem
            // 
            this.lvSystem.BackColor = System.Drawing.Color.LightGreen;
            this.lvSystem.HideSelection = false;
            this.lvSystem.LargeImageList = this.iconList;
            this.lvSystem.Location = new System.Drawing.Point(2, 80);
            this.lvSystem.Margin = new System.Windows.Forms.Padding(2);
            this.lvSystem.Name = "lvSystem";
            this.lvSystem.Size = new System.Drawing.Size(971, 192);
            this.lvSystem.SmallImageList = this.iconList;
            this.lvSystem.TabIndex = 2;
            this.lvSystem.UseCompatibleStateImageBehavior = false;
            this.lvSystem.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.lvSystem.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "folder.png");
            this.iconList.Images.SetKeyName(1, "folder2.png");
            this.iconList.Images.SetKeyName(2, "file.png");
            this.iconList.Images.SetKeyName(3, "doc.png");
            this.iconList.Images.SetKeyName(4, "pdf.png");
            this.iconList.Images.SetKeyName(5, "mp3.png");
            this.iconList.Images.SetKeyName(6, "mp4.png");
            this.iconList.Images.SetKeyName(7, "exe.png");
            this.iconList.Images.SetKeyName(8, "unknown.png");
            this.iconList.Images.SetKeyName(9, "png.png");
            this.iconList.Images.SetKeyName(10, "folder64.png");
            // 
            // lvRemovable
            // 
            this.lvRemovable.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lvRemovable.HideSelection = false;
            this.lvRemovable.LargeImageList = this.iconList;
            this.lvRemovable.Location = new System.Drawing.Point(2, 348);
            this.lvRemovable.Margin = new System.Windows.Forms.Padding(2);
            this.lvRemovable.Name = "lvRemovable";
            this.lvRemovable.Size = new System.Drawing.Size(971, 222);
            this.lvRemovable.SmallImageList = this.iconList;
            this.lvRemovable.TabIndex = 8;
            this.lvRemovable.UseCompatibleStateImageBehavior = false;
            this.lvRemovable.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvRemovable_ItemSelectionChanged);
            this.lvRemovable.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvRemovable_MouseDoubleClick);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Image = ((System.Drawing.Image)(resources.GetObject("btnMoveDown.Image")));
            this.btnMoveDown.Location = new System.Drawing.Point(581, 275);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(92, 66);
            this.btnMoveDown.TabIndex = 9;
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Image = ((System.Drawing.Image)(resources.GetObject("btnMoveUp.Image")));
            this.btnMoveUp.Location = new System.Drawing.Point(385, 275);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(92, 66);
            this.btnMoveUp.TabIndex = 10;
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnRemDelete
            // 
            this.btnRemDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnRemDelete.Image")));
            this.btnRemDelete.Location = new System.Drawing.Point(863, 276);
            this.btnRemDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemDelete.Name = "btnRemDelete";
            this.btnRemDelete.Size = new System.Drawing.Size(110, 65);
            this.btnRemDelete.TabIndex = 11;
            this.btnRemDelete.UseVisualStyleBackColor = true;
            this.btnRemDelete.Click += new System.EventHandler(this.btnRemDelete_Click);
            // 
            // btnRemBack
            // 
            this.btnRemBack.Image = ((System.Drawing.Image)(resources.GetObject("btnRemBack.Image")));
            this.btnRemBack.Location = new System.Drawing.Point(11, 281);
            this.btnRemBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemBack.Name = "btnRemBack";
            this.btnRemBack.Size = new System.Drawing.Size(92, 63);
            this.btnRemBack.TabIndex = 12;
            this.btnRemBack.UseVisualStyleBackColor = true;
            this.btnRemBack.Click += new System.EventHandler(this.btnRomBack_Click);
            // 
            // btnSysDelete
            // 
            this.btnSysDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnSysDelete.Image")));
            this.btnSysDelete.Location = new System.Drawing.Point(863, 11);
            this.btnSysDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnSysDelete.Name = "btnSysDelete";
            this.btnSysDelete.Size = new System.Drawing.Size(110, 65);
            this.btnSysDelete.TabIndex = 13;
            this.btnSysDelete.UseVisualStyleBackColor = true;
            this.btnSysDelete.Click += new System.EventHandler(this.btnSysDelete_Click);
            // 
            // btnSysNewFile
            // 
            this.btnSysNewFile.Image = ((System.Drawing.Image)(resources.GetObject("btnSysNewFile.Image")));
            this.btnSysNewFile.Location = new System.Drawing.Point(107, 13);
            this.btnSysNewFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnSysNewFile.Name = "btnSysNewFile";
            this.btnSysNewFile.Size = new System.Drawing.Size(96, 63);
            this.btnSysNewFile.TabIndex = 14;
            this.btnSysNewFile.UseVisualStyleBackColor = true;
            this.btnSysNewFile.Click += new System.EventHandler(this.btnSysNewFile_Click);
            // 
            // btnRemNewFile
            // 
            this.btnRemNewFile.Image = ((System.Drawing.Image)(resources.GetObject("btnRemNewFile.Image")));
            this.btnRemNewFile.Location = new System.Drawing.Point(107, 281);
            this.btnRemNewFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemNewFile.Name = "btnRemNewFile";
            this.btnRemNewFile.Size = new System.Drawing.Size(96, 63);
            this.btnRemNewFile.TabIndex = 15;
            this.btnRemNewFile.UseVisualStyleBackColor = true;
            this.btnRemNewFile.Click += new System.EventHandler(this.btnRemNewFile_Click);
            // 
            // btnSysNewFolder
            // 
            this.btnSysNewFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnSysNewFolder.Image")));
            this.btnSysNewFolder.Location = new System.Drawing.Point(207, 13);
            this.btnSysNewFolder.Margin = new System.Windows.Forms.Padding(2);
            this.btnSysNewFolder.Name = "btnSysNewFolder";
            this.btnSysNewFolder.Size = new System.Drawing.Size(96, 63);
            this.btnSysNewFolder.TabIndex = 16;
            this.btnSysNewFolder.UseVisualStyleBackColor = true;
            this.btnSysNewFolder.Click += new System.EventHandler(this.btnSysNewFolder_Click);
            // 
            // btnRemNewFolder
            // 
            this.btnRemNewFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnRemNewFolder.Image")));
            this.btnRemNewFolder.Location = new System.Drawing.Point(207, 281);
            this.btnRemNewFolder.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemNewFolder.Name = "btnRemNewFolder";
            this.btnRemNewFolder.Size = new System.Drawing.Size(96, 63);
            this.btnRemNewFolder.TabIndex = 17;
            this.btnRemNewFolder.UseVisualStyleBackColor = true;
            this.btnRemNewFolder.Click += new System.EventHandler(this.btnRemNewFolder_Click);
            // 
            // btnUnlockDrive
            // 
            this.btnUnlockDrive.Image = ((System.Drawing.Image)(resources.GetObject("btnUnlockDrive.Image")));
            this.btnUnlockDrive.Location = new System.Drawing.Point(483, 275);
            this.btnUnlockDrive.Name = "btnUnlockDrive";
            this.btnUnlockDrive.Size = new System.Drawing.Size(92, 66);
            this.btnUnlockDrive.TabIndex = 18;
            this.btnUnlockDrive.UseVisualStyleBackColor = true;
            this.btnUnlockDrive.Click += new System.EventHandler(this.btnUnlockDrive_Click);
            // 
            // btnLockDrive
            // 
            this.btnLockDrive.Image = ((System.Drawing.Image)(resources.GetObject("btnLockDrive.Image")));
            this.btnLockDrive.Location = new System.Drawing.Point(483, 275);
            this.btnLockDrive.Name = "btnLockDrive";
            this.btnLockDrive.Size = new System.Drawing.Size(92, 66);
            this.btnLockDrive.TabIndex = 19;
            this.btnLockDrive.UseVisualStyleBackColor = true;
            this.btnLockDrive.Click += new System.EventHandler(this.btnLockDrive_Click);
            // 
            // lbRemPath
            // 
            this.lbRemPath.AutoSize = true;
            this.lbRemPath.Location = new System.Drawing.Point(204, 572);
            this.lbRemPath.Name = "lbRemPath";
            this.lbRemPath.Size = new System.Drawing.Size(35, 13);
            this.lbRemPath.TabIndex = 20;
            this.lbRemPath.Text = "label2";
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.Location = new System.Drawing.Point(435, 36);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(35, 13);
            this.lbPath.TabIndex = 21;
            this.lbPath.Text = "label4";
            // 
            // cbDrive
            // 
            this.cbDrive.FormattingEnabled = true;
            this.cbDrive.Location = new System.Drawing.Point(308, 33);
            this.cbDrive.Name = "cbDrive";
            this.cbDrive.Size = new System.Drawing.Size(121, 21);
            this.cbDrive.TabIndex = 23;
            this.cbDrive.SelectedIndexChanged += new System.EventHandler(this.cbDrive_SelectedIndexChanged);
            // 
            // UsbAtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(974, 609);
            this.Controls.Add(this.cbDrive);
            this.Controls.Add(this.lbPath);
            this.Controls.Add(this.lbRemPath);
            this.Controls.Add(this.btnLockDrive);
            this.Controls.Add(this.btnUnlockDrive);
            this.Controls.Add(this.btnRemNewFolder);
            this.Controls.Add(this.btnSysNewFolder);
            this.Controls.Add(this.btnRemNewFile);
            this.Controls.Add(this.btnSysNewFile);
            this.Controls.Add(this.btnSysDelete);
            this.Controls.Add(this.btnRemBack);
            this.Controls.Add(this.btnRemDelete);
            this.Controls.Add(this.btnMoveUp);
            this.Controls.Add(this.btnMoveDown);
            this.Controls.Add(this.lvRemovable);
            this.Controls.Add(this.lvSystem);
            this.Controls.Add(this.btnSysBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UsbAtForm";
            this.Text = "USB-AT Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSysBack;
        private System.Windows.Forms.ListView lvSystem;
        private System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.ListView lvRemovable;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnRemDelete;
        private System.Windows.Forms.Button btnRemBack;
        private System.Windows.Forms.Button btnSysDelete;
        private System.Windows.Forms.Button btnSysNewFile;
        private System.Windows.Forms.Button btnRemNewFile;
        private System.Windows.Forms.Button btnSysNewFolder;
        private System.Windows.Forms.Button btnRemNewFolder;
        private System.Windows.Forms.Button btnUnlockDrive;
        private System.Windows.Forms.Button btnLockDrive;
        private System.Windows.Forms.Label lbRemPath;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.ComboBox cbDrive;
    }
}

