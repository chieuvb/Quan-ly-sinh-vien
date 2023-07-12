using Presentation.CrystalReport;
using Presentation.Forms.Add;
using Presentation.Forms.Edit;
using Presentation.SerMonhoc;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class fmMonhoc : Form
    {
        public fmMonhoc()
        {
            InitializeComponent();
        }

        readonly SerMonhocSoapClient client = new SerMonhocSoapClient();
        DTMonhoc[] mons;
        int iperPage = 16;
        int crPage = 1;

        private void fmMonhoc_Load(object sender, EventArgs e)
        {
            lsvMonhoc.Columns.Clear();
            lsvMonhoc.Columns.Add("stt", "STT", 48);
            lsvMonhoc.Columns.Add("mam", "Mã môn", 0);
            lsvMonhoc.Columns.Add("ten", "Tên môn", 300);
            lsvMonhoc.Columns.Add("tin", "Số tín chỉ", 154);
            lsvMonhoc.Columns.Add("mak", "Mã khoa", 0);
            lsvMonhoc.Columns.Add("tek", "Khoa", 300);

            mons = client.GetAllMonHoc();
            DisplayData(crPage);
        }

        void DisplayData(int crp)
        {
            lsvMonhoc.Items.Clear();
            int staInd = (crp - 1) * iperPage;
            int endInd = Math.Min(staInd + iperPage - 1, mons.Length - 1);

            int totalPages = (int)Math.Ceiling((double)mons.Length / iperPage);
            lblcrPage.Text = crPage.ToString();
            lblTotal.Text = totalPages.ToString();

            for (int i = staInd; i <= endInd; i++)
            {
                DTMonhoc mon = mons[i];
                ListViewItem lvi = new ListViewItem((i + 1).ToString());
                lvi.SubItems.Add(mon.MaMon);
                lvi.SubItems.Add(mon.TenMon);
                lvi.SubItems.Add(mon.SoTinChi.ToString());
                lvi.SubItems.Add(mon.MaKhoa);
                lvi.SubItems.Add(mon.TenKhoa);
                lsvMonhoc.Items.Add(lvi);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (User.Role == 1)
            {
                if (new fmAddMon().ShowDialog() == DialogResult.OK)
                {
                    mons = client.GetAllMonHoc();
                    DisplayData(crPage);
                }
            }
            else
            {
                MessageBox.Show("Yêu cầu bị từ chối!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsvMonhoc_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem item = lsvMonhoc.SelectedItems[0];
            DTMonhoc mon = new DTMonhoc
            {
                MaMon = item.SubItems[1].Text,
                TenMon = item.SubItems[2].Text,
                SoTinChi = byte.Parse(item.SubItems[3].Text),
                MaKhoa = item.SubItems[4].Text,
                TenKhoa = item.SubItems[5].Text
            };

            if (User.Role == 1)
            {
                if (new fmEditMon(mon).ShowDialog() == DialogResult.OK)
                {
                    mons = client.GetAllMonHoc();
                    DisplayData(crPage);
                }
            }
            else if (User.Role == 0)
            {
                MessageBox.Show(mon.MaMon + " | " + mon.TenMon,
                    "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        DataTable ToDataTable(DTMonhoc[] mon)
        {
            DataTable dt = new DataTable { TableName = "monHoc" };
            if (mon != null)
            {
                dt.Columns.Add("mam", typeof(string));
                dt.Columns.Add("ten", typeof(string));
                dt.Columns.Add("tin", typeof(string));
                dt.Columns.Add("mak", typeof(string));
                dt.Columns.Add("tek", typeof(string));

                foreach (var mo in mon)
                {
                    DataRow dr = dt.NewRow();
                    dr["mam"] = mo.MaMon;
                    dr["ten"] = mo.TenMon;
                    dr["tin"] = mo.SoTinChi;
                    dr["mak"] = mo.MaKhoa;
                    dr["tek"] = mo.TenKhoa;
                    dt.Rows.Add(dr);
                }
            }
            return dt;
        }

        private void btnPrin_Click(object sender, EventArgs e)
        {
            DataTable dataTable = ToDataTable(mons);
            new fmReport(dataTable).Show();
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if (crPage > 1)
            {
                crPage--;
                DisplayData(crPage);
            }
        }

        private void btnNex_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)mons.Length / iperPage);
            if (crPage < totalPages)
            {
                crPage++;
                DisplayData(crPage);
            }
        }

        private void fmMonhoc_SizeChanged(object sender, EventArgs e)
        {
            if (Width > 808)
            {
                lsvMonhoc.Height = 740;
                lsvMonhoc.Columns["mam"].Width = 128;
                lsvMonhoc.Columns["mak"].Width = 128;
                pnlPages.Location = new Point(726, 168);
                iperPage = 32;
            }
            else
            {
                lsvMonhoc.Height = 414;
                lsvMonhoc.Columns["mam"].Width = 0;
                lsvMonhoc.Columns["mak"].Width = 0;
                pnlPages.Location = new Point(320, 162);
                iperPage = 16;
            }
        }
    }
}
