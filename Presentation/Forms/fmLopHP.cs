using Presentation.CrystalReport;
using Presentation.Forms.Add;
using Presentation.Forms.Edit;
using Presentation.SerLopHP;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class fmLopHP : Form
    {
        public fmLopHP() { InitializeComponent(); }

        readonly SerLopHPSoapClient client = new SerLopHPSoapClient();
        DTLophocphan[] hocs;
        int iperPage = 16;
        int crPage = 1;

        private void fmLopHP_Load(object sender, EventArgs e)
        {
            lsvLopHP.Columns.Add("stt", "STT", 48);
            lsvLopHP.Columns.Add("mal", "Mã lớp", 0);
            lsvLopHP.Columns.Add("mam", "Mã môn", 0);
            lsvLopHP.Columns.Add("tenm", "Tên môn", 280);
            lsvLopHP.Columns.Add("mag", "Mã GV", 0);
            lsvLopHP.Columns.Add("teng", "Tên GV", 218);
            lsvLopHP.Columns.Add("hoc", "Học kỳ", 128);
            lsvLopHP.Columns.Add("nam", "Năm học", 128);
            lsvLopHP.Columns.Add("mak", "Mã khoa", 0);
            lsvLopHP.Columns.Add("tenk", "Tên khoa", 0);

            ReloadAndShow();
        }

        void ReloadAndShow()
        {
            hocs = client.GetAllLHP();
            DisplayData(crPage);
        }

        void DisplayData(int crp)
        {
            lsvLopHP.Items.Clear();
            int staInd = (crp - 1) * iperPage;
            int endInd = Math.Min(staInd + iperPage - 1, hocs.Length - 1);

            int totalPages = (int)Math.Ceiling((double)hocs.Length / iperPage);
            lblcrPage.Text = crPage.ToString();
            lblTotal.Text = totalPages.ToString();

            for (int i = staInd; i <= endInd; i++)
            {
                DTLophocphan hoc = hocs[i];
                ListViewItem lvi = new ListViewItem((i + 1).ToString());
                lvi.SubItems.Add(hoc.MaLopHocPhan);
                lvi.SubItems.Add(hoc.MaMon);
                lvi.SubItems.Add(hoc.TenMon);
                lvi.SubItems.Add(hoc.MaGiangVien);
                lvi.SubItems.Add(hoc.TenGiangVien);
                lvi.SubItems.Add(hoc.HocKy.ToString());
                lvi.SubItems.Add(hoc.NamHoc);
                lvi.SubItems.Add(hoc.MaKhoa);
                lvi.SubItems.Add(hoc.TenKhoa);
                lsvLopHP.Items.Add(lvi);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (User.Role == 1)
            {
                if (new fmAddLopHP().ShowDialog() == DialogResult.OK)
                {
                    ReloadAndShow();
                }
            }
            else
            {
                MessageBox.Show("Yêu cầu bị từ chối!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsvLopHP_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem item = lsvLopHP.SelectedItems[0];
            DTLophocphan lop = new DTLophocphan
            {
                MaLopHocPhan = item.SubItems[1].Text,
                MaMon = item.SubItems[2].Text,
                TenMon = item.SubItems[3].Text,
                MaGiangVien = item.SubItems[4].Text,
                TenGiangVien = item.SubItems[5].Text,
                HocKy = byte.Parse(item.SubItems[6].Text),
                NamHoc = item.SubItems[7].Text,
                MaKhoa = item.SubItems[8].Text,
                TenKhoa = item.SubItems[9].Text
            };

            if (User.Role == 1)
            {
                if (new fmEditLopHP(lop).ShowDialog() == DialogResult.OK)
                {
                    ReloadAndShow();
                }
            }
            else if (User.Role == 0)
            {
                MessageBox.Show(lop.MaLopHocPhan + " | " + lop.TenMon + " | " + lop.TenGiangVien, "Thông tin",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        DataTable ToDataTable(DTLophocphan[] lhps)
        {
            DataTable dt = new DataTable { TableName = "lopHP" };
            if (lhps != null)
            {
                dt.Columns.Add("mal", typeof(string));
                dt.Columns.Add("mam", typeof(string));
                dt.Columns.Add("tenm", typeof(string));
                dt.Columns.Add("mag", typeof(string));
                dt.Columns.Add("teng", typeof(string));
                dt.Columns.Add("hoc", typeof(string));
                dt.Columns.Add("nam", typeof(string));
                dt.Columns.Add("mak", typeof(string));
                dt.Columns.Add("tenk", typeof(string));

                foreach (var lop in lhps)
                {
                    DataRow dr = dt.NewRow();
                    dr["mal"] = lop.MaLopHocPhan;
                    dr["mam"] = lop.MaMon;
                    dr["tenm"] = lop.TenMon;
                    dr["mag"] = lop.MaGiangVien;
                    dr["teng"] = lop.TenGiangVien;
                    dr["hoc"] = lop.HocKy;
                    dr["nam"] = lop.NamHoc;
                    dr["mak"] = lop.MaKhoa;
                    dr["tenk"] = lop.TenKhoa;
                    dt.Rows.Add(dr);
                }
            }
            return dt;
        }

        private void btnPrin_Click(object sender, EventArgs e)
        {
            DataTable dataTable = ToDataTable(hocs);
            new fmReport(dataTable).Show();
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if (crPage > 1) { crPage--; DisplayData(crPage); }
        }

        private void btnNex_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)hocs.Length / iperPage);
            if (crPage < totalPages)
            {
                crPage++; DisplayData(crPage);
            }
        }

        private void fmLopHP_SizeChanged(object sender, EventArgs e)
        {
            if (Width > 808)
            {
                lsvLopHP.Height = 740;
                pnlPages.Location = new Point(726, 168);
                iperPage = 32;

                lsvLopHP.Columns["mal"].Width = 128;
                lsvLopHP.Columns["mam"].Width = 128;
                lsvLopHP.Columns["mag"].Width = 128;
                lsvLopHP.Columns["mak"].Width = 128;
                lsvLopHP.Columns["tenk"].Width = 300;
            }
            else
            {
                lsvLopHP.Height = 414;
                pnlPages.Location = new Point(320, 162);
                iperPage = 16;

                lsvLopHP.Columns["mal"].Width = 0;
                lsvLopHP.Columns["mam"].Width = 0;
                lsvLopHP.Columns["mag"].Width = 0;
                lsvLopHP.Columns["mak"].Width = 0;
                lsvLopHP.Columns["tenk"].Width = 0;
            }
            DisplayData(crPage);
        }
    }
}
