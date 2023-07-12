namespace Presentation.Forms.Add
{
    partial class fmAddLopHC
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
            this.cbbGiang = new System.Windows.Forms.ComboBox();
            this.tbxTen = new System.Windows.Forms.TextBox();
            this.tbxMa = new System.Windows.Forms.TextBox();
            this.nudNam = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxKhoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNam)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSubmit.Location = new System.Drawing.Point(366, 180);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(125, 33);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Thêm";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
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
            this.cbbGiang.TabIndex = 8;
            this.cbbGiang.SelectedIndexChanged += new System.EventHandler(this.cbbGiang_SelectedIndexChanged);
            // 
            // tbxTen
            // 
            this.tbxTen.Location = new System.Drawing.Point(191, 32);
            this.tbxTen.MaxLength = 128;
            this.tbxTen.Name = "tbxTen";
            this.tbxTen.Size = new System.Drawing.Size(300, 26);
            this.tbxTen.TabIndex = 7;
            this.tbxTen.Enter += new System.EventHandler(this.tbxTen_Enter);
            this.tbxTen.Leave += new System.EventHandler(this.tbxTen_Leave);
            // 
            // tbxMa
            // 
            this.tbxMa.Location = new System.Drawing.Point(5, 32);
            this.tbxMa.MaxLength = 16;
            this.tbxMa.Name = "tbxMa";
            this.tbxMa.Size = new System.Drawing.Size(180, 26);
            this.tbxMa.TabIndex = 6;
            this.tbxMa.Enter += new System.EventHandler(this.tbxMa_Enter);
            this.tbxMa.Leave += new System.EventHandler(this.tbxMa_Leave);
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
            this.nudNam.TabIndex = 11;
            this.nudNam.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Khoa: ";
            // 
            // tbxKhoa
            // 
            this.tbxKhoa.Location = new System.Drawing.Point(191, 96);
            this.tbxKhoa.MaxLength = 16;
            this.tbxKhoa.Name = "tbxKhoa";
            this.tbxKhoa.Size = new System.Drawing.Size(300, 26);
            this.tbxKhoa.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Năm nhập học: ";
            // 
            // fmAddLopHC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 217);
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
            this.Name = "fmAddLopHC";
            this.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm lớp hành chính";
            this.Load += new System.EventHandler(this.fmAddLopHC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cbbGiang;
        private System.Windows.Forms.TextBox tbxTen;
        private System.Windows.Forms.TextBox tbxMa;
        private System.Windows.Forms.NumericUpDown nudNam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxKhoa;
        private System.Windows.Forms.Label label2;
    }
}