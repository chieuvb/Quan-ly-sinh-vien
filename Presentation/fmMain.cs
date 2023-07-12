using Presentation.Forms;
using Presentation.Forms.Edit;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation
{
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();
        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            if (new fmLogin().ShowDialog() == DialogResult.OK)
            {
                tsmUser.Text = User.Username + " / ";
                switch (User.Role)
                {
                    case 0:
                        tsmUser.Text += "teacher";
                        break;
                    case 1:
                        tsmUser.Text += "admin";
                        break;
                    default:
                        tsmUser.Text += "?role";
                        break;
                }
                OpenChildForm(new fmHome(), sender);
                Show();
            }
            else { Close(); }
        }

        void OpenChildForm(Form childForm, object obj)
        {
            if (pnlContain.Controls.Count > 0)
            {
                if (pnlContain.Controls[0].Name == childForm.Name) { return; }
            }

            pnlContain.Controls?.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.BackColor = Color.WhiteSmoke;
            childForm.Dock = DockStyle.Fill;
            pnlContain.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;

            if (obj is Button btn)
            {
                foreach (Button preBut in pnlMenu.Controls)
                {
                    preBut.BackColor = Color.LightGray;
                    preBut.ForeColor = Color.Black;
                }
                btn.BackColor = Color.LightCyan;
                btn.ForeColor = Color.MidnightBlue;
            }
        }

        private void fmMain_SizeChanged(object sender, EventArgs e)
        {
            if (Width > 1024)
            {
                pnlLeftSide.Width = 300;
                lblLogo.Text = "QUẢN LÝ SINH VIÊN";
                lblLogo.Location = new Point(2, 33);
                lblVersion.Location = new Point(92, 7);
                lblTitle.Location = new Point(280, 14);
                foreach (Button but in pnlMenu.Controls)
                {
                    but.Height = 50;
                    but.Padding = new Padding(88, 0, 0, 0);
                    but.Font = new Font("Arial", 14);
                }
            }
            else
            {
                pnlLeftSide.Width = 200;
                lblLogo.Text = "QUẢN LÝ\nSINH VIÊN";
                lblLogo.Location = new Point(21, 16);
                lblVersion.Location = new Point(42, 7);
                lblTitle.Location = new Point(180, 14);
                foreach (Button but in pnlMenu.Controls)
                {
                    but.Height = 40;
                    but.Padding = new Padding(48, 0, 0, 0);
                    but.Font = new Font("Arial", 12);
                }
            }
        }

        private void tsmiChangePass_Click(object sender, EventArgs e)
        {
            if (new fmChangePass().ShowDialog() == DialogResult.OK)
            {
                tsmiLogout_Click(sender, e);
            }
        }

        private void tsmiLogout_Click(object sender, EventArgs e)
        {
            User.Username = "";
            User.Password = "";
            User.Role = -1;
            Hide();
            fmMain_Load(sender, e);
            foreach (Button preBut in pnlMenu.Controls)
            {
                preBut.BackColor = Color.LightGray;
                preBut.ForeColor = Color.Black;
            }
        }

        private void lblLogo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fmHome(), sender);
            foreach (Button preBut in pnlMenu.Controls)
            {
                preBut.BackColor = Color.LightGray;
                preBut.ForeColor = Color.Black;
            }
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBangDiem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fmBangdiem(), sender);
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fmSinhvien(), sender);
        }

        private void btnGiangVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fmGiangvien(), sender);
        }

        private void btnLopHP_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fmLopHP(), sender);
        }

        private void btnLopHC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fmLopHC(), sender);
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fmKhoa(), sender);
        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fmMonhoc(), sender);
        }
    }
}
