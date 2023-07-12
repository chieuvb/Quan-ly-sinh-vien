namespace Presentation.Forms
{
    partial class fmSinhvien
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
            this.lsvSinhvien = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNex = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblcrPage = new System.Windows.Forms.Label();
            this.pnlPages = new System.Windows.Forms.Panel();
            this.cbbLopHC = new System.Windows.Forms.ComboBox();
            this.lblLHP = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbGend = new System.Windows.Forms.ComboBox();
            this.btnPrin = new System.Windows.Forms.Button();
            this.pnlSort = new System.Windows.Forms.Panel();
            this.cbbDiachi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.mnsView = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLarge = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlPages.SuspendLayout();
            this.pnlSort.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.mnsView.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvSinhvien
            // 
            this.lsvSinhvien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsvSinhvien.FullRowSelect = true;
            this.lsvSinhvien.HideSelection = false;
            this.lsvSinhvien.Location = new System.Drawing.Point(1, 206);
            this.lsvSinhvien.Name = "lsvSinhvien";
            this.lsvSinhvien.Size = new System.Drawing.Size(806, 414);
            this.lsvSinhvien.TabIndex = 1;
            this.lsvSinhvien.UseCompatibleStateImageBehavior = false;
            this.lsvSinhvien.View = System.Windows.Forms.View.Details;
            this.lsvSinhvien.ItemActivate += new System.EventHandler(this.lsvSinhvien_ItemActivate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "/";
            // 
            // btnNex
            // 
            this.btnNex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNex.Location = new System.Drawing.Point(133, 3);
            this.btnNex.Name = "btnNex";
            this.btnNex.Size = new System.Drawing.Size(32, 32);
            this.btnNex.TabIndex = 2;
            this.btnNex.Text = ">";
            this.btnNex.UseVisualStyleBackColor = true;
            this.btnNex.Click += new System.EventHandler(this.btnNex_Click);
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(3, 3);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(32, 32);
            this.btnPre.TabIndex = 1;
            this.btnPre.Text = "<";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(96, 10);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(17, 18);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "0";
            // 
            // lblcrPage
            // 
            this.lblcrPage.AutoSize = true;
            this.lblcrPage.Location = new System.Drawing.Point(55, 10);
            this.lblcrPage.Name = "lblcrPage";
            this.lblcrPage.Size = new System.Drawing.Size(17, 18);
            this.lblcrPage.TabIndex = 9;
            this.lblcrPage.Text = "0";
            // 
            // pnlPages
            // 
            this.pnlPages.Controls.Add(this.lblcrPage);
            this.pnlPages.Controls.Add(this.lblTotal);
            this.pnlPages.Controls.Add(this.btnPre);
            this.pnlPages.Controls.Add(this.btnNex);
            this.pnlPages.Controls.Add(this.label1);
            this.pnlPages.Location = new System.Drawing.Point(320, 162);
            this.pnlPages.Name = "pnlPages";
            this.pnlPages.Size = new System.Drawing.Size(168, 38);
            this.pnlPages.TabIndex = 8;
            // 
            // cbbLopHC
            // 
            this.cbbLopHC.DropDownHeight = 256;
            this.cbbLopHC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLopHC.FormattingEnabled = true;
            this.cbbLopHC.IntegralHeight = false;
            this.cbbLopHC.Location = new System.Drawing.Point(134, 5);
            this.cbbLopHC.Name = "cbbLopHC";
            this.cbbLopHC.Size = new System.Drawing.Size(512, 26);
            this.cbbLopHC.TabIndex = 9;
            this.cbbLopHC.SelectedIndexChanged += new System.EventHandler(this.cbbLopHC_SelectedIndexChanged);
            // 
            // lblLHP
            // 
            this.lblLHP.AutoSize = true;
            this.lblLHP.Location = new System.Drawing.Point(15, 8);
            this.lblLHP.Name = "lblLHP";
            this.lblLHP.Size = new System.Drawing.Size(113, 18);
            this.lblLHP.TabIndex = 10;
            this.lblLHP.Text = "Lớp hành chính";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdd.Location = new System.Drawing.Point(4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 32);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Thêm sinh viên";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Giới tính: ";
            // 
            // cbbGend
            // 
            this.cbbGend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGend.FormattingEnabled = true;
            this.cbbGend.Items.AddRange(new object[] {
            "-- Tất cả --",
            "Nam",
            "Nữ"});
            this.cbbGend.Location = new System.Drawing.Point(134, 69);
            this.cbbGend.Name = "cbbGend";
            this.cbbGend.Size = new System.Drawing.Size(128, 26);
            this.cbbGend.TabIndex = 12;
            this.cbbGend.SelectedIndexChanged += new System.EventHandler(this.cbbGend_SelectedIndexChanged);
            // 
            // btnPrin
            // 
            this.btnPrin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPrin.Location = new System.Drawing.Point(676, 4);
            this.btnPrin.Name = "btnPrin";
            this.btnPrin.Size = new System.Drawing.Size(128, 32);
            this.btnPrin.TabIndex = 14;
            this.btnPrin.Text = "In";
            this.btnPrin.UseVisualStyleBackColor = false;
            this.btnPrin.Click += new System.EventHandler(this.btnPrin_Click);
            // 
            // pnlSort
            // 
            this.pnlSort.Controls.Add(this.cbbDiachi);
            this.pnlSort.Controls.Add(this.label3);
            this.pnlSort.Controls.Add(this.lblLHP);
            this.pnlSort.Controls.Add(this.cbbLopHC);
            this.pnlSort.Controls.Add(this.label2);
            this.pnlSort.Controls.Add(this.cbbGend);
            this.pnlSort.Location = new System.Drawing.Point(4, 42);
            this.pnlSort.Name = "pnlSort";
            this.pnlSort.Size = new System.Drawing.Size(800, 114);
            this.pnlSort.TabIndex = 15;
            // 
            // cbbDiachi
            // 
            this.cbbDiachi.DropDownHeight = 256;
            this.cbbDiachi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDiachi.DropDownWidth = 256;
            this.cbbDiachi.FormattingEnabled = true;
            this.cbbDiachi.IntegralHeight = false;
            this.cbbDiachi.Location = new System.Drawing.Point(134, 37);
            this.cbbDiachi.Name = "cbbDiachi";
            this.cbbDiachi.Size = new System.Drawing.Size(256, 26);
            this.cbbDiachi.TabIndex = 16;
            this.cbbDiachi.SelectedIndexChanged += new System.EventHandler(this.cbbDiachi_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Địa chỉ: ";
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.LightYellow;
            this.btnSort.Location = new System.Drawing.Point(138, 4);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(80, 32);
            this.btnSort.TabIndex = 16;
            this.btnSort.Text = "Lọc";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.LightYellow;
            this.btnSearch.Location = new System.Drawing.Point(542, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(128, 32);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearch.Controls.Add(this.label4);
            this.pnlSearch.Controls.Add(this.tbxSearch);
            this.pnlSearch.Location = new System.Drawing.Point(4, 42);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(800, 114);
            this.pnlSearch.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên hoặc mã  sinh viên: ";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(407, 5);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(259, 26);
            this.tbxSearch.TabIndex = 0;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // mnsView
            // 
            this.mnsView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mnsView.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mnsView.Dock = System.Windows.Forms.DockStyle.None;
            this.mnsView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.mnsView.Location = new System.Drawing.Point(738, 179);
            this.mnsView.Name = "mnsView";
            this.mnsView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mnsView.Size = new System.Drawing.Size(52, 24);
            this.mnsView.TabIndex = 18;
            this.mnsView.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDetails,
            this.tsmiLarge});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // tsmiDetails
            // 
            this.tsmiDetails.Name = "tsmiDetails";
            this.tsmiDetails.Size = new System.Drawing.Size(129, 22);
            this.tsmiDetails.Text = "Details";
            this.tsmiDetails.Click += new System.EventHandler(this.tsmiDetails_Click);
            // 
            // tsmiLarge
            // 
            this.tsmiLarge.Name = "tsmiLarge";
            this.tsmiLarge.Size = new System.Drawing.Size(129, 22);
            this.tsmiLarge.Text = "Large Icon";
            this.tsmiLarge.Click += new System.EventHandler(this.tsmiLarge_Click);
            // 
            // fmSinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 621);
            this.Controls.Add(this.mnsView);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnPrin);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pnlPages);
            this.Controls.Add(this.lsvSinhvien);
            this.Controls.Add(this.pnlSort);
            this.Controls.Add(this.pnlSearch);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmSinhvien";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "Sinh viên";
            this.Load += new System.EventHandler(this.fmSinhVien_Load);
            this.SizeChanged += new System.EventHandler(this.fmSinhVien_SizeChanged);
            this.pnlPages.ResumeLayout(false);
            this.pnlPages.PerformLayout();
            this.pnlSort.ResumeLayout(false);
            this.pnlSort.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.mnsView.ResumeLayout(false);
            this.mnsView.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvSinhvien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNex;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblcrPage;
        private System.Windows.Forms.Panel pnlPages;
        private System.Windows.Forms.ComboBox cbbLopHC;
        private System.Windows.Forms.Label lblLHP;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbGend;
        private System.Windows.Forms.Button btnPrin;
        private System.Windows.Forms.Panel pnlSort;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbDiachi;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.MenuStrip mnsView;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmiLarge;
    }
}