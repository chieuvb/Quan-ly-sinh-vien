namespace Presentation.Forms.Edit
{
    partial class fmEditLopHP
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
            this.tbxMa = new System.Windows.Forms.TextBox();
            this.cbbGiang = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbxMon = new System.Windows.Forms.TextBox();
            this.tbxKhoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudHoc = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudNamD = new System.Windows.Forms.NumericUpDown();
            this.nudNamT = new System.Windows.Forms.NumericUpDown();
            this.btnDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNamD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNamT)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxMa
            // 
            this.tbxMa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMa.Location = new System.Drawing.Point(151, 4);
            this.tbxMa.Name = "tbxMa";
            this.tbxMa.ReadOnly = true;
            this.tbxMa.Size = new System.Drawing.Size(194, 29);
            this.tbxMa.TabIndex = 28;
            // 
            // cbbGiang
            // 
            this.cbbGiang.DropDownHeight = 128;
            this.cbbGiang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGiang.FormattingEnabled = true;
            this.cbbGiang.IntegralHeight = false;
            this.cbbGiang.Location = new System.Drawing.Point(54, 120);
            this.cbbGiang.Name = "cbbGiang";
            this.cbbGiang.Size = new System.Drawing.Size(391, 26);
            this.cbbGiang.TabIndex = 27;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSubmit.Location = new System.Drawing.Point(356, 237);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(128, 32);
            this.btnSubmit.TabIndex = 24;
            this.btnSubmit.Text = "Cập nhật";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tbxMon
            // 
            this.tbxMon.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMon.Location = new System.Drawing.Point(54, 74);
            this.tbxMon.Name = "tbxMon";
            this.tbxMon.ReadOnly = true;
            this.tbxMon.Size = new System.Drawing.Size(391, 29);
            this.tbxMon.TabIndex = 36;
            // 
            // tbxKhoa
            // 
            this.tbxKhoa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxKhoa.Location = new System.Drawing.Point(54, 39);
            this.tbxKhoa.Name = "tbxKhoa";
            this.tbxKhoa.ReadOnly = true;
            this.tbxKhoa.Size = new System.Drawing.Size(391, 29);
            this.tbxKhoa.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 42;
            this.label3.Text = "Học kỳ: ";
            // 
            // nudHoc
            // 
            this.nudHoc.Location = new System.Drawing.Point(159, 184);
            this.nudHoc.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudHoc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHoc.Name = "nudHoc";
            this.nudHoc.Size = new System.Drawing.Size(120, 26);
            this.nudHoc.TabIndex = 41;
            this.nudHoc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 18);
            this.label2.TabIndex = 40;
            this.label2.Text = "đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 39;
            this.label1.Text = "Năm học: Từ ";
            // 
            // nudNamD
            // 
            this.nudNamD.Location = new System.Drawing.Point(325, 152);
            this.nudNamD.Name = "nudNamD";
            this.nudNamD.Size = new System.Drawing.Size(120, 26);
            this.nudNamD.TabIndex = 38;
            this.nudNamD.ValueChanged += new System.EventHandler(this.nudNamD_ValueChanged);
            // 
            // nudNamT
            // 
            this.nudNamT.Location = new System.Drawing.Point(159, 152);
            this.nudNamT.Name = "nudNamT";
            this.nudNamT.Size = new System.Drawing.Size(120, 26);
            this.nudNamT.TabIndex = 37;
            this.nudNamT.ValueChanged += new System.EventHandler(this.nudNamT_ValueChanged);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.BackColor = System.Drawing.Color.Salmon;
            this.btnDel.Location = new System.Drawing.Point(12, 237);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(128, 32);
            this.btnDel.TabIndex = 43;
            this.btnDel.Text = "Hủy lớp";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // fmEditLopHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 281);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudHoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudNamD);
            this.Controls.Add(this.nudNamT);
            this.Controls.Add(this.tbxKhoa);
            this.Controls.Add(this.tbxMon);
            this.Controls.Add(this.tbxMa);
            this.Controls.Add(this.cbbGiang);
            this.Controls.Add(this.btnSubmit);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmEditLopHP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sửa thông tin lớp học phần";
            this.Load += new System.EventHandler(this.fmEditLopHP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNamD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNamT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxMa;
        private System.Windows.Forms.ComboBox cbbGiang;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbxMon;
        private System.Windows.Forms.TextBox tbxKhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudNamD;
        private System.Windows.Forms.NumericUpDown nudNamT;
        private System.Windows.Forms.Button btnDel;
    }
}