namespace Presentation
{
    partial class fmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.pnlBase = new System.Windows.Forms.Panel();
            this.pnlContain = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.mnsUser = new System.Windows.Forms.MenuStrip();
            this.tsmUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChangePass = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlLeftSide = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnMonHoc = new System.Windows.Forms.Button();
            this.btnKhoa = new System.Windows.Forms.Button();
            this.btnLopHC = new System.Windows.Forms.Button();
            this.btnLopHP = new System.Windows.Forms.Button();
            this.btnGiangVien = new System.Windows.Forms.Button();
            this.btnSinhVien = new System.Windows.Forms.Button();
            this.btnBangDiem = new System.Windows.Forms.Button();
            this.pnlOption = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlBase.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.mnsUser.SuspendLayout();
            this.pnlLeftSide.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlOption.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBase
            // 
            this.pnlBase.Controls.Add(this.pnlContain);
            this.pnlBase.Controls.Add(this.pnlHeader);
            this.pnlBase.Controls.Add(this.pnlLeftSide);
            this.pnlBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBase.Location = new System.Drawing.Point(0, 0);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(1008, 681);
            this.pnlBase.TabIndex = 0;
            // 
            // pnlContain
            // 
            this.pnlContain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlContain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContain.Location = new System.Drawing.Point(200, 60);
            this.pnlContain.Name = "pnlContain";
            this.pnlContain.Size = new System.Drawing.Size(808, 621);
            this.pnlContain.TabIndex = 2;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Silver;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.mnsUser);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(200, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(808, 60);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(180, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 32);
            this.lblTitle.TabIndex = 0;
            // 
            // mnsUser
            // 
            this.mnsUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mnsUser.Dock = System.Windows.Forms.DockStyle.None;
            this.mnsUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmUser});
            this.mnsUser.Location = new System.Drawing.Point(727, 18);
            this.mnsUser.Name = "mnsUser";
            this.mnsUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mnsUser.Size = new System.Drawing.Size(72, 24);
            this.mnsUser.TabIndex = 1;
            // 
            // tsmUser
            // 
            this.tsmUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiChangePass,
            this.tsmiLogout,
            this.tsmiExit});
            this.tsmUser.Name = "tsmUser";
            this.tsmUser.Size = new System.Drawing.Size(64, 20);
            this.tsmUser.Text = "Account";
            // 
            // tsmiChangePass
            // 
            this.tsmiChangePass.Name = "tsmiChangePass";
            this.tsmiChangePass.Size = new System.Drawing.Size(180, 22);
            this.tsmiChangePass.Text = "Đổi mật khẩu";
            this.tsmiChangePass.Click += new System.EventHandler(this.tsmiChangePass_Click);
            // 
            // tsmiLogout
            // 
            this.tsmiLogout.Name = "tsmiLogout";
            this.tsmiLogout.Size = new System.Drawing.Size(180, 22);
            this.tsmiLogout.Text = "Đăng xuất";
            this.tsmiLogout.Click += new System.EventHandler(this.tsmiLogout_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(180, 22);
            this.tsmiExit.Text = "Thoát";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // pnlLeftSide
            // 
            this.pnlLeftSide.BackColor = System.Drawing.Color.Silver;
            this.pnlLeftSide.Controls.Add(this.pnlMenu);
            this.pnlLeftSide.Controls.Add(this.pnlOption);
            this.pnlLeftSide.Controls.Add(this.pnlLogo);
            this.pnlLeftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftSide.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftSide.Name = "pnlLeftSide";
            this.pnlLeftSide.Size = new System.Drawing.Size(200, 681);
            this.pnlLeftSide.TabIndex = 0;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.btnMonHoc);
            this.pnlMenu.Controls.Add(this.btnKhoa);
            this.pnlMenu.Controls.Add(this.btnLopHC);
            this.pnlMenu.Controls.Add(this.btnLopHP);
            this.pnlMenu.Controls.Add(this.btnGiangVien);
            this.pnlMenu.Controls.Add(this.btnSinhVien);
            this.pnlMenu.Controls.Add(this.btnBangDiem);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Location = new System.Drawing.Point(0, 100);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Padding = new System.Windows.Forms.Padding(1);
            this.pnlMenu.Size = new System.Drawing.Size(200, 549);
            this.pnlMenu.TabIndex = 2;
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.BackColor = System.Drawing.Color.LightGray;
            this.btnMonHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMonHoc.FlatAppearance.BorderSize = 0;
            this.btnMonHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonHoc.Location = new System.Drawing.Point(1, 241);
            this.btnMonHoc.Name = "btnMonHoc";
            this.btnMonHoc.Padding = new System.Windows.Forms.Padding(48, 0, 0, 0);
            this.btnMonHoc.Size = new System.Drawing.Size(196, 40);
            this.btnMonHoc.TabIndex = 7;
            this.btnMonHoc.Text = "Môn học";
            this.btnMonHoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonHoc.UseVisualStyleBackColor = false;
            this.btnMonHoc.Click += new System.EventHandler(this.btnMonHoc_Click);
            // 
            // btnKhoa
            // 
            this.btnKhoa.BackColor = System.Drawing.Color.LightGray;
            this.btnKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhoa.FlatAppearance.BorderSize = 0;
            this.btnKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhoa.Location = new System.Drawing.Point(1, 201);
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.Padding = new System.Windows.Forms.Padding(48, 0, 0, 0);
            this.btnKhoa.Size = new System.Drawing.Size(196, 40);
            this.btnKhoa.TabIndex = 6;
            this.btnKhoa.Text = "Khoa";
            this.btnKhoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhoa.UseVisualStyleBackColor = false;
            this.btnKhoa.Click += new System.EventHandler(this.btnKhoa_Click);
            // 
            // btnLopHC
            // 
            this.btnLopHC.BackColor = System.Drawing.Color.LightGray;
            this.btnLopHC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLopHC.FlatAppearance.BorderSize = 0;
            this.btnLopHC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLopHC.Location = new System.Drawing.Point(1, 161);
            this.btnLopHC.Name = "btnLopHC";
            this.btnLopHC.Padding = new System.Windows.Forms.Padding(48, 0, 0, 0);
            this.btnLopHC.Size = new System.Drawing.Size(196, 40);
            this.btnLopHC.TabIndex = 5;
            this.btnLopHC.Text = "Lớp hành chính";
            this.btnLopHC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLopHC.UseVisualStyleBackColor = false;
            this.btnLopHC.Click += new System.EventHandler(this.btnLopHC_Click);
            // 
            // btnLopHP
            // 
            this.btnLopHP.BackColor = System.Drawing.Color.LightGray;
            this.btnLopHP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLopHP.FlatAppearance.BorderSize = 0;
            this.btnLopHP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLopHP.Location = new System.Drawing.Point(1, 121);
            this.btnLopHP.Name = "btnLopHP";
            this.btnLopHP.Padding = new System.Windows.Forms.Padding(48, 0, 0, 0);
            this.btnLopHP.Size = new System.Drawing.Size(196, 40);
            this.btnLopHP.TabIndex = 4;
            this.btnLopHP.Text = "Lớp học phần";
            this.btnLopHP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLopHP.UseVisualStyleBackColor = false;
            this.btnLopHP.Click += new System.EventHandler(this.btnLopHP_Click);
            // 
            // btnGiangVien
            // 
            this.btnGiangVien.BackColor = System.Drawing.Color.LightGray;
            this.btnGiangVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGiangVien.FlatAppearance.BorderSize = 0;
            this.btnGiangVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiangVien.Location = new System.Drawing.Point(1, 81);
            this.btnGiangVien.Name = "btnGiangVien";
            this.btnGiangVien.Padding = new System.Windows.Forms.Padding(48, 0, 0, 0);
            this.btnGiangVien.Size = new System.Drawing.Size(196, 40);
            this.btnGiangVien.TabIndex = 3;
            this.btnGiangVien.Text = "Giảng viên";
            this.btnGiangVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiangVien.UseVisualStyleBackColor = false;
            this.btnGiangVien.Click += new System.EventHandler(this.btnGiangVien_Click);
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.BackColor = System.Drawing.Color.LightGray;
            this.btnSinhVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSinhVien.FlatAppearance.BorderSize = 0;
            this.btnSinhVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinhVien.Location = new System.Drawing.Point(1, 41);
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.Padding = new System.Windows.Forms.Padding(48, 0, 0, 0);
            this.btnSinhVien.Size = new System.Drawing.Size(196, 40);
            this.btnSinhVien.TabIndex = 1;
            this.btnSinhVien.Text = "Sinh Viên";
            this.btnSinhVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSinhVien.UseVisualStyleBackColor = false;
            this.btnSinhVien.Click += new System.EventHandler(this.btnSinhVien_Click);
            // 
            // btnBangDiem
            // 
            this.btnBangDiem.BackColor = System.Drawing.Color.LightGray;
            this.btnBangDiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBangDiem.FlatAppearance.BorderSize = 0;
            this.btnBangDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBangDiem.Location = new System.Drawing.Point(1, 1);
            this.btnBangDiem.Name = "btnBangDiem";
            this.btnBangDiem.Padding = new System.Windows.Forms.Padding(48, 0, 0, 0);
            this.btnBangDiem.Size = new System.Drawing.Size(196, 40);
            this.btnBangDiem.TabIndex = 0;
            this.btnBangDiem.Text = "Bảng Điểm";
            this.btnBangDiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBangDiem.UseVisualStyleBackColor = false;
            this.btnBangDiem.Click += new System.EventHandler(this.btnBangDiem_Click);
            // 
            // pnlOption
            // 
            this.pnlOption.Controls.Add(this.lblVersion);
            this.pnlOption.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlOption.Location = new System.Drawing.Point(0, 649);
            this.pnlOption.Name = "pnlOption";
            this.pnlOption.Size = new System.Drawing.Size(200, 32);
            this.pnlOption.TabIndex = 1;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(42, 7);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(117, 16);
            this.lblVersion.TabIndex = 0;
            this.lblVersion.Text = "Quản lý điểm 1.0.3";
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.DimGray;
            this.pnlLogo.Controls.Add(this.lblLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(200, 100);
            this.pnlLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLogo.ForeColor = System.Drawing.Color.Azure;
            this.lblLogo.Location = new System.Drawing.Point(21, 16);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(159, 68);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "QUẢN LÝ\r\nSINH VIÊN";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogo.Click += new System.EventHandler(this.lblLogo_Click);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.pnlBase);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnsUser;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý điểm";
            this.Load += new System.EventHandler(this.fmMain_Load);
            this.SizeChanged += new System.EventHandler(this.fmMain_SizeChanged);
            this.pnlBase.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.mnsUser.ResumeLayout(false);
            this.mnsUser.PerformLayout();
            this.pnlLeftSide.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlOption.ResumeLayout(false);
            this.pnlOption.PerformLayout();
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBase;
        private System.Windows.Forms.Panel pnlContain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlLeftSide;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnBangDiem;
        private System.Windows.Forms.Panel pnlOption;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnSinhVien;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnKhoa;
        private System.Windows.Forms.Button btnLopHC;
        private System.Windows.Forms.Button btnLopHP;
        private System.Windows.Forms.Button btnGiangVien;
        private System.Windows.Forms.Button btnMonHoc;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.MenuStrip mnsUser;
        private System.Windows.Forms.ToolStripMenuItem tsmUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangePass;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogout;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
    }
}

