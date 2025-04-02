namespace MaHoaDES.BieuMau
{
    partial class frmMaHoaDES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaHoaDES));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.BoxTextCrypt = new System.Windows.Forms.GroupBox();
            this.txtVanBanDich = new System.Windows.Forms.RichTextBox();
            this.txtVanBanNguon = new System.Windows.Forms.RichTextBox();
            this.txtKhoaVanBan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMaHoaVanBan = new System.Windows.Forms.Button();
            this.btnGiaiMaVanBan = new System.Windows.Forms.Button();
            this.BoxFileCrypt = new System.Windows.Forms.GroupBox();
            this.txtFileDich = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFileNguon = new System.Windows.Forms.TextBox();
            this.txtKhoaFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnChonFile = new System.Windows.Forms.Button();
            this.lblEncryptedFilename = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMaHoaFile = new System.Windows.Forms.Button();
            this.btnGiaiMaFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.BoxTextCrypt.SuspendLayout();
            this.BoxFileCrypt.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Location = new System.Drawing.Point(8, 196);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(560, 75);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiến trình";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 58);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 16);
            this.lblStatus.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(523, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 27);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(504, 25);
            this.progressBar1.TabIndex = 0;
            // 
            // BoxTextCrypt
            // 
            this.BoxTextCrypt.Controls.Add(this.txtVanBanDich);
            this.BoxTextCrypt.Controls.Add(this.txtVanBanNguon);
            this.BoxTextCrypt.Controls.Add(this.txtKhoaVanBan);
            this.BoxTextCrypt.Controls.Add(this.label4);
            this.BoxTextCrypt.Controls.Add(this.label5);
            this.BoxTextCrypt.Controls.Add(this.label2);
            this.BoxTextCrypt.Controls.Add(this.btnMaHoaVanBan);
            this.BoxTextCrypt.Controls.Add(this.btnGiaiMaVanBan);
            this.BoxTextCrypt.Location = new System.Drawing.Point(600, 15);
            this.BoxTextCrypt.Margin = new System.Windows.Forms.Padding(4);
            this.BoxTextCrypt.Name = "BoxTextCrypt";
            this.BoxTextCrypt.Padding = new System.Windows.Forms.Padding(4);
            this.BoxTextCrypt.Size = new System.Drawing.Size(576, 330);
            this.BoxTextCrypt.TabIndex = 26;
            this.BoxTextCrypt.TabStop = false;
            this.BoxTextCrypt.Text = "Mã hoá và Giải mã văn bản(Text)";
            // 
            // txtVanBanDich
            // 
            this.txtVanBanDich.Location = new System.Drawing.Point(57, 156);
            this.txtVanBanDich.Margin = new System.Windows.Forms.Padding(4);
            this.txtVanBanDich.Name = "txtVanBanDich";
            this.txtVanBanDich.Size = new System.Drawing.Size(509, 114);
            this.txtVanBanDich.TabIndex = 26;
            this.txtVanBanDich.Text = "";
            // 
            // txtVanBanNguon
            // 
            this.txtVanBanNguon.Location = new System.Drawing.Point(57, 22);
            this.txtVanBanNguon.Margin = new System.Windows.Forms.Padding(4);
            this.txtVanBanNguon.Name = "txtVanBanNguon";
            this.txtVanBanNguon.Size = new System.Drawing.Size(509, 78);
            this.txtVanBanNguon.TabIndex = 26;
            this.txtVanBanNguon.Text = "";
            // 
            // txtKhoaVanBan
            // 
            this.txtKhoaVanBan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtKhoaVanBan.Location = new System.Drawing.Point(57, 108);
            this.txtKhoaVanBan.Margin = new System.Windows.Forms.Padding(4);
            this.txtKhoaVanBan.MaxLength = 16;
            this.txtKhoaVanBan.Name = "txtKhoaVanBan";
            this.txtKhoaVanBan.Size = new System.Drawing.Size(509, 22);
            this.txtKhoaVanBan.TabIndex = 17;
            this.txtKhoaVanBan.Text = "0123456789ABCDE1";
            this.txtKhoaVanBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKhoaFile_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Kết quả mã hoá và giải mã";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Khoá\n(Hex)";
         
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Text : ";
            // 
            // btnMaHoaVanBan
            // 
            this.btnMaHoaVanBan.Location = new System.Drawing.Point(129, 282);
            this.btnMaHoaVanBan.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaHoaVanBan.Name = "btnMaHoaVanBan";
            this.btnMaHoaVanBan.Size = new System.Drawing.Size(135, 31);
            this.btnMaHoaVanBan.TabIndex = 10;
            this.btnMaHoaVanBan.Text = "Mã hoá văn bản";
            this.btnMaHoaVanBan.UseVisualStyleBackColor = true;
            this.btnMaHoaVanBan.Click += new System.EventHandler(this.txtMaHoaVanBan_Click);
            // 
            // btnGiaiMaVanBan
            // 
            this.btnGiaiMaVanBan.Location = new System.Drawing.Point(301, 282);
            this.btnGiaiMaVanBan.Margin = new System.Windows.Forms.Padding(4);
            this.btnGiaiMaVanBan.Name = "btnGiaiMaVanBan";
            this.btnGiaiMaVanBan.Size = new System.Drawing.Size(136, 31);
            this.btnGiaiMaVanBan.TabIndex = 13;
            this.btnGiaiMaVanBan.Text = "Giải mã văn bản";
            this.btnGiaiMaVanBan.UseVisualStyleBackColor = true;
            this.btnGiaiMaVanBan.Click += new System.EventHandler(this.txtGiaiMaVanBan_Click);
            // 
            // BoxFileCrypt
            // 
            this.BoxFileCrypt.Controls.Add(this.groupBox1);
            this.BoxFileCrypt.Controls.Add(this.txtFileDich);
            this.BoxFileCrypt.Controls.Add(this.label9);
            this.BoxFileCrypt.Controls.Add(this.txtFileNguon);
            this.BoxFileCrypt.Controls.Add(this.txtKhoaFile);
            this.BoxFileCrypt.Controls.Add(this.label1);
            this.BoxFileCrypt.Controls.Add(this.label8);
            this.BoxFileCrypt.Controls.Add(this.btnChonFile);
            this.BoxFileCrypt.Controls.Add(this.lblEncryptedFilename);
            this.BoxFileCrypt.Controls.Add(this.label3);
            this.BoxFileCrypt.Controls.Add(this.btnMaHoaFile);
            this.BoxFileCrypt.Controls.Add(this.btnGiaiMaFile);
            this.BoxFileCrypt.Location = new System.Drawing.Point(17, 15);
            this.BoxFileCrypt.Margin = new System.Windows.Forms.Padding(4);
            this.BoxFileCrypt.Name = "BoxFileCrypt";
            this.BoxFileCrypt.Padding = new System.Windows.Forms.Padding(4);
            this.BoxFileCrypt.Size = new System.Drawing.Size(579, 330);
            this.BoxFileCrypt.TabIndex = 24;
            this.BoxFileCrypt.TabStop = false;
            this.BoxFileCrypt.Text = "Mã hoá và giải mã 1 file";
            // 
            // txtFileDich
            // 
            this.txtFileDich.Location = new System.Drawing.Point(95, 54);
            this.txtFileDich.Margin = new System.Windows.Forms.Padding(4);
            this.txtFileDich.Name = "txtFileDich";
            this.txtFileDich.ReadOnly = true;
            this.txtFileDich.Size = new System.Drawing.Size(416, 22);
            this.txtFileDich.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 59);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "Đổi tên file";
            // 
            // txtFileNguon
            // 
            this.txtFileNguon.Location = new System.Drawing.Point(95, 18);
            this.txtFileNguon.Margin = new System.Windows.Forms.Padding(4);
            this.txtFileNguon.Name = "txtFileNguon";
            this.txtFileNguon.ReadOnly = true;
            this.txtFileNguon.Size = new System.Drawing.Size(323, 22);
            this.txtFileNguon.TabIndex = 5;
            // 
            // txtKhoaFile
            // 
            this.txtKhoaFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtKhoaFile.Location = new System.Drawing.Point(95, 108);
            this.txtKhoaFile.Margin = new System.Windows.Forms.Padding(4);
            this.txtKhoaFile.MaxLength = 16;
            this.txtKhoaFile.Name = "txtKhoaFile";
            this.txtKhoaFile.Size = new System.Drawing.Size(417, 22);
            this.txtKhoaFile.TabIndex = 23;
            this.txtKhoaFile.Text = "0123456789ABCDE1";
            this.txtKhoaFile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKhoaFile_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "File : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 108);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Khoá\n(Hex)";
            // 
            // btnChonFile
            // 
            this.btnChonFile.Location = new System.Drawing.Point(427, 16);
            this.btnChonFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnChonFile.Name = "btnChonFile";
            this.btnChonFile.Size = new System.Drawing.Size(85, 28);
            this.btnChonFile.TabIndex = 16;
            this.btnChonFile.Text = "Files..";
            this.btnChonFile.UseVisualStyleBackColor = true;
            this.btnChonFile.Click += new System.EventHandler(this.btnChonFile_Click);
            // 
            // lblEncryptedFilename
            // 
            this.lblEncryptedFilename.AutoSize = true;
            this.lblEncryptedFilename.Location = new System.Drawing.Point(11, 59);
            this.lblEncryptedFilename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEncryptedFilename.Name = "lblEncryptedFilename";
            this.lblEncryptedFilename.Size = new System.Drawing.Size(0, 16);
            this.lblEncryptedFilename.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 8;
            // 
            // btnMaHoaFile
            // 
            this.btnMaHoaFile.Location = new System.Drawing.Point(136, 282);
            this.btnMaHoaFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaHoaFile.Name = "btnMaHoaFile";
            this.btnMaHoaFile.Size = new System.Drawing.Size(119, 31);
            this.btnMaHoaFile.TabIndex = 12;
            this.btnMaHoaFile.Text = "Mã hoá file";
            this.btnMaHoaFile.UseVisualStyleBackColor = true;
            this.btnMaHoaFile.Click += new System.EventHandler(this.btnMaHoaFile_Click);
            // 
            // btnGiaiMaFile
            // 
            this.btnGiaiMaFile.Location = new System.Drawing.Point(300, 282);
            this.btnGiaiMaFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnGiaiMaFile.Name = "btnGiaiMaFile";
            this.btnGiaiMaFile.Size = new System.Drawing.Size(119, 31);
            this.btnGiaiMaFile.TabIndex = 11;
            this.btnGiaiMaFile.Text = "Giải mã file";
            this.btnGiaiMaFile.UseVisualStyleBackColor = true;
            this.btnGiaiMaFile.Click += new System.EventHandler(this.btnGiaiMaFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmMaHoaDES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 362);
            this.Controls.Add(this.BoxTextCrypt);
            this.Controls.Add(this.BoxFileCrypt);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMaHoaDES";
            this.Text = "frmMaHoaDES";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMaHoaDES_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.BoxTextCrypt.ResumeLayout(false);
            this.BoxTextCrypt.PerformLayout();
            this.BoxFileCrypt.ResumeLayout(false);
            this.BoxFileCrypt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox BoxTextCrypt;
        private System.Windows.Forms.TextBox txtKhoaVanBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMaHoaVanBan;
        private System.Windows.Forms.Button btnGiaiMaVanBan;
        private System.Windows.Forms.GroupBox BoxFileCrypt;
        private System.Windows.Forms.TextBox txtFileDich;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFileNguon;
        private System.Windows.Forms.TextBox txtKhoaFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnChonFile;
        private System.Windows.Forms.Label lblEncryptedFilename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMaHoaFile;
        private System.Windows.Forms.Button btnGiaiMaFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox txtVanBanDich;
        private System.Windows.Forms.RichTextBox txtVanBanNguon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblStatus;
    }
}