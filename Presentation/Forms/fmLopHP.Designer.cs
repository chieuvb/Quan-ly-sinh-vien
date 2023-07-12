namespace Presentation.Forms
{
    partial class fmLopHP
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
            this.lsvLopHP = new System.Windows.Forms.ListView();
            this.btnPrin = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlPages.SuspendLayout();
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
            this.pnlPages.TabIndex = 26;
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
            // lsvLopHP
            // 
            this.lsvLopHP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsvLopHP.FullRowSelect = true;
            this.lsvLopHP.HideSelection = false;
            this.lsvLopHP.Location = new System.Drawing.Point(1, 206);
            this.lsvLopHP.Name = "lsvLopHP";
            this.lsvLopHP.Size = new System.Drawing.Size(806, 414);
            this.lsvLopHP.TabIndex = 25;
            this.lsvLopHP.UseCompatibleStateImageBehavior = false;
            this.lsvLopHP.View = System.Windows.Forms.View.Details;
            this.lsvLopHP.ItemActivate += new System.EventHandler(this.lsvLopHP_ItemActivate);
            // 
            // btnPrin
            // 
            this.btnPrin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPrin.Location = new System.Drawing.Point(669, 4);
            this.btnPrin.Name = "btnPrin";
            this.btnPrin.Size = new System.Drawing.Size(135, 32);
            this.btnPrin.TabIndex = 28;
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
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "Mở lớp";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // fmLopHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 621);
            this.Controls.Add(this.pnlPages);
            this.Controls.Add(this.lsvLopHP);
            this.Controls.Add(this.btnPrin);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fmLopHP";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "Lớp học phần";
            this.Load += new System.EventHandler(this.fmLopHP_Load);
            this.SizeChanged += new System.EventHandler(this.fmLopHP_SizeChanged);
            this.pnlPages.ResumeLayout(false);
            this.pnlPages.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPages;
        private System.Windows.Forms.Label lblcrPage;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnNex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lsvLopHP;
        private System.Windows.Forms.Button btnPrin;
        private System.Windows.Forms.Button btnAdd;
    }
}