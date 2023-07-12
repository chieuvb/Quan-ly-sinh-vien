namespace Presentation.Forms.Edit
{
    partial class fmEditSinh
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.grbContact = new System.Windows.Forms.GroupBox();
            this.tbxDienthoai = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.cbbLop = new System.Windows.Forms.ComboBox();
            this.grbAddress = new System.Windows.Forms.GroupBox();
            this.cbbTinh = new System.Windows.Forms.ComboBox();
            this.tbxDiachi = new System.Windows.Forms.TextBox();
            this.cbbHuyen = new System.Windows.Forms.ComboBox();
            this.cbbXa = new System.Windows.Forms.ComboBox();
            this.grbGender = new System.Windows.Forms.GroupBox();
            this.rdbFem = new System.Windows.Forms.RadioButton();
            this.rdbMal = new System.Windows.Forms.RadioButton();
            this.tbxTen = new System.Windows.Forms.TextBox();
            this.tbxMasv = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnCan = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.ptbAvatar = new System.Windows.Forms.PictureBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grbContact.SuspendLayout();
            this.grbAddress.SuspendLayout();
            this.grbGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpNgaysinh);
            this.groupBox1.Location = new System.Drawing.Point(440, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 57);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ngày sinh";
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.CustomFormat = "dd-MM-yyyy";
            this.dtpNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaysinh.Location = new System.Drawing.Point(6, 25);
            this.dtpNgaysinh.MaxDate = new System.DateTime(2009, 12, 31, 0, 0, 0, 0);
            this.dtpNgaysinh.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(206, 26);
            this.dtpNgaysinh.TabIndex = 5;
            this.dtpNgaysinh.Value = new System.DateTime(2009, 12, 31, 0, 0, 0, 0);
            // 
            // grbContact
            // 
            this.grbContact.Controls.Add(this.tbxDienthoai);
            this.grbContact.Controls.Add(this.tbxEmail);
            this.grbContact.Location = new System.Drawing.Point(274, 359);
            this.grbContact.Name = "grbContact";
            this.grbContact.Size = new System.Drawing.Size(390, 89);
            this.grbContact.TabIndex = 22;
            this.grbContact.TabStop = false;
            this.grbContact.Text = "Thông tin liên hệ";
            // 
            // tbxDienthoai
            // 
            this.tbxDienthoai.Location = new System.Drawing.Point(6, 25);
            this.tbxDienthoai.MaxLength = 10;
            this.tbxDienthoai.Name = "tbxDienthoai";
            this.tbxDienthoai.Size = new System.Drawing.Size(378, 26);
            this.tbxDienthoai.TabIndex = 11;
            this.tbxDienthoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxDienthoai_KeyPress);
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(6, 57);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(378, 26);
            this.tbxEmail.TabIndex = 12;
            // 
            // cbbLop
            // 
            this.cbbLop.DropDownHeight = 256;
            this.cbbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.IntegralHeight = false;
            this.cbbLop.Location = new System.Drawing.Point(280, 489);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(378, 26);
            this.cbbLop.Sorted = true;
            this.cbbLop.TabIndex = 21;
            // 
            // grbAddress
            // 
            this.grbAddress.Controls.Add(this.cbbTinh);
            this.grbAddress.Controls.Add(this.tbxDiachi);
            this.grbAddress.Controls.Add(this.cbbHuyen);
            this.grbAddress.Controls.Add(this.cbbXa);
            this.grbAddress.Location = new System.Drawing.Point(274, 165);
            this.grbAddress.Name = "grbAddress";
            this.grbAddress.Size = new System.Drawing.Size(390, 153);
            this.grbAddress.TabIndex = 20;
            this.grbAddress.TabStop = false;
            this.grbAddress.Text = "Địa chỉ";
            // 
            // cbbTinh
            // 
            this.cbbTinh.DropDownHeight = 256;
            this.cbbTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTinh.FormattingEnabled = true;
            this.cbbTinh.IntegralHeight = false;
            this.cbbTinh.Location = new System.Drawing.Point(6, 25);
            this.cbbTinh.Name = "cbbTinh";
            this.cbbTinh.Size = new System.Drawing.Size(378, 26);
            this.cbbTinh.Sorted = true;
            this.cbbTinh.TabIndex = 6;
            this.cbbTinh.SelectedIndexChanged += new System.EventHandler(this.cbbTinh_SelectedIndexChanged);
            // 
            // tbxDiachi
            // 
            this.tbxDiachi.Location = new System.Drawing.Point(6, 121);
            this.tbxDiachi.Name = "tbxDiachi";
            this.tbxDiachi.Size = new System.Drawing.Size(378, 26);
            this.tbxDiachi.TabIndex = 9;
            this.tbxDiachi.Enter += new System.EventHandler(this.tbxDiachi_Enter);
            // 
            // cbbHuyen
            // 
            this.cbbHuyen.DropDownHeight = 256;
            this.cbbHuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbHuyen.FormattingEnabled = true;
            this.cbbHuyen.IntegralHeight = false;
            this.cbbHuyen.Location = new System.Drawing.Point(6, 57);
            this.cbbHuyen.Name = "cbbHuyen";
            this.cbbHuyen.Size = new System.Drawing.Size(378, 26);
            this.cbbHuyen.Sorted = true;
            this.cbbHuyen.TabIndex = 7;
            this.cbbHuyen.SelectedIndexChanged += new System.EventHandler(this.cbbHuyen_SelectedIndexChanged);
            // 
            // cbbXa
            // 
            this.cbbXa.DropDownHeight = 256;
            this.cbbXa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbXa.FormattingEnabled = true;
            this.cbbXa.IntegralHeight = false;
            this.cbbXa.Location = new System.Drawing.Point(6, 89);
            this.cbbXa.Name = "cbbXa";
            this.cbbXa.Size = new System.Drawing.Size(378, 26);
            this.cbbXa.Sorted = true;
            this.cbbXa.TabIndex = 8;
            // 
            // grbGender
            // 
            this.grbGender.Controls.Add(this.rdbFem);
            this.grbGender.Controls.Add(this.rdbMal);
            this.grbGender.Location = new System.Drawing.Point(280, 67);
            this.grbGender.Name = "grbGender";
            this.grbGender.Size = new System.Drawing.Size(125, 57);
            this.grbGender.TabIndex = 19;
            this.grbGender.TabStop = false;
            this.grbGender.Text = "Giới tính";
            // 
            // rdbFem
            // 
            this.rdbFem.AutoSize = true;
            this.rdbFem.Location = new System.Drawing.Point(71, 25);
            this.rdbFem.Name = "rdbFem";
            this.rdbFem.Size = new System.Drawing.Size(48, 22);
            this.rdbFem.TabIndex = 1;
            this.rdbFem.TabStop = true;
            this.rdbFem.Text = "Nữ";
            this.rdbFem.UseVisualStyleBackColor = true;
            // 
            // rdbMal
            // 
            this.rdbMal.AutoSize = true;
            this.rdbMal.Checked = true;
            this.rdbMal.Location = new System.Drawing.Point(6, 25);
            this.rdbMal.Name = "rdbMal";
            this.rdbMal.Size = new System.Drawing.Size(59, 22);
            this.rdbMal.TabIndex = 0;
            this.rdbMal.TabStop = true;
            this.rdbMal.Text = "Nam";
            this.rdbMal.UseVisualStyleBackColor = true;
            // 
            // tbxTen
            // 
            this.tbxTen.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTen.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbxTen.Location = new System.Drawing.Point(280, 31);
            this.tbxTen.Name = "tbxTen";
            this.tbxTen.Size = new System.Drawing.Size(378, 29);
            this.tbxTen.TabIndex = 18;
            this.tbxTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxTen_KeyPress);
            // 
            // tbxMasv
            // 
            this.tbxMasv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxMasv.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMasv.Location = new System.Drawing.Point(32, 32);
            this.tbxMasv.Name = "tbxMasv";
            this.tbxMasv.ReadOnly = true;
            this.tbxMasv.Size = new System.Drawing.Size(206, 29);
            this.tbxMasv.TabIndex = 17;
            this.tbxMasv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSubmit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSubmit.Location = new System.Drawing.Point(32, 485);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(206, 32);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Sửa";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.BackColor = System.Drawing.Color.Tomato;
            this.btnDel.Location = new System.Drawing.Point(32, 564);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(111, 32);
            this.btnDel.TabIndex = 24;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnCan
            // 
            this.btnCan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCan.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnCan.Location = new System.Drawing.Point(547, 564);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(111, 32);
            this.btnCan.TabIndex = 25;
            this.btnCan.Text = "Hủy";
            this.btnCan.UseVisualStyleBackColor = false;
            this.btnCan.Click += new System.EventHandler(this.btnCan_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.PeachPuff;
            this.btnUpload.Location = new System.Drawing.Point(138, 353);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(100, 32);
            this.btnUpload.TabIndex = 27;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // ptbAvatar
            // 
            this.ptbAvatar.BackColor = System.Drawing.SystemColors.Control;
            this.ptbAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbAvatar.Location = new System.Drawing.Point(32, 67);
            this.ptbAvatar.Name = "ptbAvatar";
            this.ptbAvatar.Size = new System.Drawing.Size(206, 280);
            this.ptbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbAvatar.TabIndex = 26;
            this.ptbAvatar.TabStop = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.LightSalmon;
            this.btnRemove.Location = new System.Drawing.Point(32, 353);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 32);
            this.btnRemove.TabIndex = 28;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // fmEditSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 622);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.ptbAvatar);
            this.Controls.Add(this.btnCan);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbContact);
            this.Controls.Add(this.cbbLop);
            this.Controls.Add(this.grbAddress);
            this.Controls.Add(this.grbGender);
            this.Controls.Add(this.tbxTen);
            this.Controls.Add(this.tbxMasv);
            this.Controls.Add(this.btnSubmit);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmEditSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sửa thông tin sinh viên";
            this.Load += new System.EventHandler(this.fmEditSinh_Load);
            this.groupBox1.ResumeLayout(false);
            this.grbContact.ResumeLayout(false);
            this.grbContact.PerformLayout();
            this.grbAddress.ResumeLayout(false);
            this.grbAddress.PerformLayout();
            this.grbGender.ResumeLayout(false);
            this.grbGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.GroupBox grbContact;
        private System.Windows.Forms.TextBox tbxDienthoai;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.ComboBox cbbLop;
        private System.Windows.Forms.GroupBox grbAddress;
        private System.Windows.Forms.ComboBox cbbTinh;
        private System.Windows.Forms.TextBox tbxDiachi;
        private System.Windows.Forms.ComboBox cbbHuyen;
        private System.Windows.Forms.ComboBox cbbXa;
        private System.Windows.Forms.GroupBox grbGender;
        private System.Windows.Forms.RadioButton rdbFem;
        private System.Windows.Forms.RadioButton rdbMal;
        private System.Windows.Forms.TextBox tbxTen;
        private System.Windows.Forms.TextBox tbxMasv;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnCan;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.PictureBox ptbAvatar;
        private System.Windows.Forms.Button btnRemove;
    }
}