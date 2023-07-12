namespace Presentation.Forms.Edit
{
    partial class fmEditMon
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
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.cbbTin = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbxMa = new System.Windows.Forms.TextBox();
            this.tbxTen = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKhoa.DropDownWidth = 128;
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Items.AddRange(new object[] {
            "-- Khoa --"});
            this.cbbKhoa.Location = new System.Drawing.Point(66, 85);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(364, 26);
            this.cbbKhoa.TabIndex = 16;
            // 
            // cbbTin
            // 
            this.cbbTin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTin.DropDownWidth = 128;
            this.cbbTin.FormattingEnabled = true;
            this.cbbTin.Items.AddRange(new object[] {
            "-- Số tín chỉ --",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbbTin.Location = new System.Drawing.Point(148, 117);
            this.cbbTin.Name = "cbbTin";
            this.cbbTin.Size = new System.Drawing.Size(200, 26);
            this.cbbTin.TabIndex = 15;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSubmit.Location = new System.Drawing.Point(251, 173);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(128, 32);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Sửa";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tbxMa
            // 
            this.tbxMa.Location = new System.Drawing.Point(66, 21);
            this.tbxMa.MaxLength = 8;
            this.tbxMa.Name = "tbxMa";
            this.tbxMa.Size = new System.Drawing.Size(364, 26);
            this.tbxMa.TabIndex = 17;
            this.tbxMa.Enter += new System.EventHandler(this.tbxMa_Enter);
            this.tbxMa.Leave += new System.EventHandler(this.tbxMa_Leave);
            // 
            // tbxTen
            // 
            this.tbxTen.Location = new System.Drawing.Point(66, 53);
            this.tbxTen.MaxLength = 128;
            this.tbxTen.Name = "tbxTen";
            this.tbxTen.Size = new System.Drawing.Size(364, 26);
            this.tbxTen.TabIndex = 18;
            this.tbxTen.Enter += new System.EventHandler(this.tbxTen_Enter);
            this.tbxTen.Leave += new System.EventHandler(this.tbxTen_Leave);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.BackColor = System.Drawing.Color.Salmon;
            this.btnDel.Location = new System.Drawing.Point(117, 173);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(128, 32);
            this.btnDel.TabIndex = 19;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // fmEditMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 217);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.tbxTen);
            this.Controls.Add(this.tbxMa);
            this.Controls.Add(this.cbbKhoa);
            this.Controls.Add(this.cbbTin);
            this.Controls.Add(this.btnSubmit);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmEditMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sửa thông tin môn học";
            this.Load += new System.EventHandler(this.fmEditMon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbKhoa;
        private System.Windows.Forms.ComboBox cbbTin;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbxMa;
        private System.Windows.Forms.TextBox tbxTen;
        private System.Windows.Forms.Button btnDel;
    }
}