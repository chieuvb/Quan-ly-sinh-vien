using Presentation.SerLopHC;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation.Forms.Add
{
    public partial class fmAddLopHC : Form
    {
        public fmAddLopHC()
        {
            InitializeComponent();
        }

        readonly SerLopHCSoapClient client = new SerLopHCSoapClient();

        private void fmAddLopHC_Load(object sender, EventArgs e)
        {
            tbxMa.Text = "-- Mã lớp --";
            tbxTen.Text = "-- Tên lớp --";
            tbxKhoa.ReadOnly = true;
            cbbGiang.Items.Add("-- Giảng viên chủ nhiệm --");
            tbxMa.ForeColor = Color.DimGray;
            tbxTen.ForeColor = Color.DimGray;
            cbbGiang.SelectedIndex = 0;
            nudNam.Value = DateTime.Now.Year;

            foreach (var item in client.GetGVCN())
            {
                string hv;
                switch (item.HocVi)
                {
                    case "Thạc sĩ":
                        hv = "ThS. ";
                        break;
                    case "Tiến sĩ":
                        hv = "TS. ";
                        break;
                    default:
                        hv = null;
                        break;
                }
                cbbGiang.Items.Add(item.MaGiangVien + " | " + hv + item.HoDem + " " + item.TenGiangVien);
            }
        }

        private void tbxMa_Enter(object sender, EventArgs e)
        {
            if (tbxMa.Text == "-- Mã lớp --")
            {
                tbxMa.Clear(); tbxMa.ForeColor = Color.Black;
            }
        }

        private void tbxMa_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxMa.Text))
            {
                tbxMa.Text = "-- Mã lớp --";
                tbxMa.ForeColor = Color.DimGray;
            }
        }

        private void tbxTen_Enter(object sender, EventArgs e)
        {
            if (tbxTen.Text == "-- Tên lớp --")
            {
                tbxTen.Clear(); tbxTen.ForeColor = Color.Black;
            }
        }

        private void tbxTen_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxTen.Text))
            {
                tbxTen.Text = "-- Tên lớp --";
                tbxMa.ForeColor = Color.DimGray;
            }
        }

        private void cbbGiang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbGiang.SelectedIndex == 0)
            {
                tbxKhoa.Clear();
            }
            else
            {
                foreach (var item in client.GetGVCN())
                {
                    if (cbbGiang.Text.Split(' ')[0] == item.MaGiangVien)
                    {
                        tbxKhoa.Text = item.TenKhoa; break;
                    }
                }
            }
        }

        void CheckValid(DTLophanhchinh lop)
        {
            if (lop.MaLopHanhChinh.Contains("--"))
            {
                throw new Exception("Mã lớp không hợp lệ!");
            }
            else if (lop.TenLopHanhChinh.Contains("--"))
            {
                throw new Exception("Tên lớp không hợp lệ!");
            }
            else if (lop.MaGiangVien.Contains("--"))
            {
                throw new Exception("Vui lòng chọn giảng viên!");
            }
            else if (lop.MaKhoa == null)
            {
                throw new Exception("Mã khoa không hợp lệ!");
            }
            else if (lop.NamNhapHoc >= DateTime.Now.Year)
            {
                throw new Exception("Năm nhập học không hợp lệ!");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string khoa = null;
                foreach (var item in client.GetGVCN())
                {
                    if (tbxKhoa.Text == item.TenKhoa)
                    {
                        khoa = item.MaKhoa; break;
                    }
                }

                DTLophanhchinh lophc = new DTLophanhchinh
                {
                    MaLopHanhChinh = tbxMa.Text.Trim().ToUpper(),
                    TenLopHanhChinh = tbxTen.Text.Trim(),
                    MaGiangVien = cbbGiang.Text.Split(' ')[0],
                    MaKhoa = khoa,
                    NamNhapHoc = (int)nudNam.Value
                };

                CheckValid(lophc);

                if (client.AddLHC(lophc))
                {
                    MessageBox.Show("Mở lớp hành chính thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
