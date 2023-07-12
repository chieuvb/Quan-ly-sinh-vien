using Presentation.CrystalReport;
using Presentation.Forms.Add;
using Presentation.Forms.Edit;
using Presentation.SerGiangvien;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class fmGiangvien : Form
    {
        public fmGiangvien()
        {
            InitializeComponent();
        }

        readonly SerGiangvienSoapClient client = new SerGiangvienSoapClient();
        DTGiangvien[] giangViens;
        int iperPage = 16;
        int crPage = 1;

        private void fmGiangvien_Load(object sender, EventArgs e)
        {
            AddColumnsTo(lsvGiangvien);
            giangViens = client.GetAllGiangVien();
            DisplayData(crPage, giangViens);
        }

        void AddColumnsTo(ListView lsv)
        {
            lsv.Columns.Clear();
            lsv.Columns.Add("stt", "STT", 48);
            lsv.Columns.Add("magi", "Mã giảng viên", 0);
            lsv.Columns.Add("teng", "Tên giảng viên", 138);
            lsv.Columns.Add("gioi", "Giới tính", 80);
            lsv.Columns.Add("ngay", "Ngày sinh", 128);
            lsv.Columns.Add("diac", "Địa chỉ", 280);
            lsv.Columns.Add("dien", "Điện thoại", 128);
            lsv.Columns.Add("emai", "Email", 0);
            lsv.Columns.Add("hocv", "Học vị", 0);
            lsv.Columns.Add("makh", "Mã khoa", 0);
            lsv.Columns.Add("tenk", "Tên khoa", 0);
        }

        void DisplayData(int crp, DTGiangvien[] gv)
        {
            lsvGiangvien.Items.Clear();
            int staInd = (crp - 1) * iperPage;
            int endInd = Math.Min(staInd + iperPage - 1, gv.Length - 1);
            int totalPages = (int)Math.Ceiling((double)gv.Length / iperPage);
            lblcrPage.Text = crPage.ToString();
            lblTotal.Text = totalPages.ToString();

            for (int i = staInd; i <= endInd; i++)
            {
                DTGiangvien gia = gv[i];

                ListViewItem lvi = new ListViewItem((i + 1).ToString());
                lvi.SubItems.Add(gia.MaGiangVien);
                lvi.SubItems.Add(gia.TenGiangVien);
                lvi.SubItems.Add(gia.GioiTinh ? "Nam" : "Nữ");
                lvi.SubItems.Add(gia.NgaySinh.ToString("dd-MM-yyyy"));
                lvi.SubItems.Add(gia.DiaChi);
                lvi.SubItems.Add(gia.DienThoai);
                lvi.SubItems.Add(gia.Email);
                lvi.SubItems.Add(gia.HocVi);
                lvi.SubItems.Add(gia.MaKhoa);
                lvi.SubItems.Add(gia.TenKhoa);

                lsvGiangvien.Items.Add(lvi);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (User.Role == 1)
            {
                string mgv = client.GetAllGiangVien().ToList().Max(g => g.MaGiangVien);

                if (new fmAddGiang(mgv).ShowDialog() == DialogResult.OK)
                {
                    giangViens = client.GetAllGiangVien();
                    DisplayData(crPage, giangViens);
                }
            }
            else
            {
                MessageBox.Show("Yêu cầu bị từ chối!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrin_Click(object sender, EventArgs e)
        {
            DataTable dataTable = ConvertToList(giangViens);
            new fmReport(dataTable).Show();
        }

        private void fmGiangvien_SizeChanged(object sender, EventArgs e)
        {
            if (Width > 808)
            {
                lsvGiangvien.Height = 740;
                lsvGiangvien.Columns["magi"].Width = 128;
                lsvGiangvien.Columns["teng"].Width = 180;
                lsvGiangvien.Columns["gioi"].Width = 90;
                lsvGiangvien.Columns["diac"].Width = 284;
                lsvGiangvien.Columns["emai"].Width = 180;
                lsvGiangvien.Columns["hocv"].Width = 120;
                lsvGiangvien.Columns["makh"].Width = 128;
                lsvGiangvien.Columns["tenk"].Width = 200;
                pnlPages.Location = new Point(726, 168);
                iperPage = 32;
            }
            else
            {
                lsvGiangvien.Height = 414;
                lsvGiangvien.Columns["magi"].Width = 0;
                lsvGiangvien.Columns["teng"].Width = 138;
                lsvGiangvien.Columns["gioi"].Width = 80;
                lsvGiangvien.Columns["diac"].Width = 280;
                lsvGiangvien.Columns["emai"].Width = 0;
                lsvGiangvien.Columns["hocv"].Width = 0;
                lsvGiangvien.Columns["makh"].Width = 0;
                lsvGiangvien.Columns["tenk"].Width = 0;
                pnlPages.Location = new Point(320, 162);
                iperPage = 16;
            }
            DisplayData(crPage, giangViens);
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if (crPage > 1)
            {
                crPage--;
                DisplayData(crPage, giangViens);
            }
        }

        private void btnNex_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)giangViens.Length / iperPage);
            if (crPage < totalPages)
            {
                crPage++;
                DisplayData(crPage, giangViens);
            }
        }

        private void lsvGiangvien_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem item = lsvGiangvien.SelectedItems[0];
            DTGiangvien gia = new DTGiangvien
            {
                MaGiangVien = item.SubItems[1].Text,
                TenGiangVien = item.SubItems[2].Text,
                GioiTinh = item.SubItems[3].Text == "Nam",
                NgaySinh = DateTime.Parse(item.SubItems[4].Text),
                DiaChi = item.SubItems[5].Text,
                DienThoai = item.SubItems[6].Text,
                Email = item.SubItems[7].Text,
                HocVi = item.SubItems[8].Text,
                MaKhoa = item.SubItems[9].Text
            };
            if (User.Role == 0)
            {
                string hv;
                switch (gia.HocVi)
                {
                    case "Thạc sĩ":
                        hv = "ThS. ";
                        break;
                    case "Tiến sĩ":
                        hv = "TS. ";
                        break;
                    default:
                        hv = "GV.";
                        break;
                }
                MessageBox.Show(gia.MaGiangVien + " | " + hv + gia.HoDem + " " + gia.TenGiangVien, "Thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (User.Role == 1)
            {
                if (new fmEditGiang(gia).ShowDialog() == DialogResult.OK)
                {
                    giangViens = client.GetAllGiangVien();
                    DisplayData(crPage, giangViens);
                }
            }
        }

        DataTable ConvertToList(DTGiangvien[] gvs)
        {
            DataTable dtb = new DataTable
            {
                TableName = "giangVien"
            };
            if (gvs != null)
            {
                dtb.Columns.Add("magi", typeof(string));
                dtb.Columns.Add("teng", typeof(string));
                dtb.Columns.Add("gioi", typeof(string));
                dtb.Columns.Add("ngay", typeof(DateTime));
                dtb.Columns.Add("diac", typeof(string));
                dtb.Columns.Add("dien", typeof(string));
                dtb.Columns.Add("emai", typeof(string));
                dtb.Columns.Add("hocv", typeof(string));
                dtb.Columns.Add("makh", typeof(string));
                dtb.Columns.Add("tenk", typeof(string));

                foreach (var sin in gvs)
                {
                    DataRow row = dtb.NewRow();
                    row["magi"] = sin.MaGiangVien;
                    row["teng"] = sin.TenGiangVien;
                    row["gioi"] = sin.GioiTinh ? "Nam" : "Nữ";
                    row["ngay"] = sin.NgaySinh;
                    row["diac"] = sin.DiaChi;
                    row["dien"] = sin.DienThoai;
                    row["emai"] = sin.Email;
                    row["hocv"] = sin.HocVi;
                    row["makh"] = sin.MaKhoa;
                    row["tenk"] = sin.TenKhoa;
                    dtb.Rows.Add(row);
                }
            }
            return dtb;
        }
    }
}
