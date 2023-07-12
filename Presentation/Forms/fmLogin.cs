using Presentation.SerTaikhoan;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class fmLogin : Form
    {
        public fmLogin()
        {
            InitializeComponent();
            client = new SerTaikhoanSoapClient();
        }

        readonly SerTaikhoanSoapClient client;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxUser.Text == "Tên đăng nhập" || string.IsNullOrEmpty(tbxUser.Text)
                    || tbxPass.Text == "Mật khẩu" || string.IsNullOrEmpty(tbxPass.Text))
                {
                    throw new Exception("Vui lòng nhập tài khoản, mật khẩu!");
                }
                else
                {
                    DTTaikhoan taiKhoan = client.Login(new DTTaikhoan
                    {
                        Username = tbxUser.Text.Trim(),
                        Password = tbxPass.Text.Trim().GetHashCode()
                    });

                    if (taiKhoan != null)
                    {
                        if (taiKhoan.Role > 1) { throw new Exception("Bạn không được phép đăng nhập ứng dụng!"); }
                        User.Username = taiKhoan.Username;
                        User.Role = taiKhoan.Role;
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        throw new Exception("Tài khoản hoặc mật khẩu không đúng!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbxUser_Enter(object sender, EventArgs e)
        {
            if (tbxUser.Text == "Tên đăng nhập") { tbxUser.Clear(); tbxUser.ForeColor = Color.Black; }
        }

        private void tbxUser_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxUser.Text))
            {
                tbxUser.Text = "Tên đăng nhập";
                tbxUser.ForeColor = Color.DimGray;
            }
        }

        private void tbxUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) { tbxPass.Focus(); }
        }

        private void tbxPass_Enter(object sender, EventArgs e)
        {
            if (cbkShowPass.Checked) { tbxPass.PasswordChar = '\0'; }
            else { tbxPass.PasswordChar = '●'; }
            if (tbxPass.Text == "Mật khẩu") { tbxPass.Clear(); tbxPass.ForeColor = Color.Black; }
        }

        private void tbxPass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxPass.Text))
            {
                tbxPass.Text = "Mật khẩu";
                tbxPass.ForeColor = Color.DimGray;
                tbxPass.PasswordChar = '\0';
            }
        }

        private void tbxPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) { btnLogin_Click(sender, e); }
        }

        private void cbkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbkShowPass.Checked) { tbxPass.PasswordChar = '\0'; }
            else { tbxPass.PasswordChar = '●'; }
        }

        private void fmLogin_SizeChanged(object sender, EventArgs e)
        {
            if (Width > 600) { pnlCon.Location = new Point(668, 374); }
            else { pnlCon.Location = new Point(0, 0); }
        }
    }
}
