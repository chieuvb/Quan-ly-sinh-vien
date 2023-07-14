using Presentation.CrystalReport;
using Presentation.Forms.Add;
using Presentation.Forms.Edit;
using Presentation.SerSinhvien;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class fmSinhvien : Form
    {
        public fmSinhvien()
        {
            InitializeComponent();
        }

        readonly SerSinhvienSoapClient client = new SerSinhvienSoapClient();
        DTSinhvien[] sinhViens;
        int iperPage = 16;
        int crPage = 1;
        readonly ImageList large = new ImageList
        {
            ImageSize = new Size(103, 140)
        };

        private void fmSinhVien_Load(object sender, EventArgs e)
        {
            Addcolumns();
            LoadComboBox();
            LoadData();
            pnlSort.Visible = false;
            pnlSearch.Visible = false;

            lsvSinhvien.LargeImageList = large;
            pBar.Visible = false;
        }

        private void fmSinhVien_SizeChanged(object sender, EventArgs e)
        {
            lsvSinhvien.View = View.Details;
            if (Width > 808)
            {
                lsvSinhvien.Height = 740;
                lsvSinhvien.Columns["masv"].Width = 128;
                lsvSinhvien.Columns["tens"].Width = 180;
                lsvSinhvien.Columns["gioi"].Width = 90;
                lsvSinhvien.Columns["diac"].Width = 384;
                lsvSinhvien.Columns["emai"].Width = 200;
                lsvSinhvien.Columns["malo"].Width = 128;
                lsvSinhvien.Columns["tenl"].Width = 200;
                iperPage = 32;
                pnlPages.Location = new Point(726, 168);
                pBar.Size = new Size(480, 32);
                pBar.Location = new Point(570, 480);
            }
            else
            {
                lsvSinhvien.Height = 414;
                lsvSinhvien.Columns["masv"].Width = 0;
                lsvSinhvien.Columns["tens"].Width = 162;
                lsvSinhvien.Columns["gioi"].Width = 80;
                lsvSinhvien.Columns["diac"].Width = 256;
                lsvSinhvien.Columns["emai"].Width = 0;
                lsvSinhvien.Columns["malo"].Width = 0;
                lsvSinhvien.Columns["tenl"].Width = 0;
                iperPage = 16;
                pnlPages.Location = new Point(320, 162);
                pBar.Size = new Size(256, 16);
                pBar.Location = new Point(276, 276);
            }
            DisplayPage(crPage);
        }

        void Addcolumns()
        {
            lsvSinhvien.Columns.Clear();
            lsvSinhvien.Columns.Add("stt", "STT", 48);
            lsvSinhvien.Columns.Add("masv", "Mã sinh viên", 0);
            lsvSinhvien.Columns.Add("tens", "Tên sinh viên", 162);
            lsvSinhvien.Columns.Add("gioi", "Giới tính", 80);
            lsvSinhvien.Columns.Add("ngay", "Ngày sinh", 128);
            lsvSinhvien.Columns.Add("diac", "Địa chỉ", 256);
            lsvSinhvien.Columns.Add("dien", "Số điện thoại", 128);
            lsvSinhvien.Columns.Add("emai", "Email", 0);
            lsvSinhvien.Columns.Add("malo", "Mã lớp", 0);
            lsvSinhvien.Columns.Add("tenl", "Tên lớp", 0);
        }

        void LoadComboBox()
        {
            cbbLopHC.Items.Add("-- Tất cả --");
            cbbDiachi.Items.Add("-- Tất cả --");
            cbbDiachi.Sorted = true;
            foreach (var tinh in client.GetTinhThanh())
            {
                cbbDiachi.Items.Add(tinh[1]);
            }
            if (User.Role == 0)
            {
                foreach (var lop in client.GetAllLopHC())
                {
                    if (User.Username == lop.MaGiangVien)
                    {
                        cbbLopHC.Items.Add(lop.MaLopHanhChinh + " | " + lop.TenLopHanhChinh + " | " + lop.TenGiangVien);
                        break;
                    }
                }
                if (cbbLopHC.Items.Count > 1)
                {
                    cbbLopHC.SelectedIndex = 1;
                }
                lblLHP.Visible = false;
                cbbLopHC.Enabled = false;
            }
            else if (User.Role == 1)
            {
                foreach (var item in client.GetAllLopHC())
                {
                    cbbLopHC.Items.Add(item.MaLopHanhChinh + " | " + item.TenLopHanhChinh + " | " + item.TenGiangVien);
                }
                cbbLopHC.SelectedIndex = 0;
            }
            cbbDiachi.SelectedIndex = 0;
            cbbGend.SelectedIndex = 0;
        }

        void LoadData()
        {
            if (User.Role == 0)
            {
                sinhViens = client.GetSinhVienLHC(User.Username);
            }
            else if (User.Role == 1)
            {
                sinhViens = client.GetAllSinhVien();
            }
            DisplayPage(crPage);
        }

        void DisplayPage(int page)
        {
            lsvSinhvien.Items.Clear();
            int staInd = (page - 1) * iperPage;
            int endInd = Math.Min(staInd + iperPage - 1, sinhViens.Length - 1);
            int totalPages = (int)Math.Ceiling((double)sinhViens.Length / iperPage);
            lblcrPage.Text = crPage.ToString();
            lblTotal.Text = totalPages.ToString();

            for (int i = staInd; i <= endInd; i++)
            {
                DTSinhvien sin = sinhViens[i];

                ListViewItem lvi = new ListViewItem((i + 1).ToString(), i);
                lvi.SubItems.Add(sin.MaSinhVien);
                lvi.SubItems.Add(sin.TenSinhVien);
                lvi.SubItems.Add(sin.GioiTinh ? "Nam" : "Nữ");
                lvi.SubItems.Add(sin.NgaySinh.ToString("dd-MM-yyyy"));
                lvi.SubItems.Add(sin.DiaChi);
                lvi.SubItems.Add(sin.DienThoai);
                lvi.SubItems.Add(sin.Email);
                lvi.SubItems.Add(sin.MaLopHanhChinh);
                lvi.SubItems.Add(sin.TenLopHanhChinh);

                lsvSinhvien.Items.Add(lvi);
            }
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if (crPage > 1)
            {
                crPage--;
                DisplayPage(crPage);
            }
        }

        private void btnNex_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)sinhViens.Length / iperPage);
            if (crPage < totalPages)
            {
                crPage++;
                DisplayPage(crPage);
            }
        }

        private void cbbLopHC_SelectedIndexChanged(object sender, EventArgs e)
        {
            crPage = 1;
            string lop = cbbLopHC.SelectedIndex > 0 ? cbbLopHC.Text.Split('|').First().Trim() : null;

            if (cbbLopHC.SelectedIndex == 0)
                sinhViens = client.GetAllSinhVien();
            else
                sinhViens = client.SortSinhVien(lop, null, null);

            DisplayPage(crPage);
            cbbDiachi.SelectedIndex = 0;
            cbbGend.SelectedIndex = 0;
        }

        private void cbbDiachi_SelectedIndexChanged(object sender, EventArgs e)
        {
            crPage = 1;
            string lop = cbbLopHC.SelectedIndex > 0 ? cbbLopHC.Text.Split('|').First().Trim() : null;
            string dia = cbbDiachi.SelectedIndex > 0 ? cbbDiachi.Text.Trim() : null;

            if (cbbLopHC.SelectedIndex == 0 && cbbDiachi.SelectedIndex == 0)
                LoadData();
            else
                sinhViens = client.SortSinhVien(lop, dia, null);

            DisplayPage(crPage);
            cbbGend.SelectedIndex = 0;
        }

        private void cbbGend_SelectedIndexChanged(object sender, EventArgs e)
        {
            crPage = 1;
            string lop = cbbLopHC.Text.Split('|').First().Trim();
            string dia = cbbDiachi.Text.Trim();
            string gio = null;

            if (cbbGend.SelectedIndex == 1)
                gio = "1";
            else if (cbbGend.SelectedIndex == 2)
                gio = "0";

            if (cbbLopHC.SelectedIndex == 0 && cbbDiachi.SelectedIndex == 0 && cbbGend.SelectedIndex == 0)
                sinhViens = client.GetAllSinhVien();
            else
                sinhViens = client.SortSinhVien(cbbLopHC.SelectedIndex > 0 ? lop : null, cbbDiachi.SelectedIndex > 0 ? dia : null, gio);

            DisplayPage(crPage);
        }

        DataTable ToDataTable(DTSinhvien[] sinhViens)
        {
            DataTable dataTable = new DataTable { TableName = "sinhVien" };
            if (sinhViens != null)
            {
                dataTable.Columns.Add("masv", typeof(string));
                dataTable.Columns.Add("tens", typeof(string));
                dataTable.Columns.Add("gioi", typeof(string));
                dataTable.Columns.Add("ngay", typeof(DateTime));
                dataTable.Columns.Add("diac", typeof(string));
                dataTable.Columns.Add("dien", typeof(string));
                dataTable.Columns.Add("emai", typeof(string));
                dataTable.Columns.Add("malo", typeof(string));
                dataTable.Columns.Add("tenl", typeof(string));

                foreach (var sin in sinhViens)
                {
                    DataRow row = dataTable.NewRow();
                    row["masv"] = sin.MaSinhVien;
                    row["tens"] = sin.TenSinhVien;
                    row["gioi"] = sin.GioiTinh ? "Nam" : "Nữ";
                    row["ngay"] = sin.NgaySinh;
                    row["diac"] = sin.DiaChi;
                    row["dien"] = sin.DienThoai;
                    row["emai"] = sin.Email;
                    row["malo"] = sin.MaLopHanhChinh;
                    row["tenl"] = sin.TenLopHanhChinh;
                    dataTable.Rows.Add(row);
                }
            }
            return dataTable;
        }

        private void btnPrin_Click(object sender, EventArgs e)
        {
            DataTable dataTable = ToDataTable(sinhViens);
            new fmReport(dataTable).Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            crPage = 1;
            if (User.Role == 1)
            {
                var sin = client.GetAllSinhVien();
                string msv = sin.Max(s => s.MaSinhVien);

                if (new fmAddSinh(msv).ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                    LoadAnh();
                }
            }
            else
                MessageBox.Show("Yêu cầu bị từ chối!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void lsvSinhvien_ItemActivate(object sender, EventArgs e)
        {
            crPage = 1;
            ListViewItem item = lsvSinhvien.SelectedItems[0];

            DTSinhvien sinhVien = new DTSinhvien
            {
                MaSinhVien = item.SubItems[1].Text,
                TenSinhVien = item.SubItems[2].Text,
                GioiTinh = item.SubItems[3].Text == "Nam",
                NgaySinh = DateTime.Parse(item.SubItems[4].Text),
                DiaChi = item.SubItems[5].Text,
                DienThoai = item.SubItems[6].Text,
                Email = item.SubItems[7].Text,
                MaLopHanhChinh = item.SubItems[8].Text,
                TenLopHanhChinh = item.SubItems[9].Text,
            };

            if (User.Role == 1)
            {
                if (new fmEditSinh(sinhVien).ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                    LoadAnh();
                }
            }
            else
            {
                MessageBox.Show(sinhVien.MaSinhVien + " | " + sinhVien.HoDem + " " + sinhVien.TenSinhVien + " | " + sinhVien.NgaySinh.ToString("dd-MM-yyyy") + " | " + sinhVien.TenLopHanhChinh,
                    "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxSearch.Text))
                sinhViens = client.SearchSinhVien(tbxSearch.Text.Trim());
            else
                sinhViens = client.GetAllSinhVien();

            DisplayPage(crPage);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (User.Role == 1)
                cbbLopHC.SelectedIndex = 0;

            if (pnlSort.Visible)
                pnlSort.Visible = false;
            else
            {
                pnlSort.Visible = true;
                pnlSearch.Visible = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            tbxSearch.Clear();
            if (pnlSearch.Visible)
                pnlSearch.Visible = false;
            else
            {
                pnlSearch.Visible = true;
                pnlSort.Visible = false;
            }
        }

        private void tsmiDetails_Click(object sender, EventArgs e)
        {
            lsvSinhvien.View = View.Details;
            iperPage = Width > 808 ? 32 : 16;
            crPage = 1;
            DisplayPage(crPage);
        }

        void LoadAnh()
        {
            large.Images.Clear();
            pBar.Value = 0;
            pBar.Visible = true;

            for (int i = 0; i < sinhViens.Length; i++)
            {
                if (client.GetAnhSinhVien(sinhViens[i].MaSinhVien) != null)
                {
                    using (MemoryStream ms = new MemoryStream(client.GetAnhSinhVien(sinhViens[i].MaSinhVien)))
                    {
                        large.Images.Add(Image.FromStream(ms));
                    }
                }
                else
                {
                    large.Images.Add(Properties.Resources.holder);
                }

                pBar.PerformStep();
            }

            pBar.Visible = false;
        }

        private void tsmiLarge_Click(object sender, EventArgs e)
        {
            lsvSinhvien.View = View.LargeIcon;
            iperPage = Width > 808 ? 44 : 10;
            crPage = 1;
            DisplayPage(crPage);

            if (large.Images.Count < sinhViens.Length)
            {
                LoadAnh();
            }
        }
    }
}
