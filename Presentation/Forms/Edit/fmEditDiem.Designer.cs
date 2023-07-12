namespace Presentation.Forms.Edit
{
    partial class fmEditDiem
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxDiemTB = new System.Windows.Forms.TextBox();
            this.tbxDiemKT = new System.Windows.Forms.TextBox();
            this.tbxDiemGK = new System.Windows.Forms.TextBox();
            this.tbxDiemCC = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbxLophocphan = new System.Windows.Forms.TextBox();
            this.tbxSinhvien = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Trung bình";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Kết thúc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Giữa kỳ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Chuyên cần";
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
            this.tbxDiemTB.TabIndex = 16;
            // 
            // tbxDiemKT
            // 
            this.tbxDiemKT.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDiemKT.Location = new System.Drawing.Point(234, 160);
            this.tbxDiemKT.MaxLength = 4;
            this.tbxDiemKT.Name = "tbxDiemKT";
            this.tbxDiemKT.Size = new System.Drawing.Size(105, 32);
            this.tbxDiemKT.TabIndex = 15;
            this.tbxDiemKT.TextChanged += new System.EventHandler(this.tbxDiemThi_TextChanged);
            this.tbxDiemKT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxDiemThi_KeyPress);
            // 
            // tbxDiemGK
            // 
            this.tbxDiemGK.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDiemGK.Location = new System.Drawing.Point(123, 160);
            this.tbxDiemGK.MaxLength = 4;
            this.tbxDiemGK.Name = "tbxDiemGK";
            this.tbxDiemGK.Size = new System.Drawing.Size(105, 32);
            this.tbxDiemGK.TabIndex = 14;
            this.tbxDiemGK.TextChanged += new System.EventHandler(this.tbxDiemGK_TextChanged);
            this.tbxDiemGK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxDiemGK_KeyPress);
            // 
            // tbxDiemCC
            // 
            this.tbxDiemCC.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDiemCC.Location = new System.Drawing.Point(12, 160);
            this.tbxDiemCC.MaxLength = 4;
            this.tbxDiemCC.Name = "tbxDiemCC";
            this.tbxDiemCC.Size = new System.Drawing.Size(105, 32);
            this.tbxDiemCC.TabIndex = 13;
            this.tbxDiemCC.TextChanged += new System.EventHandler(this.tbxDiemCC_TextChanged);
            this.tbxDiemCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxDiemCC_KeyPress);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSubmit.Location = new System.Drawing.Point(587, 147);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(105, 58);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Sửa";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tbxLophocphan
            // 
            this.tbxLophocphan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxLophocphan.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLophocphan.Location = new System.Drawing.Point(12, 12);
            this.tbxLophocphan.Name = "tbxLophocphan";
            this.tbxLophocphan.ReadOnly = true;
            this.tbxLophocphan.Size = new System.Drawing.Size(680, 32);
            this.tbxLophocphan.TabIndex = 21;
            // 
            // tbxSinhvien
            // 
            this.tbxSinhvien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxSinhvien.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSinhvien.Location = new System.Drawing.Point(12, 50);
            this.tbxSinhvien.Name = "tbxSinhvien";
            this.tbxSinhvien.ReadOnly = true;
            this.tbxSinhvien.Size = new System.Drawing.Size(680, 32);
            this.tbxSinhvien.TabIndex = 22;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.LightSalmon;
            this.btnDel.Location = new System.Drawing.Point(587, 88);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(105, 32);
            this.btnDel.TabIndex = 23;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // fmEditDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 217);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.tbxSinhvien);
            this.Controls.Add(this.tbxLophocphan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxDiemTB);
            this.Controls.Add(this.tbxDiemKT);
            this.Controls.Add(this.tbxDiemGK);
            this.Controls.Add(this.tbxDiemCC);
            this.Controls.Add(this.btnSubmit);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmEditDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sửa điểm";
            this.Load += new System.EventHandler(this.fmEditDiem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxDiemTB;
        private System.Windows.Forms.TextBox tbxDiemKT;
        private System.Windows.Forms.TextBox tbxDiemGK;
        private System.Windows.Forms.TextBox tbxDiemCC;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbxLophocphan;
        private System.Windows.Forms.TextBox tbxSinhvien;
        private System.Windows.Forms.Button btnDel;
    }
}