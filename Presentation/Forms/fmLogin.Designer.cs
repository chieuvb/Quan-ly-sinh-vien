namespace Presentation.Forms
{
    partial class fmLogin
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
            this.pnlCon = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.ptbAvatar = new System.Windows.Forms.PictureBox();
            this.cbkShowPass = new System.Windows.Forms.CheckBox();
            this.tbxUser = new System.Windows.Forms.TextBox();
            this.tbxPass = new System.Windows.Forms.TextBox();
            this.pnlCon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCon
            // 
            this.pnlCon.BackColor = System.Drawing.Color.Transparent;
            this.pnlCon.Controls.Add(this.lblTitle);
            this.pnlCon.Controls.Add(this.btnLogin);
            this.pnlCon.Controls.Add(this.ptbAvatar);
            this.pnlCon.Controls.Add(this.cbkShowPass);
            this.pnlCon.Controls.Add(this.tbxUser);
            this.pnlCon.Controls.Add(this.tbxPass);
            this.pnlCon.Location = new System.Drawing.Point(0, 0);
            this.pnlCon.Name = "pnlCon";
            this.pnlCon.Size = new System.Drawing.Size(584, 261);
            this.pnlCon.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTitle.Location = new System.Drawing.Point(84, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(417, 29);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Đăng nhập ứng dụng Quản lý điểm";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LightCyan;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(386, 165);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(128, 41);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // ptbAvatar
            // 
            this.ptbAvatar.Image = global::Presentation.Properties.Resources.Avatar;
            this.ptbAvatar.Location = new System.Drawing.Point(70, 80);
            this.ptbAvatar.Name = "ptbAvatar";
            this.ptbAvatar.Size = new System.Drawing.Size(128, 128);
            this.ptbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbAvatar.TabIndex = 2;
            this.ptbAvatar.TabStop = false;
            // 
            // cbkShowPass
            // 
            this.cbkShowPass.AutoSize = true;
            this.cbkShowPass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbkShowPass.Location = new System.Drawing.Point(204, 165);
            this.cbkShowPass.Name = "cbkShowPass";
            this.cbkShowPass.Size = new System.Drawing.Size(126, 22);
            this.cbkShowPass.TabIndex = 4;
            this.cbkShowPass.Text = "Hiện mật khẩu";
            this.cbkShowPass.UseVisualStyleBackColor = true;
            this.cbkShowPass.CheckedChanged += new System.EventHandler(this.cbkShowPass_CheckedChanged);
            // 
            // tbxUser
            // 
            this.tbxUser.BackColor = System.Drawing.SystemColors.Window;
            this.tbxUser.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUser.ForeColor = System.Drawing.Color.DimGray;
            this.tbxUser.Location = new System.Drawing.Point(204, 89);
            this.tbxUser.Name = "tbxUser";
            this.tbxUser.Size = new System.Drawing.Size(310, 32);
            this.tbxUser.TabIndex = 1;
            this.tbxUser.Text = "Tên đăng nhập";
            this.tbxUser.Enter += new System.EventHandler(this.tbxUser_Enter);
            this.tbxUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxUser_KeyPress);
            this.tbxUser.Leave += new System.EventHandler(this.tbxUser_Leave);
            // 
            // tbxPass
            // 
            this.tbxPass.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPass.ForeColor = System.Drawing.Color.DimGray;
            this.tbxPass.Location = new System.Drawing.Point(204, 127);
            this.tbxPass.Name = "tbxPass";
            this.tbxPass.Size = new System.Drawing.Size(310, 32);
            this.tbxPass.TabIndex = 3;
            this.tbxPass.Text = "Mật khẩu";
            this.tbxPass.Enter += new System.EventHandler(this.tbxPass_Enter);
            this.tbxPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPass_KeyPress);
            this.tbxPass.Leave += new System.EventHandler(this.tbxPass_Leave);
            // 
            // fmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.pnlCon);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đăng nhập";
            this.SizeChanged += new System.EventHandler(this.fmLogin_SizeChanged);
            this.pnlCon.ResumeLayout(false);
            this.pnlCon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlCon;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox ptbAvatar;
        private System.Windows.Forms.CheckBox cbkShowPass;
        private System.Windows.Forms.TextBox tbxUser;
        private System.Windows.Forms.TextBox tbxPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
    }
}