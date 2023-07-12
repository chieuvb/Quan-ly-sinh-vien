namespace Presentation.Forms.Add
{
    partial class fmAddLopHP
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.cbbMon = new System.Windows.Forms.ComboBox();
            this.cbbGiang = new System.Windows.Forms.ComboBox();
            this.tbxMa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudHoc = new System.Windows.Forms.NumericUpDown();
            this.nudNamT = new System.Windows.Forms.NumericUpDown();
            this.nudNamD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNamT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNamD)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSubmit.Location = new System.Drawing.Point(364, 245);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(128, 32);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Mở lớp";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.DropDownHeight = 128;
            this.cbbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.IntegralHeight = false;
            this.cbbKhoa.Location = new System.Drawing.Point(4, 53);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(488, 26);
            this.cbbKhoa.TabIndex = 7;
            this.cbbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbbKhoa_SelectedIndexChanged);
            // 
            // cbbMon
            // 
            this.cbbMon.DropDownHeight = 128;
            this.cbbMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMon.FormattingEnabled = true;
            this.cbbMon.IntegralHeight = false;
            this.cbbMon.Location = new System.Drawing.Point(4, 117);
            this.cbbMon.Name = "cbbMon";
            this.cbbMon.Size = new System.Drawing.Size(488, 26);
            this.cbbMon.TabIndex = 8;
            // 
            // cbbGiang
            // 
            this.cbbGiang.DropDownHeight = 128;
            this.cbbGiang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGiang.FormattingEnabled = true;
            this.cbbGiang.IntegralHeight = false;
            this.cbbGiang.Location = new System.Drawing.Point(4, 85);
            this.cbbGiang.Name = "cbbGiang";
            this.cbbGiang.Size = new System.Drawing.Size(488, 26);
            this.cbbGiang.TabIndex = 9;
            // 
            // tbxMa
            // 
            this.tbxMa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMa.Location = new System.Drawing.Point(151, 4);
            this.tbxMa.Name = "tbxMa";
            this.tbxMa.ReadOnly = true;
            this.tbxMa.Size = new System.Drawing.Size(194, 29);
            this.tbxMa.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Năm học: Từ ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Học kỳ: ";
            // 
            // nudHoc
            // 
            this.nudHoc.Location = new System.Drawing.Point(159, 181);
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
            this.nudHoc.TabIndex = 22;
            this.nudHoc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudNamT
            // 
            this.nudNamT.Location = new System.Drawing.Point(159, 149);
            this.nudNamT.Name = "nudNamT";
            this.nudNamT.Size = new System.Drawing.Size(120, 26);
            this.nudNamT.TabIndex = 18;
            // 
            // nudNamD
            // 
            this.nudNamD.Location = new System.Drawing.Point(325, 149);
            this.nudNamD.Name = "nudNamD";
            this.nudNamD.Size = new System.Drawing.Size(120, 26);
            this.nudNamD.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "đến";
            // 
            // fmAddLopHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 281);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudHoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudNamD);
            this.Controls.Add(this.nudNamT);
            this.Controls.Add(this.tbxMa);
            this.Controls.Add(this.cbbGiang);
            this.Controls.Add(this.cbbMon);
            this.Controls.Add(this.cbbKhoa);
            this.Controls.Add(this.btnSubmit);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmAddLopHP";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mở lớp học phần";
            this.Load += new System.EventHandler(this.fmAddLopHP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNamT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNamD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cbbKhoa;
        private System.Windows.Forms.ComboBox cbbMon;
        private System.Windows.Forms.ComboBox cbbGiang;
        private System.Windows.Forms.TextBox tbxMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudHoc;
        private System.Windows.Forms.NumericUpDown nudNamT;
        private System.Windows.Forms.NumericUpDown nudNamD;
        private System.Windows.Forms.Label label2;
    }
}