namespace Presentation.Forms.Add
{
    partial class fmAddDiem
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
            this.cbbLopHP = new System.Windows.Forms.ComboBox();
            this.cbbSinhVien = new System.Windows.Forms.ComboBox();
            this.tbxDiemCC = new System.Windows.Forms.TextBox();
            this.tbxDiemGK = new System.Windows.Forms.TextBox();
            this.tbxDiemKT = new System.Windows.Forms.TextBox();
            this.tbxDiemTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSubmit.Location = new System.Drawing.Point(587, 147);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(105, 58);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Nhập điểm";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cbbLopHP
            // 
            this.cbbLopHP.DropDownHeight = 128;
            this.cbbLopHP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLopHP.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLopHP.FormattingEnabled = true;
            this.cbbLopHP.IntegralHeight = false;
            this.cbbLopHP.Items.AddRange(new object[] {
            "-- Lớp học phần --"});
            this.cbbLopHP.Location = new System.Drawing.Point(12, 12);
            this.cbbLopHP.Name = "cbbLopHP";
            this.cbbLopHP.Size = new System.Drawing.Size(680, 30);
            this.cbbLopHP.TabIndex = 1;
            this.cbbLopHP.SelectedIndexChanged += new System.EventHandler(this.cbbLopHP_SelectedIndexChanged);
            // 
            // cbbSinhVien
            // 
            this.cbbSinhVien.DropDownHeight = 128;
            this.cbbSinhVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSinhVien.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSinhVien.FormattingEnabled = true;
            this.cbbSinhVien.IntegralHeight = false;
            this.cbbSinhVien.Items.AddRange(new object[] {
            "-- Sinh viên chưa có điểm --"});
            this.cbbSinhVien.Location = new System.Drawing.Point(12, 48);
            this.cbbSinhVien.Name = "cbbSinhVien";
            this.cbbSinhVien.Size = new System.Drawing.Size(680, 30);
            this.cbbSinhVien.TabIndex = 2;
            // 
            // tbxDiemCC
            // 
            this.tbxDiemCC.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDiemCC.Location = new System.Drawing.Point(12, 160);
            this.tbxDiemCC.MaxLength = 4;
            this.tbxDiemCC.Name = "tbxDiemCC";
            this.tbxDiemCC.Size = new System.Drawing.Size(105, 32);
            this.tbxDiemCC.TabIndex = 4;
            this.tbxDiemCC.TextChanged += new System.EventHandler(this.tbxDiemCC_TextChanged);
            this.tbxDiemCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxDiemCC_KeyPress);
            // 
            // tbxDiemGK
            // 
            this.tbxDiemGK.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDiemGK.Location = new System.Drawing.Point(123, 160);
            this.tbxDiemGK.MaxLength = 4;
            this.tbxDiemGK.Name = "tbxDiemGK";
            this.tbxDiemGK.Size = new System.Drawing.Size(105, 32);
            this.tbxDiemGK.TabIndex = 5;
            this.tbxDiemGK.TextChanged += new System.EventHandler(this.tbxDiemGK_TextChanged);
            this.tbxDiemGK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxDiemGK_KeyPress);
            // 
            // tbxDiemKT
            // 
            this.tbxDiemKT.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDiemKT.Location = new System.Drawing.Point(234, 160);
            this.tbxDiemKT.MaxLength = 4;
            this.tbxDiemKT.Name = "tbxDiemKT";
            this.tbxDiemKT.Size = new System.Drawing.Size(105, 32);
            this.tbxDiemKT.TabIndex = 6;
            this.tbxDiemKT.TextChanged += new System.EventHandler(this.tbxDiemThi_TextChanged);
            this.tbxDiemKT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxDiemThi_KeyPress);
            // 
            // tbxDiemTB
            // 
            this.tbxDiemTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxDiemTB.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDiemTB.Location = new System.Drawing.Point(365, 161);
            this.tbxDiemTB.MaxLength = 4;
            this.tbxDiemTB.Name = "tbxDiemTB";
            this.tbxDiemTB.ReadOnly = true;
            this.tbxDiemTB.Size = new System.Drawing.Size(105, 32);
            this.tbxDiemTB.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Chuyên cần";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Giữa kỳ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kết thúc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Trung bình";
            // 
            // fmAddDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 217);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxDiemTB);
            this.Controls.Add(this.tbxDiemKT);
            this.Controls.Add(this.tbxDiemGK);
            this.Controls.Add(this.tbxDiemCC);
            this.Controls.Add(this.cbbSinhVien);
            this.Controls.Add(this.cbbLopHP);
            this.Controls.Add(this.btnSubmit);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmAddDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhập điểm";
            this.Load += new System.EventHandler(this.fmAddDiem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cbbLopHP;
        private System.Windows.Forms.ComboBox cbbSinhVien;
        private System.Windows.Forms.TextBox tbxDiemGK;
        private System.Windows.Forms.TextBox tbxDiemKT;
        private System.Windows.Forms.TextBox tbxDiemTB;
        private System.Windows.Forms.TextBox tbxDiemCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}