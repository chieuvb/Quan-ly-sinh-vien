using Presentation.SerGiangvien;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Presentation.Forms.Edit
{
    public partial class fmEditGiang : Form
    {
        public fmEditGiang(DTGiangvien gv)
        {
            InitializeComponent();
            giangVien = gv;
        }

        readonly SerGiangvienSoapClient client = new SerGiangvienSoapClient();
        readonly DTGiangvien giangVien = new DTGiangvien();
        List<string[]> tinhThanhs;
        List<string[]> huyenThanhs;
        string maTinh, maHuyen;

        private void fmEditGiang_Load(object sender, EventArgs e)
        {
            FillOldData();
        }

        List<string[]> ToList(ArrayOfString[] arr)
        {
            List<string[]> res = arr.Select(x => x.ToArray()).ToList();
            return res;
        }

        private void FillOldData()
        {
            tbxMagv.Text = "Mã giảng viên: " + giangVien.MaGiangVien;
            tbxTen.Text = giangVien.TenGiangVien;
            if (giangVien.GioiTinh)
            {
                rdbMal.Checked = true;
            }
            else
            {
                rdbFem.Checked = true;
            }
            dtpNgaysinh.Value = giangVien.NgaySinh;

            cbbTinh.Items.Add("-- Tỉnh thành --");
            cbbHuyen.Items.Add("-- Huyện thành --");
            cbbXa.Items.Add("-- Xã thành --");
            cbbKhoa.Items.Add("-- Khoa --");

            cbbTinh.SelectedIndex = 0;
            cbbHuyen.SelectedIndex = 0;
            cbbXa.SelectedIndex = 0;
            cbbHocvi.SelectedIndex = 0;
            cbbKhoa.SelectedIndex = 0;

            tbxDienthoai.Text = giangVien.DienThoai;
            tbxEmail.Text = giangVien.Email;

            tinhThanhs = ToList(client.GetTinh());
            foreach (string[] item in tinhThanhs) { cbbTinh.Items.Add(item[1]); }

            List<DTKhoa> khoas = client.GetKhoa().ToList();
            foreach (var khoa in khoas)
            {
                cbbKhoa.Items.Add(khoa.MaKhoa + " | " + khoa.TenKhoa);
            }

            string[] diaChi = giangVien.DiaChi.Split('-');
            if (diaChi.Length > 3)
            {
                tbxDiachi.Text = diaChi[0].Trim();
                foreach (var item in cbbTinh.Items)
                {
                    if (item.ToString() == diaChi[3].Trim())
                    {
                        cbbTinh.SelectedItem = item; break;
                    }
                }
                foreach (var item in cbbHuyen.Items)
                {
                    if (item.ToString() == diaChi[2].Trim())
                    {
                        cbbHuyen.SelectedItem = item; break;
                    }
                }
                foreach (var item in cbbXa.Items)
                {
                    if (item.ToString() == diaChi[1].Trim())
                    {
                        cbbXa.SelectedItem = item; break;
                    }
                }
            }
            else { tbxDiachi.Text = "-- Số nhà / Tên đường --"; }

            foreach (var item in cbbHocvi.Items)
            {
                if (item.ToString().Contains(giangVien.HocVi.Trim()))
                {
                    cbbHocvi.SelectedItem = item; break;
                }
            }

            foreach (var item in cbbKhoa.Items)
            {
                if (item.ToString().Contains(giangVien.MaKhoa.Trim()))
                {
                    cbbKhoa.SelectedItem = item; break;
                }
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
            if (string.IsNullOrEmpty(tbxTen.Text))
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
            if (string.IsNullOrEmpty(tbxDiachi.Text))
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
            else
            {
                tbxDienthoai.Text = string.Join(" ", tbxDienthoai.Text.Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries));
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
            if (string.IsNullOrEmpty(tbxEmail.Text))
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
                cbbHuyen.Items.Add("-- Huyện thành --");
                cbbXa.Items.Add("-- Xã thành --");
                cbbHuyen.SelectedIndex = 0;
                cbbXa.SelectedIndex = 0;

                string[] foundTinh = tinhThanhs.Find(tinh => tinh[1] == cbbTinh.Text);
                if (foundTinh != null) { maTinh = foundTinh[0]; }

                List<string[]> huyenThanh = ToList(client.GetHuyen(maTinh));
                foreach (string[] huyen in huyenThanh)
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

                huyenThanhs = ToList(client.GetHuyen(maTinh));
                string[] foundHuyen = huyenThanhs.Find(huyen => huyen[2] == cbbHuyen.Text);
                if (foundHuyen != null)
                {
                    maHuyen = foundHuyen[0];
                }

                List<string[]> xaThanh = ToList(client.GetXa(maHuyen));
                foreach (string[] xa in xaThanh)
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

                if (client.EditGiangVien(giangVien))
                {
                    MessageBox.Show("Sửa thông tin giảng viên thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    throw new Exception("Không tìm thấy thông tin giảng viên!");
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
            if (MessageBox.Show("Giảng viên này sẽ bị xóa khỏi hệ thống!", "Cảnh báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    string ma = tbxMagv.Text.Split(' ')[3];
                    if (client.DeleteGiangVien(ma))
                    {
                        MessageBox.Show("Xóa thông tin giảng viên thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        throw new Exception("Không tìm thấy thông tin giảng viên!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
