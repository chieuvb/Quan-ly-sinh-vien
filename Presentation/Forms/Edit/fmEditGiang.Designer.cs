namespace Presentation.Forms.Edit
{
    partial class fmEditGiang
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
            this.cbbHocvi = new System.Windows.Forms.ComboBox();
            this.tbxTen = new System.Windows.Forms.TextBox();
            this.tbxMagv = new System.Windows.Forms.TextBox();
            this.rdbFem = new System.Windows.Forms.RadioButton();
            this.rdbMal = new System.Windows.Forms.RadioButton();
            this.grbGender = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cbbTinh = new System.Windows.Forms.ComboBox();
            this.tbxDiachi = new System.Windows.Forms.TextBox();
            this.cbbHuyen = new System.Windows.Forms.ComboBox();
            this.cbbXa = new System.Windows.Forms.ComboBox();
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.tbxDienthoai = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.grbContact = new System.Windows.Forms.GroupBox();
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grbAddress = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnCan = new System.Windows.Forms.Button();
            this.grbGender.SuspendLayout();
            this.grbContact.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbHocvi
            // 
            this.cbbHocvi.DropDownHeight = 256;
            this.cbbHocvi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbHocvi.FormattingEnabled = true;
            this.cbbHocvi.IntegralHeight = false;
            this.cbbHocvi.Items.AddRange(new object[] {
            "-- Học vị --",
            "Cử nhân",
            "Thạc sĩ",
            "Tiến sĩ"});
            this.cbbHocvi.Location = new System.Drawing.Point(37, 502);
            this.cbbHocvi.Name = "cbbHocvi";
            this.cbbHocvi.Size = new System.Drawing.Size(378, 26);
            this.cbbHocvi.Sorted = true;
            this.cbbHocvi.TabIndex = 33;
            // 
            // tbxTen
            // 
            this.tbxTen.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTen.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbxTen.Location = new System.Drawing.Point(43, 60);
            this.tbxTen.Name = "tbxTen";
            this.tbxTen.Size = new System.Drawing.Size(378, 29);
            this.tbxTen.TabIndex = 27;
            this.tbxTen.Enter += new System.EventHandler(this.tbxTen_Enter);
            this.tbxTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxTen_KeyPress);
            this.tbxTen.Leave += new System.EventHandler(this.tbxTen_Leave);
            // 
            // tbxMagv
            // 
            this.tbxMagv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxMagv.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMagv.Location = new System.Drawing.Point(120, 11);
            this.tbxMagv.Name = "tbxMagv";
            this.tbxMagv.ReadOnly = true;
            this.tbxMagv.Size = new System.Drawing.Size(225, 29);
            this.tbxMagv.TabIndex = 26;
            this.tbxMagv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // grbGender
            // 
            this.grbGender.Controls.Add(this.rdbFem);
            this.grbGender.Controls.Add(this.rdbMal);
            this.grbGender.Location = new System.Drawing.Point(43, 95);
            this.grbGender.Name = "grbGender";
            this.grbGender.Size = new System.Drawing.Size(125, 54);
            this.grbGender.TabIndex = 28;
            this.grbGender.TabStop = false;
            this.grbGender.Text = "Giới tính";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSubmit.Location = new System.Drawing.Point(137, 597);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(190, 32);
            this.btnSubmit.TabIndex = 25;
            this.btnSubmit.Text = "Sửa";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
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
            this.tbxDiachi.Leave += new System.EventHandler(this.tbxDiachi_Leave);
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
            // cbbKhoa
            // 
            this.cbbKhoa.DropDownHeight = 256;
            this.cbbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.IntegralHeight = false;
            this.cbbKhoa.Location = new System.Drawing.Point(37, 534);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(378, 26);
            this.cbbKhoa.Sorted = true;
            this.cbbKhoa.TabIndex = 30;
            // 
            // tbxDienthoai
            // 
            this.tbxDienthoai.Location = new System.Drawing.Point(6, 25);
            this.tbxDienthoai.MaxLength = 10;
            this.tbxDienthoai.Name = "tbxDienthoai";
            this.tbxDienthoai.Size = new System.Drawing.Size(378, 26);
            this.tbxDienthoai.TabIndex = 11;
            this.tbxDienthoai.Enter += new System.EventHandler(this.tbxDienthoai_Enter);
            this.tbxDienthoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxDienthoai_KeyPress);
            this.tbxDienthoai.Leave += new System.EventHandler(this.tbxDienthoai_Leave);
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(6, 57);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(378, 26);
            this.tbxEmail.TabIndex = 12;
            this.tbxEmail.Enter += new System.EventHandler(this.tbxEmail_Enter);
            this.tbxEmail.Leave += new System.EventHandler(this.tbxEmail_Leave);
            // 
            // grbContact
            // 
            this.grbContact.Controls.Add(this.tbxDienthoai);
            this.grbContact.Controls.Add(this.tbxEmail);
            this.grbContact.Location = new System.Drawing.Point(37, 375);
            this.grbContact.Name = "grbContact";
            this.grbContact.Size = new System.Drawing.Size(390, 89);
            this.grbContact.TabIndex = 31;
            this.grbContact.TabStop = false;
            this.grbContact.Text = "Thông tin liên hệ";
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.CustomFormat = "dd-MM-yyyy";
            this.dtpNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaysinh.Location = new System.Drawing.Point(6, 25);
            this.dtpNgaysinh.MaxDate = new System.DateTime(2009, 12, 31, 0, 0, 0, 0);
            this.dtpNgaysinh.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(206, 26);
            this.dtpNgaysinh.TabIndex = 5;
            this.dtpNgaysinh.Value = new System.DateTime(2009, 12, 31, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpNgaysinh);
            this.groupBox1.Location = new System.Drawing.Point(203, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 57);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ngày sinh";
            // 
            // grbAddress
            // 
            this.grbAddress.Controls.Add(this.cbbTinh);
            this.grbAddress.Controls.Add(this.tbxDiachi);
            this.grbAddress.Controls.Add(this.cbbHuyen);
            this.grbAddress.Controls.Add(this.cbbXa);
            this.grbAddress.Location = new System.Drawing.Point(37, 190);
            this.grbAddress.Name = "grbAddress";
            this.grbAddress.Size = new System.Drawing.Size(390, 153);
            this.grbAddress.TabIndex = 29;
            this.grbAddress.TabStop = false;
            this.grbAddress.Text = "Địa chỉ";
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.BackColor = System.Drawing.Color.Salmon;
            this.btnDel.Location = new System.Drawing.Point(12, 597);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(119, 32);
            this.btnDel.TabIndex = 34;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnCan
            // 
            this.btnCan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCan.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnCan.Location = new System.Drawing.Point(333, 597);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(119, 32);
            this.btnCan.TabIndex = 35;
            this.btnCan.Text = "Hủy";
            this.btnCan.UseVisualStyleBackColor = false;
            this.btnCan.Click += new System.EventHandler(this.btnCan_Click);
            // 
            // fmEditGiang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 641);
            this.Controls.Add(this.btnCan);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.cbbHocvi);
            this.Controls.Add(this.tbxTen);
            this.Controls.Add(this.tbxMagv);
            this.Controls.Add(this.grbGender);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cbbKhoa);
            this.Controls.Add(this.grbContact);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbAddress);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmEditGiang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sửa thông tin giảng viên";
            this.Load += new System.EventHandler(this.fmEditGiang_Load);
            this.grbGender.ResumeLayout(false);
            this.grbGender.PerformLayout();
            this.grbContact.ResumeLayout(false);
            this.grbContact.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.grbAddress.ResumeLayout(false);
            this.grbAddress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbHocvi;
        private System.Windows.Forms.TextBox tbxTen;
        private System.Windows.Forms.TextBox tbxMagv;
        private System.Windows.Forms.RadioButton rdbFem;
        private System.Windows.Forms.RadioButton rdbMal;
        private System.Windows.Forms.GroupBox grbGender;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cbbTinh;
        private System.Windows.Forms.TextBox tbxDiachi;
        private System.Windows.Forms.ComboBox cbbHuyen;
        private System.Windows.Forms.ComboBox cbbXa;
        private System.Windows.Forms.ComboBox cbbKhoa;
        private System.Windows.Forms.TextBox tbxDienthoai;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.GroupBox grbContact;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grbAddress;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnCan;
    }
}