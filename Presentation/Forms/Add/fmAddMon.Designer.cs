namespace Presentation.Forms.Add
{
    partial class fmAddMon
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
            this.cbbTin = new System.Windows.Forms.ComboBox();
            this.tbxMa = new System.Windows.Forms.TextBox();
            this.tbxTen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSubmit.Location = new System.Drawing.Point(184, 173);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(128, 32);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Thêm môn";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKhoa.DropDownWidth = 128;
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Items.AddRange(new object[] {
            "-- Khoa --"});
            this.cbbKhoa.Location = new System.Drawing.Point(66, 94);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(364, 26);
            this.cbbKhoa.TabIndex = 11;
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
            this.cbbTin.Location = new System.Drawing.Point(148, 126);
            this.cbbTin.Name = "cbbTin";
            this.cbbTin.Size = new System.Drawing.Size(200, 26);
            this.cbbTin.TabIndex = 10;
            // 
            // tbxMa
            // 
            this.tbxMa.Location = new System.Drawing.Point(66, 30);
            this.tbxMa.MaxLength = 8;
            this.tbxMa.Name = "tbxMa";
            this.tbxMa.Size = new System.Drawing.Size(364, 26);
            this.tbxMa.TabIndex = 12;
            this.tbxMa.Enter += new System.EventHandler(this.tbxMa_Enter);
            this.tbxMa.Leave += new System.EventHandler(this.tbxMa_Leave);
            // 
            // tbxTen
            // 
            this.tbxTen.Location = new System.Drawing.Point(66, 62);
            this.tbxTen.MaxLength = 128;
            this.tbxTen.Name = "tbxTen";
            this.tbxTen.Size = new System.Drawing.Size(364, 26);
            this.tbxTen.TabIndex = 14;
            this.tbxTen.Enter += new System.EventHandler(this.tbxTen_Enter);
            this.tbxTen.Leave += new System.EventHandler(this.tbxTen_Leave);
            // 
            // fmAddMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 217);
            this.Controls.Add(this.tbxTen);
            this.Controls.Add(this.tbxMa);
            this.Controls.Add(this.cbbKhoa);
            this.Controls.Add(this.cbbTin);
            this.Controls.Add(this.btnSubmit);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmAddMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm môn học";
            this.Load += new System.EventHandler(this.fmAddMon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cbbKhoa;
        private System.Windows.Forms.ComboBox cbbTin;
        private System.Windows.Forms.TextBox tbxMa;
        private System.Windows.Forms.TextBox tbxTen;
    }
}