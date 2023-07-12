using Presentation.SerTaikhoan;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation.Forms.Edit
{
    public partial class fmChangePass : Form
    {
        public fmChangePass()
        {
            InitializeComponent();
        }

        readonly SerTaikhoanSoapClient client = new SerTaikhoanSoapClient();

        private void tbxOld_Enter(object sender, EventArgs e)
        {
            tbxOld.Clear();
            tbxOld.ForeColor = Color.Black;
            tbxOld.PasswordChar = '●';
        }

        private void tbxNew_Enter(object sender, EventArgs e)
        {
            tbxNew.Clear();
            tbxNew.ForeColor = Color.Black;
            tbxNew.PasswordChar = '●';
        }

        private void tbxRep_Enter(object sender, EventArgs e)
        {
            tbxRep.Clear();
            tbxRep.ForeColor = Color.Black;
            tbxRep.PasswordChar = '●';
        }

        private void cbkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbkShow.Checked)
            {
                tbxOld.PasswordChar = '\0';
                tbxNew.PasswordChar = '\0';
                tbxRep.PasswordChar = '\0';
            }
            else
            {
                tbxOld.PasswordChar = '●';
                tbxNew.PasswordChar = '●';
                tbxRep.PasswordChar = '●';
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxOld.Text.Contains("Mật khẩu cũ") || string.IsNullOrEmpty(tbxOld.Text))
                {
                    throw new Exception("Vui lòng nhập mật khẩu cũ!");
                }
                else if (tbxNew.Text != tbxRep.Text)
                {
                    throw new Exception("Mật khẩu không trùng khớp!");
                }
                else if (tbxNew.Text.Contains(" "))
                {
                    throw new Exception("Mật khẩu không được chứa dấu cách!");
                }
                else
                {
                    DTTaikhoan taiKhoan = new DTTaikhoan
                    {
                        Username = User.Username,
                        Password = tbxNew.Text.GetHashCode()
                    };
                    if (client.ChangePass(taiKhoan, tbxOld.Text.GetHashCode()))
                    {
                        MessageBox.Show("Đổi mật khẩu thành công.\nVui lòng đăng nhập lại!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        throw new Exception("Không thể đổi mật khẩu lúc này.\nVui lòng thử lại sau!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
