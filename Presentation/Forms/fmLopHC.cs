using Presentation.CrystalReport;
using Presentation.Forms.Add;
using Presentation.Forms.Edit;
using Presentation.SerLopHC;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class fmLopHC : Form
    {
        public fmLopHC()
        {
            InitializeComponent();
        }

        readonly SerLopHCSoapClient client = new SerLopHCSoapClient();
        DTLophanhchinh[] hanhs;
        int iperPage = 16;
        int crPage = 1;

        private void fmLopHC_Load(object sender, EventArgs e)
        {
            lsvLopHC.Columns.Clear();
            lsvLopHC.Columns.Add("stt", "STT", 48);
            lsvLopHC.Columns.Add("mal", "Mã lớp", 128);
            lsvLopHC.Columns.Add("tenl", "Tên lớp", 280);
            lsvLopHC.Columns.Add("mag", "Mã giảng viên", 0);
            lsvLopHC.Columns.Add("teng", "Tên giảng viên", 218);
            lsvLopHC.Columns.Add("mak", "Mã khoa", 0);
            lsvLopHC.Columns.Add("tenk", "Tên khoa", 0);
            lsvLopHC.Columns.Add("nam", "Năm nhập học", 128);

            hanhs = client.GetAllLHC();
            DisplayData(crPage);
        }

        void DisplayData(int crp)
        {
            lsvLopHC.Items.Clear();
            int staInd = (crp - 1) * iperPage;
            int endInd = Math.Min(staInd + iperPage - 1, hanhs.Length - 1);

            int totalPages = (int)Math.Ceiling((double)hanhs.Length / iperPage);
            lblcrPage.Text = crPage.ToString();
            lblTotal.Text = totalPages.ToString();

            for (int i = staInd; i <= endInd; i++)
            {
                DTLophanhchinh hanh = hanhs[i];
                ListViewItem lvi = new ListViewItem((i + 1).ToString());
                lvi.SubItems.Add(hanh.MaLopHanhChinh);
                lvi.SubItems.Add(hanh.TenLopHanhChinh);
                lvi.SubItems.Add(hanh.MaGiangVien);
                lvi.SubItems.Add(hanh.TenGiangVien);
                lvi.SubItems.Add(hanh.MaKhoa);
                lvi.SubItems.Add(hanh.TenKhoa);
                lvi.SubItems.Add(hanh.NamNhapHoc.ToString());
                lsvLopHC.Items.Add(lvi);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (User.Role == 1)
            {
                if (new fmAddLopHC().ShowDialog() == DialogResult.OK)
                {
                    hanhs = client.GetAllLHC();
                    DisplayData(crPage);
                }
            }
            else
            {
                MessageBox.Show("Yêu cầu bị từ chối!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsvLopHC_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem item = lsvLopHC.SelectedItems[0];
            DTLophanhchinh loph = new DTLophanhchinh
            {
                MaLopHanhChinh = item.SubItems[1].Text,
                TenLopHanhChinh = item.SubItems[2].Text,
                MaGiangVien = item.SubItems[3].Text,
                TenGiangVien = item.SubItems[4].Text,
                MaKhoa = item.SubItems[5].Text,
                TenKhoa = item.SubItems[6].Text,
                NamNhapHoc = int.Parse(item.SubItems[7].Text)
            };

            if (User.Role == 1)
            {
                if (new fmEditLopHC(loph).ShowDialog() == DialogResult.OK)
                {
                    hanhs = client.GetAllLHC();
                    DisplayData(crPage);
                }
            }
            else if (User.Role == 0)
            {
                MessageBox.Show(loph.MaLopHanhChinh + " | " + loph.TenLopHanhChinh + " | " + loph.TenGiangVien, "Thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        DataTable ToDataTable(DTLophanhchinh[] lhcs)
        {
            DataTable dt = new DataTable { TableName = "lopHC" };
            if (lhcs != null)
            {
                dt.Columns.Add("mal", typeof(string));
                dt.Columns.Add("tenl", typeof(string));
                dt.Columns.Add("mag", typeof(string));
                dt.Columns.Add("teng", typeof(string));
                dt.Columns.Add("mak", typeof(string));
                dt.Columns.Add("tenk", typeof(string));
                dt.Columns.Add("nam", typeof(string));

                foreach (var lop in lhcs)
                {
                    DataRow dr = dt.NewRow();
                    dr["mal"] = lop.MaLopHanhChinh;
                    dr["tenl"] = lop.TenLopHanhChinh;
                    dr["mag"] = lop.MaGiangVien;
                    dr["teng"] = lop.TenGiangVien;
                    dr["mak"] = lop.MaKhoa;
                    dr["tenk"] = lop.TenKhoa;
                    dr["nam"] = lop.NamNhapHoc;
                    dt.Rows.Add(dr);
                }
            }
            return dt;
        }

        private void btnPrin_Click(object sender, EventArgs e)
        {
            DataTable dataTable = ToDataTable(hanhs);
            new fmReport(dataTable).Show();
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if (crPage > 1) { crPage--; DisplayData(crPage); }
        }

        private void btnNex_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)hanhs.Length / iperPage);
            if (crPage < totalPages) { crPage++; DisplayData(crPage); }
        }

        private void fmLopHC_SizeChanged(object sender, EventArgs e)
        {
            if (Width > 808)
            {
                lsvLopHC.Height = 740;
                pnlPages.Location = new Point(726, 168);
                iperPage = 32;

                lsvLopHC.Columns["mag"].Width = 128;
                lsvLopHC.Columns["mak"].Width = 128;
                lsvLopHC.Columns["tenk"].Width = 280;
            }
            else
            {
                lsvLopHC.Height = 414;
                pnlPages.Location = new Point(320, 162);
                iperPage = 16;

                lsvLopHC.Columns["mag"].Width = 0;
                lsvLopHC.Columns["mak"].Width = 0;
                lsvLopHC.Columns["tenk"].Width = 0;
            }
            DisplayData(crPage);
        }
    }
}
