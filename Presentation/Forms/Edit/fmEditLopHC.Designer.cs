namespace Presentation.Forms.Edit
{
    partial class fmEditLopHC
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbxKhoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudNam = new System.Windows.Forms.NumericUpDown();
            this.cbbGiang = new System.Windows.Forms.ComboBox();
            this.tbxTen = new System.Windows.Forms.TextBox();
            this.tbxMa = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNam)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Năm nhập học: ";
            // 
            // tbxKhoa
            // 
            this.tbxKhoa.Location = new System.Drawing.Point(191, 96);
            this.tbxKhoa.MaxLength = 16;
            this.tbxKhoa.Name = "tbxKhoa";
            this.tbxKhoa.Size = new System.Drawing.Size(300, 26);
            this.tbxKhoa.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Khoa: ";
            // 
            // nudNam
            // 
            this.nudNam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudNam.Location = new System.Drawing.Point(191, 128);
            this.nudNam.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nudNam.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudNam.Name = "nudNam";
            this.nudNam.Size = new System.Drawing.Size(180, 26);
            this.nudNam.TabIndex = 19;
            this.nudNam.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // cbbGiang
            // 
            this.cbbGiang.DropDownHeight = 128;
            this.cbbGiang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGiang.FormattingEnabled = true;
            this.cbbGiang.IntegralHeight = false;
            this.cbbGiang.Location = new System.Drawing.Point(5, 64);
            this.cbbGiang.Name = "cbbGiang";
            this.cbbGiang.Size = new System.Drawing.Size(486, 26);
            this.cbbGiang.TabIndex = 18;
            this.cbbGiang.SelectedIndexChanged += new System.EventHandler(this.cbbGiang_SelectedIndexChanged);
            // 
            // tbxTen
            // 
            this.tbxTen.Location = new System.Drawing.Point(191, 32);
            this.tbxTen.MaxLength = 128;
            this.tbxTen.Name = "tbxTen";
            this.tbxTen.Size = new System.Drawing.Size(300, 26);
            this.tbxTen.TabIndex = 17;
            this.tbxTen.Enter += new System.EventHandler(this.tbxTen_Enter);
            this.tbxTen.Leave += new System.EventHandler(this.tbxTen_Leave);
            // 
            // tbxMa
            // 
            this.tbxMa.Location = new System.Drawing.Point(5, 32);
            this.tbxMa.MaxLength = 16;
            this.tbxMa.Name = "tbxMa";
            this.tbxMa.Size = new System.Drawing.Size(180, 26);
            this.tbxMa.TabIndex = 16;
            this.tbxMa.Enter += new System.EventHandler(this.tbxMa_Enter);
            this.tbxMa.Leave += new System.EventHandler(this.tbxMa_Leave);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSubmit.Location = new System.Drawing.Point(366, 180);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(125, 33);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Sửa";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Mã lớp: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Tên lớp: ";
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Salmon;
            this.btnDel.Location = new System.Drawing.Point(5, 180);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(125, 33);
            this.btnDel.TabIndex = 25;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // fmEditLopHC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 217);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxKhoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudNam);
            this.Controls.Add(this.cbbGiang);
            this.Controls.Add(this.tbxTen);
            this.Controls.Add(this.tbxMa);
            this.Controls.Add(this.btnSubmit);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmEditLopHC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sửa thông tin lớp hành chính";
            this.Load += new System.EventHandler(this.fmEditLopHC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudNam;
        private System.Windows.Forms.ComboBox cbbGiang;
        private System.Windows.Forms.TextBox tbxTen;
        private System.Windows.Forms.TextBox tbxMa;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDel;
    }
}