namespace Presentation.Forms
{
    partial class fmKhoa
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
            this.pnlPages = new System.Windows.Forms.Panel();
            this.lblcrPage = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnNex = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lsvKhoa = new System.Windows.Forms.ListView();
            this.btnPrin = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grbAdd = new System.Windows.Forms.GroupBox();
            this.pnlText = new System.Windows.Forms.Panel();
            this.tbxMakhoa = new System.Windows.Forms.TextBox();
            this.tbxTenkhoa = new System.Windows.Forms.TextBox();
            this.tbxDienthoai = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pnlPages.SuspendLayout();
            this.grbAdd.SuspendLayout();
            this.pnlText.SuspendLayout();
            this.SuspendLayout();
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
            this.pnlPages.TabIndex = 18;
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
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(96, 10);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(17, 18);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "0";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "/";
            // 
            // lsvKhoa
            // 
            this.lsvKhoa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsvKhoa.FullRowSelect = true;
            this.lsvKhoa.HideSelection = false;
            this.lsvKhoa.Location = new System.Drawing.Point(1, 206);
            this.lsvKhoa.Name = "lsvKhoa";
            this.lsvKhoa.Size = new System.Drawing.Size(806, 414);
            this.lsvKhoa.TabIndex = 17;
            this.lsvKhoa.UseCompatibleStateImageBehavior = false;
            this.lsvKhoa.View = System.Windows.Forms.View.Details;
            this.lsvKhoa.ItemActivate += new System.EventHandler(this.lsvKhoa_ItemActivate);
            // 
            // btnPrin
            // 
            this.btnPrin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPrin.Location = new System.Drawing.Point(669, 4);
            this.btnPrin.Name = "btnPrin";
            this.btnPrin.Size = new System.Drawing.Size(135, 32);
            this.btnPrin.TabIndex = 20;
            this.btnPrin.Text = "In";
            this.btnPrin.UseVisualStyleBackColor = false;
            this.btnPrin.Click += new System.EventHandler(this.btnPrin_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdd.Location = new System.Drawing.Point(4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 32);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Thêm khoa";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grbAdd
            // 
            this.grbAdd.Controls.Add(this.pnlText);
            this.grbAdd.Controls.Add(this.btnDelete);
            this.grbAdd.Controls.Add(this.btnCancel);
            this.grbAdd.Controls.Add(this.btnSubmit);
            this.grbAdd.Location = new System.Drawing.Point(4, 42);
            this.grbAdd.Name = "grbAdd";
            this.grbAdd.Size = new System.Drawing.Size(800, 114);
            this.grbAdd.TabIndex = 21;
            this.grbAdd.TabStop = false;
            this.grbAdd.Text = "Thêm khoa";
            // 
            // pnlText
            // 
            this.pnlText.Controls.Add(this.tbxMakhoa);
            this.pnlText.Controls.Add(this.tbxTenkhoa);
            this.pnlText.Controls.Add(this.tbxDienthoai);
            this.pnlText.Location = new System.Drawing.Point(6, 25);
            this.pnlText.Name = "pnlText";
            this.pnlText.Size = new System.Drawing.Size(788, 32);
            this.pnlText.TabIndex = 22;
            // 
            // tbxMakhoa
            // 
            this.tbxMakhoa.Location = new System.Drawing.Point(3, 3);
            this.tbxMakhoa.MaxLength = 8;
            this.tbxMakhoa.Name = "tbxMakhoa";
            this.tbxMakhoa.Size = new System.Drawing.Size(100, 26);
            this.tbxMakhoa.TabIndex = 0;
            this.tbxMakhoa.Enter += new System.EventHandler(this.tbxMakhoa_Enter);
            this.tbxMakhoa.Leave += new System.EventHandler(this.tbxMakhoa_Leave);
            // 
            // tbxTenkhoa
            // 
            this.tbxTenkhoa.Location = new System.Drawing.Point(109, 3);
            this.tbxTenkhoa.Name = "tbxTenkhoa";
            this.tbxTenkhoa.Size = new System.Drawing.Size(364, 26);
            this.tbxTenkhoa.TabIndex = 1;
            this.tbxTenkhoa.Enter += new System.EventHandler(this.tbxTenkhoa_Enter);
            this.tbxTenkhoa.Leave += new System.EventHandler(this.tbxTenkhoa_Leave);
            // 
            // tbxDienthoai
            // 
            this.tbxDienthoai.Location = new System.Drawing.Point(479, 3);
            this.tbxDienthoai.MaxLength = 10;
            this.tbxDienthoai.Name = "tbxDienthoai";
            this.tbxDienthoai.Size = new System.Drawing.Size(306, 26);
            this.tbxDienthoai.TabIndex = 2;
            this.tbxDienthoai.Enter += new System.EventHandler(this.tbxDienthoai_Enter);
            this.tbxDienthoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxDienthoai_KeyPress);
            this.tbxDienthoai.Leave += new System.EventHandler(this.tbxDienthoai_Leave);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Salmon;
            this.btnDelete.Location = new System.Drawing.Point(590, 76);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 32);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCancel.Location = new System.Drawing.Point(6, 76);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 32);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSubmit.Location = new System.Drawing.Point(714, 76);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(80, 32);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Lưu";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // fmKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 621);
            this.Controls.Add(this.pnlPages);
            this.Controls.Add(this.lsvKhoa);
            this.Controls.Add(this.btnPrin);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grbAdd);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmKhoa";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "Khoa";
            this.Load += new System.EventHandler(this.fmKhoa_Load);
            this.SizeChanged += new System.EventHandler(this.fmKhoa_SizeChanged);
            this.pnlPages.ResumeLayout(false);
            this.pnlPages.PerformLayout();
            this.grbAdd.ResumeLayout(false);
            this.pnlText.ResumeLayout(false);
            this.pnlText.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPages;
        private System.Windows.Forms.Label lblcrPage;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnNex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lsvKhoa;
        private System.Windows.Forms.Button btnPrin;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grbAdd;
        private System.Windows.Forms.TextBox tbxDienthoai;
        private System.Windows.Forms.TextBox tbxTenkhoa;
        private System.Windows.Forms.TextBox tbxMakhoa;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlText;
    }
}