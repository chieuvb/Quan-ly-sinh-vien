using Presentation.SerSinhvien;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Presentation.Forms.Add
{
    public partial class fmAddSinh : Form
    {
        public fmAddSinh(string msv)
        {
            InitializeComponent();
            lasMas = msv;
        }

        readonly SerSinhvienSoapClient client = new SerSinhvienSoapClient();
        readonly string lasMas;
        ArrayOfString[] tinhThanh;
        ArrayOfString[] huyenThanh;
        ArrayOfString[] xaThanh;
        string maTinh, maHuyen;
        readonly Image holder = Properties.Resources.holder;

        private void fmAddSinh_Load(object sender, EventArgs e)
        {
            int newID = int.Parse(lasMas.Substring(2)) + 1;
            string newMas = "Mã sinh viên: SV" + newID.ToString();
            tbxMasv.Text = newMas;

            ptbAvatar.Image = holder;

            tbxTen.Text = "-- Họ và tên --";
            tbxTen.ForeColor = Color.DimGray;

            cbbTinh.Items.Add("-- Tỉnh thành --");
            cbbHuyen.Items.Add("-- Huyện thành --");
            cbbXa.Items.Add("-- Xã thành --");
            cbbLop.Items.Add("-- Lớp hành chính --");

            cbbTinh.SelectedIndex = 0;
            cbbHuyen.SelectedIndex = 0;
            cbbXa.SelectedIndex = 0;
            cbbLop.SelectedIndex = 0;

            tbxDiachi.Text = "-- Số nhà / Tên đường --";
            tbxDiachi.ForeColor = Color.DimGray;

            tbxDienthoai.Text = "-- Số điện thoại --";
            tbxDienthoai.ForeColor = Color.DimGray;

            tbxEmail.Text = "-- Email --";
            tbxEmail.ForeColor = Color.DimGray;

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

                DTSinhvien sinhvien = new DTSinhvien
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

                CheckData(sinhvien);

                if (client.ThemSinhVien(sinhvien))
                {
                    MessageBox.Show("Thêm sinh viên thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    throw new Exception("Mã sinh viên đã được sử dụng!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog upl = new OpenFileDialog
            {
                Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png)|*.bmp;*.jpg;*.jpeg;*.png"
            };
            if (upl.ShowDialog() == DialogResult.OK)
            {
                string pat = upl.FileName;

                ptbAvatar.Image = Image.FromFile(pat);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ptbAvatar.Image = holder;
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
    }
}
