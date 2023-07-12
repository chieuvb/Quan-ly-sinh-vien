using Presentation.SerGiangvien;
using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Presentation.Forms.Add
{
    public partial class fmAddGiang : Form
    {
        public fmAddGiang(string mgv)
        {
            InitializeComponent();
            lasMas = mgv;
        }

        readonly SerGiangvienSoapClient client = new SerGiangvienSoapClient();
        readonly string lasMas;
        DTKhoa[] khoas;
        ArrayOfString[] tinhThanh;
        ArrayOfString[] huyenThanh;
        string maTinh, maHuyen;

        private void fmAddGiang_Load(object sender, EventArgs e)
        {
            FirstLoad();
        }

        void FirstLoad()
        {
            int newID = int.Parse(lasMas.Substring(2)) + 1;
            string newMas = "Mã giảng viên: GV" + newID.ToString();
            tbxMagv.Text = newMas;

            tbxTen.Text = "-- Họ và tên --";
            tbxTen.ForeColor = Color.DimGray;

            cbbTinh.Items.Add("-- Tỉnh thành --");
            cbbHuyen.Items.Add("-- Huyện thành --");
            cbbXa.Items.Add("-- Xã thành --");
            cbbKhoa.Items.Add("-- Khoa --");

            cbbTinh.SelectedIndex = 0;
            cbbHuyen.SelectedIndex = 0;
            cbbXa.SelectedIndex = 0;
            cbbHocvi.SelectedIndex = 0;
            cbbKhoa.SelectedIndex = 0;

            tbxDiachi.Text = "-- Số nhà / Tên đường --";
            tbxDiachi.ForeColor = Color.DimGray;

            tbxDienthoai.Text = "-- Số điện thoại --";
            tbxDienthoai.ForeColor = Color.DimGray;

            tbxEmail.Text = "-- Email --";
            tbxEmail.ForeColor = Color.DimGray;

            tinhThanh = client.GetTinh();
            foreach (var item in tinhThanh)
            {
                cbbTinh.Items.Add(item[1]);
            }

            khoas = client.GetKhoa();
            foreach (var khoa in khoas)
            {
                cbbKhoa.Items.Add(khoa.MaKhoa + " | " + khoa.TenKhoa);
            }
        }

        private void tbxTen_Enter(object sender, EventArgs e)
        {
            if (tbxTen.Text == "-- Họ và tên --")
            {
                tbxTen.Clear();
                tbxTen.ForeColor = Color.Black;
            }
        }

        private void tbxTen_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxTen.Text))
            {
                tbxTen.Text = "-- Họ và tên --";
                tbxTen.ForeColor = Color.DimGray;
            }
            else
            {
                tbxTen.Text = string.Join(" ", tbxTen.Text.Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries));
            }
        }

        private void tbxTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbxDiachi_Enter(object sender, EventArgs e)
        {
            if (tbxDiachi.Text == "-- Số nhà / Tên đường --")
            {
                tbxDiachi.Clear();
                tbxDiachi.ForeColor = Color.Black;
            }
        }

        private void tbxDiachi_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxDiachi.Text))
            {
                tbxDiachi.Text = "-- Số nhà / Tên đường --";
                tbxDiachi.ForeColor = Color.DimGray;
            }
            else
            {
                tbxDiachi.Text = string.Join(" ", tbxDiachi.Text.Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries));
            }
        }

        private void tbxDienthoai_Enter(object sender, EventArgs e)
        {
            if (tbxDienthoai.Text == "-- Số điện thoại --")
            {
                tbxDienthoai.Clear();
                tbxDienthoai.ForeColor = Color.Black;
            }
        }

        private void tbxDienthoai_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxDienthoai.Text))
            {
                tbxDienthoai.Text = "-- Số điện thoại --";
                tbxDienthoai.ForeColor = Color.DimGray;
            }
        }

        private void tbxDienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbxEmail_Enter(object sender, EventArgs e)
        {
            if (tbxEmail.Text == "-- Email --")
            {
                tbxEmail.Clear();
                tbxEmail.ForeColor = Color.Black;
            }
        }

        private void tbxEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxEmail.Text))
            {
                tbxEmail.Text = "-- Email --";
                tbxEmail.ForeColor = Color.DimGray;
            }
            else
            {
                tbxEmail.Text = string.Join(" ", tbxEmail.Text.Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries));
            }
        }

        private void cbbTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTinh.SelectedIndex > 0)
            {
                cbbHuyen.Items.Clear();
                cbbXa.Items.Clear();
                tbxDiachi.Clear();
                cbbHuyen.Items.Add("-- Huyện thành --");
                cbbXa.Items.Add("-- Xã thành --");
                tbxDiachi.Text = "-- Số nhà / Tên đường --";
                tbxDiachi.ForeColor = Color.DimGray;
                cbbHuyen.SelectedIndex = 0;
                cbbXa.SelectedIndex = 0;

                for (int i = 0; i < tinhThanh.Length; i++)
                {
                    if (tinhThanh[i][1] == cbbTinh.Text)
                    {
                        maTinh = tinhThanh[i][0];
                    }
                }

                var huyenThanh = client.GetHuyen(maTinh);

                foreach (var huyen in huyenThanh)
                {
                    cbbHuyen.Items.Add(huyen[2]);
                }
            }
            else
            {
                cbbHuyen.Items.Clear();
                cbbHuyen.Items.Add("-- Huyện thành --");
                cbbHuyen.SelectedIndex = 0;
            }
        }

        private void cbbHuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbHuyen.SelectedIndex > 0)
            {
                cbbXa.Items.Clear();
                cbbXa.Items.Add("-- Xã thành --");
                cbbXa.SelectedIndex = 0;

                huyenThanh = client.GetHuyen(maTinh);

                for (int i = 0; i < huyenThanh.Length; i++)
                {
                    if (huyenThanh[i][2] == cbbHuyen.Text)
                    {
                        maHuyen = huyenThanh[i][0];
                    }
                }

                var xaThanh = client.GetXa(maHuyen);

                foreach (var xa in xaThanh)
                {
                    cbbXa.Items.Add(xa[2]);
                }
            }
            else
            {
                cbbXa.Items.Clear();
                cbbXa.Items.Add("-- Xã thành --");
                cbbXa.SelectedIndex = 0;
            }
        }

        private void cbbXa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbXa.SelectedIndex > 0)
            {
                tbxDiachi.Text = "-- Số nhà / Tên đường --";
                tbxDiachi.ForeColor = Color.DimGray;
                tbxDiachi.Enabled = true;
            }
            else
            {
                tbxDiachi.Text = "-- Số nhà / Tên đường --";
                tbxDiachi.ForeColor = Color.DimGray;
                tbxDiachi.Enabled = false;
            }
        }

        void CheckData(DTGiangvien gv)
        {
            if (gv.TenGiangVien.Contains("--"))
            {
                throw new Exception("Tên không hợp lệ!");
            }
            else if (string.IsNullOrWhiteSpace(gv.HoDem))
            {
                throw new Exception("Vui lòng nhập họ tên đầy đủ!");
            }
            else if (gv.NgaySinh == new DateTime(2009, 12, 31))
            {
                throw new Exception("Ngày sinh không hợp lệ!");
            }
            else if (gv.DiaChi.Contains("--"))
            {
                throw new Exception("Địa chỉ không hợp lệ!");
            }
            else if (!Regex.IsMatch(gv.DienThoai, @"^(0[2-9]|01[2689]|09|08[1-9])[0-9]{8}$"))
            {
                throw new Exception("Số điện thoại không hợp lệ!");
            }
            else if (!Regex.IsMatch(gv.Email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                throw new Exception("Email không hợp lệ!");
            }
            else if (gv.HocVi.Contains("--"))
            {
                throw new Exception("Học vị chưa được chọn!");
            }
            else if (gv.MaKhoa.Contains("--"))
            {
                throw new Exception("Vui lòng chọn khoa!");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string maGV = tbxMagv.Text.Split(' ')[3];
                string[] tenGV = tbxTen.Text.Split(' ');
                string ten = tenGV[tenGV.Length - 1];
                string ho = string.Join(" ", tenGV.Take(tenGV.Length - 1));
                string dia = tbxDiachi.Text + " - " + cbbXa.Text + " - " + cbbHuyen.Text + " - " + cbbTinh.Text;

                DTGiangvien giangVien = new DTGiangvien
                {
                    MaGiangVien = maGV,
                    TenGiangVien = ten,
                    HoDem = ho,
                    GioiTinh = rdbMal.Checked,
                    NgaySinh = dtpNgaysinh.Value,
                    DiaChi = dia,
                    DienThoai = tbxDienthoai.Text,
                    Email = tbxEmail.Text,
                    HocVi = cbbHocvi.Text,
                    MaKhoa = cbbKhoa.Text.Split('|')[0].Trim()
                };

                CheckData(giangVien);

                if (client.ThemGiangVien(giangVien))
                {
                    MessageBox.Show("Thêm giảng viên thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    throw new Exception("Mã giảng viên này đã được sử dụng!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
