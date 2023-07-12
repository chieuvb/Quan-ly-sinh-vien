using Presentation.SerDiem;
using System;
using System.Windows.Forms;

namespace Presentation.Forms.Edit
{
    public partial class fmEditDiem : Form
    {
        public fmEditDiem(DTDiem die)
        {
            InitializeComponent();
            diem = die;
        }

        readonly SerDiemSoapClient client = new SerDiemSoapClient();
        readonly DTDiem diem;

        private void fmEditDiem_Load(object sender, EventArgs e)
        {
            tbxLophocphan.Text = diem.MaLopHocPhan + " | " + diem.TenLopHocPhan;
            tbxSinhvien.Text = diem.MaSinhVien + " | " + diem.TenSinhVien;
            tbxDiemCC.Text = diem.DiemChuyenCan.ToString();
            tbxDiemGK.Text = diem.DiemGiuaKy.ToString();
            tbxDiemKT.Text = diem.DiemThi.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                diem.DiemChuyenCan = double.Parse(tbxDiemCC.Text);
                diem.DiemGiuaKy = double.Parse(tbxDiemGK.Text);
                diem.DiemThi = double.Parse(tbxDiemKT.Text);
                diem.DiemTrungBinh = double.Parse(tbxDiemTB.Text);
                if (client.EditDiem(diem))
                {
                    MessageBox.Show("Sửa điểm thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    throw new Exception("Không thể sửa do có lỗi trong quá trình truy xuất dữ liệu!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bảng điểm của sinh viên này sẽ bị xóa khỏi hệ thống!" +
                    "\nBạn thực sự muốn xóa?", "Cảnh báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (client.DeleteDiem(diem))
                    {
                        MessageBox.Show("Xóa điểm thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        throw new Exception("Không thể xóa do có lỗi trong quá trình truy xuất dữ liệu!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void TinhDiemTB()
        {
            double diemCC = 0;
            double diemGK = 0;
            double diemKT = 0;

            if (!string.IsNullOrEmpty(tbxDiemCC.Text))
            {
                diemCC = double.Parse(tbxDiemCC.Text);
            }
            if (!string.IsNullOrEmpty(tbxDiemGK.Text))
            {
                diemGK = double.Parse(tbxDiemGK.Text);
            }
            if (!string.IsNullOrEmpty(tbxDiemKT.Text))
            {
                diemKT = double.Parse(tbxDiemKT.Text);
            }

            tbxDiemTB.Text = ((diemCC + diemGK + diemKT) / 3).ToString("F2");
        }

        private void tbxDiemCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.';
            if (e.KeyChar == '.')
            {
                e.Handled = tbxDiemCC.Text.Contains(".");
            }
        }

        private void tbxDiemCC_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(tbxDiemCC.Text, out double value))
            {
                if (value > 10)
                {
                    tbxDiemCC.Text = "10";
                }
            }
            TinhDiemTB();
        }

        private void tbxDiemGK_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.';
            if (e.KeyChar == '.')
            {
                e.Handled = tbxDiemGK.Text.Contains(".");
            }
        }

        private void tbxDiemGK_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(tbxDiemGK.Text, out double value))
            {
                if (value > 10)
                {
                    tbxDiemGK.Text = "10";
                }
            }
            TinhDiemTB();
        }

        private void tbxDiemThi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.';
            if (e.KeyChar == '.')
            {
                e.Handled = tbxDiemKT.Text.Contains(".");
            }
        }

        private void tbxDiemThi_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(tbxDiemKT.Text, out double value))
            {
                if (value > 10)
                {
                    tbxDiemKT.Text = "10";
                }
            }
            TinhDiemTB();
        }
    }
}
