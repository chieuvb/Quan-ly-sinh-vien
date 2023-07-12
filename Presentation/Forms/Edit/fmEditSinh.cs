using Presentation.SerSinhvien;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Presentation.Forms.Edit
{
    public partial class fmEditSinh : Form
    {
        public fmEditSinh(DTSinhvien vien)
        {
            InitializeComponent();
            sinhVien = vien;
        }

        readonly SerSinhvienSoapClient client = new SerSinhvienSoapClient();
        readonly DTSinhvien sinhVien = new DTSinhvien();
        ArrayOfString[] tinhThanh;
        ArrayOfString[] huyenThanh;
        ArrayOfString[] xaThanh;
        string maTinh, maHuyen;
        readonly Image holder = Properties.Resources.holder;

        private void fmEditSinh_Load(object sender, EventArgs e)
        {
            FirstLoad();
            FillOldData();

            byte[] anh = client.GetAnhSinhVien(sinhVien.MaSinhVien);

            if (anh != null)
            {
                using (MemoryStream mem = new MemoryStream(anh))
                {
                    Image img = Image.FromStream(mem);
                    ptbAvatar.Image = img;
                }
            }
            else
            {
                ptbAvatar.Image = holder;
            }
        }

        void FirstLoad()
        {
            tbxMasv.Text = "Mã sinh viên: " + sinhVien.MaSinhVien;
            tbxTen.Text = sinhVien.TenSinhVien;

            cbbTinh.Items.Add("-- Tỉnh thành --");
            cbbTinh.SelectedIndex = 0;
            cbbHuyen.Items.Add("-- Huyện thành --");
            cbbHuyen.SelectedIndex = 0;
            cbbXa.Items.Add("-- Xã thành --");
            cbbXa.SelectedIndex = 0;
            cbbLop.Items.Add("-- Lớp hành chính --");
            cbbLop.SelectedIndex = 0;

            tinhThanh = client.GetTinhThanh();

            for (int i = 0; i < tinhThanh.Length; i++)
            {
                cbbTinh.Items.Add(tinhThanh[i][1]);
            }

            var lopHC = client.GetAllLopHC();

            for (int i = 0; i < lopHC.Length; i++)
            {
                cbbLop.Items.Add(lopHC[i].MaLopHanhChinh + " | " + lopHC[i].TenLopHanhChinh);
            }
        }

        void FillOldData()
        {
            if (sinhVien.GioiTinh)
                rdbMal.Checked = true;
            else
                rdbFem.Checked = true;

            dtpNgaysinh.Value = sinhVien.NgaySinh;
            string[] diaChi = sinhVien.DiaChi.Split('-');

            if (diaChi.Length == 4)
            {
                tbxDiachi.Text = diaChi[0].Trim();

                foreach (var item in cbbTinh.Items)
                {
                    if (item.ToString().Contains(diaChi[3].Trim()))
                    {
                        cbbTinh.SelectedItem = item;
                        break;
                    }
                }

                foreach (var item in cbbHuyen.Items)
                {
                    if (item.ToString().Contains(diaChi[2].Trim()))
                    {
                        cbbHuyen.SelectedItem = item;
                        break;
                    }
                }

                foreach (var item in cbbXa.Items)
                {
                    if (item.ToString().Contains(diaChi[1].Trim()))
                    {
                        cbbXa.SelectedItem = item;
                        break;
                    }
                }
            }
            else { tbxDiachi.Text = "-- Số nhà / Tên đường --"; }

            tbxDienthoai.Text = sinhVien.DienThoai;
            tbxEmail.Text = sinhVien.Email.Trim();

            foreach (var item in cbbLop.Items)
            {
                if (item.ToString().Contains(sinhVien.MaLopHanhChinh.Trim()))
                {
                    cbbLop.SelectedItem = item;
                    break;
                }
            }
        }

        void CheckData(DTSinhvien sinh)
        {
            if (sinh.TenSinhVien.Contains("--"))
            {
                throw new Exception("Vui lòng nhập tên sinh viên!");
            }
            else if (string.IsNullOrEmpty(sinh.HoDem))
            {
                throw new Exception("Tên không hợp lệ!");
            }
            else if (sinh.NgaySinh == new DateTime(2009, 12, 31))
            {
                throw new Exception("Vui lòng chọn ngày sinh phù hợp!");
            }
            else if (sinh.DiaChi.Contains("--"))
            {
                throw new Exception("Địa chỉ không hợp lệ!");
            }
            else if (!Regex.IsMatch(sinh.DienThoai, @"^(0[2-9]|01[2689]|09|08[1-9])[0-9]{8}$"))
            {
                throw new Exception("Số điện thoại không hợp lệ!");
            }
            else if (!Regex.IsMatch(sinh.Email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                throw new Exception("Email không hợp lệ!");
            }
            else if (sinh.MaLopHanhChinh.Contains("-- Lớp hành chính --"))
            {
                throw new Exception("Bạn chưa chọn lớp!");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string masv = tbxMasv.Text.Split(' ')[3];
                string[] tensv = tbxTen.Text.Split(' ');
                string ho = string.Join(" ", tensv.Take(tensv.Length - 1));
                string ten = tensv[tensv.Length - 1];
                string dia = tbxDiachi.Text.Trim() + " - " + cbbXa.Text + " - "
                    + cbbHuyen.Text + " - " + cbbTinh.Text;

                byte[] arrAva;
                if (ptbAvatar.Image != holder)
                {
                    Image img = ptbAvatar.Image;
                    using (MemoryStream mem = new MemoryStream())
                    {
                        img.Save(mem, ImageFormat.Png);
                        arrAva = mem.ToArray();
                    }
                }
                else
                {
                    arrAva = null;
                }

                DTSinhvien sinh = new DTSinhvien
                {
                    MaSinhVien = masv,
                    TenSinhVien = ten,
                    HoDem = ho,
                    GioiTinh = rdbMal.Checked,
                    NgaySinh = dtpNgaysinh.Value,
                    DiaChi = dia,
                    DienThoai = tbxDienthoai.Text,
                    Email = tbxEmail.Text,
                    MaLopHanhChinh = cbbLop.Text.Split('|')[0].Trim(),
                    AnhDaiDien = arrAva
                };

                CheckData(sinh);

                if (client.EditSinhVien(sinh))
                {
                    MessageBox.Show("Sửa thông tin sinh viên thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    throw new Exception("Không tìm thấy mã sinh viên!");
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
            if (MessageBox.Show("Sinh viên này sẽ bị xóa khỏi hệ thống!", "Cảnh báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    string masv = tbxMasv.Text.Split(' ')[3];
                    if (client.DeleteSinhVien(masv))
                    {
                        MessageBox.Show("Xóa thông tin sinh viên thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        throw new Exception("Không tìm thấy mã sinh viên!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbxTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbxDienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cbbTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTinh.SelectedIndex > 0)
            {
                cbbHuyen.Items.Clear();
                cbbXa.Items.Clear();
                cbbHuyen.Items.Add("-- Huyện thành --");
                cbbHuyen.SelectedIndex = 0;
                cbbXa.Items.Add("-- Xã thành --");
                cbbXa.SelectedIndex = 0;

                for (int i = 0; i < tinhThanh.Length; i++)
                {
                    if (cbbTinh.Text == tinhThanh[i][1])
                    {
                        maTinh = tinhThanh[i][0];
                        break;
                    }
                }

                huyenThanh = client.GetHuyen(maTinh);

                for (int i = 0; i < huyenThanh.Length; i++)
                {
                    cbbHuyen.Items.Add(huyenThanh[i][2]);
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

                for (int i = 0; i < huyenThanh.Length; i++)
                {
                    if (cbbHuyen.Text == huyenThanh[i][2])
                    {
                        maHuyen = huyenThanh[i][0];
                    }
                }

                xaThanh = client.GetXa(maHuyen);

                for (int i = 0; i < xaThanh.Length; i++)
                {
                    cbbXa.Items.Add(xaThanh[i][2]);
                }
            }
            else
            {
                cbbXa.Items.Clear();
                cbbXa.Items.Add("-- Xã thành --");
                cbbXa.SelectedIndex = 0;
            }
        }

        private void tbxDiachi_Enter(object sender, EventArgs e)
        {
            if (tbxDiachi.Text.Contains("-- Số nhà / Tên đường --")) { tbxDiachi.Clear(); }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog upl = new OpenFileDialog
            {
                Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png)|*.bmp;*.jpg;*.jpeg;*.png"
            };
            if (upl.ShowDialog() == DialogResult.OK)
            {
                string imagePath = upl.FileName;
                ptbAvatar.ImageLocation = imagePath;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ptbAvatar.Image = holder;
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
