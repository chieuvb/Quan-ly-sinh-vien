namespace Presentation.Forms.Edit
{
    partial class fmChangePass
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
            this.tbxOld = new System.Windows.Forms.TextBox();
            this.tbxNew = new System.Windows.Forms.TextBox();
            this.tbxRep = new System.Windows.Forms.TextBox();
            this.cbkShow = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Tan;
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.Location = new System.Drawing.Point(284, 85);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(128, 44);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Đổi";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tbxOld
            // 
            this.tbxOld.ForeColor = System.Drawing.Color.Gray;
            this.tbxOld.Location = new System.Drawing.Point(52, 42);
            this.tbxOld.Name = "tbxOld";
            this.tbxOld.Size = new System.Drawing.Size(170, 26);
            this.tbxOld.TabIndex = 1;
            this.tbxOld.Text = "Mật khẩu cũ";
            this.tbxOld.Enter += new System.EventHandler(this.tbxOld_Enter);
            // 
            // tbxNew
            // 
            this.tbxNew.ForeColor = System.Drawing.Color.Gray;
            this.tbxNew.Location = new System.Drawing.Point(52, 95);
            this.tbxNew.Name = "tbxNew";
            this.tbxNew.Size = new System.Drawing.Size(170, 26);
            this.tbxNew.TabIndex = 2;
            this.tbxNew.Text = "Mật khẩu mới";
            this.tbxNew.Enter += new System.EventHandler(this.tbxNew_Enter);
            // 
            // tbxRep
            // 
            this.tbxRep.ForeColor = System.Drawing.Color.Gray;
            this.tbxRep.Location = new System.Drawing.Point(52, 127);
            this.tbxRep.Name = "tbxRep";
            this.tbxRep.Size = new System.Drawing.Size(170, 26);
            this.tbxRep.TabIndex = 3;
            this.tbxRep.Text = "Nhập lại";
            this.tbxRep.Enter += new System.EventHandler(this.tbxRep_Enter);
            // 
            // cbkShow
            // 
            this.cbkShow.AutoSize = true;
            this.cbkShow.Location = new System.Drawing.Point(66, 159);
            this.cbkShow.Name = "cbkShow";
            this.cbkShow.Size = new System.Drawing.Size(126, 22);
            this.cbkShow.TabIndex = 4;
            this.cbkShow.Text = "Hiện mật khẩu";
            this.cbkShow.UseVisualStyleBackColor = true;
            this.cbkShow.CheckedChanged += new System.EventHandler(this.cbkShow_CheckedChanged);
            // 
            // fmChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 217);
            this.Controls.Add(this.cbkShow);
            this.Controls.Add(this.tbxRep);
            this.Controls.Add(this.tbxNew);
            this.Controls.Add(this.tbxOld);
            this.Controls.Add(this.btnSubmit);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbxOld;
        private System.Windows.Forms.TextBox tbxNew;
        private System.Windows.Forms.TextBox tbxRep;
        private System.Windows.Forms.CheckBox cbkShow;
    }
}