namespace Presentation.CrystalReport
{
    partial class fmReport
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
            this.crvReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvReportViewer
            // 
            this.crvReportViewer.ActiveViewIndex = -1;
            this.crvReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvReportViewer.Location = new System.Drawing.Point(0, 0);
            this.crvReportViewer.Name = "crvReportViewer";
            this.crvReportViewer.Size = new System.Drawing.Size(1008, 681);
            this.crvReportViewer.TabIndex = 0;
            // 
            // fmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.crvReportViewer);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fmReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvReportViewer;
    }
}