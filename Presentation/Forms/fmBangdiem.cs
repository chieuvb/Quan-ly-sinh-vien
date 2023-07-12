using Presentation.CrystalReport;
using Presentation.Forms.Add;
using Presentation.Forms.Edit;
using Presentation.SerDiem;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class fmBangdiem : Form
    {
        public fmBangdiem()
        {
            InitializeComponent();
        }

        readonly SerDiemSoapClient client = new SerDiemSoapClient();
        List<DTDiem> diems;
        int iperPage = 16;
        int crPage = 1;

        private void fmBangDiem_Load(object sender, EventArgs e)
        {
            AddColumn();
            LoadData();
            DisplayPage(crPage);
        }

        private List<DTDiem> ToListD(DTDiem[] die)
        {
            var res = new List<DTDiem>();
            for (int i = 0; i < die.Length; i++)
            {
                res.Add(die[i]);
            }
            return res;
        }

        private List<DTLophocphan> ToListP(DTLophocphan[] hp)
        {
            var res = new List<DTLophocphan>();
            for (int i = 0; i < hp.Length; i++)
            {
                res.Add(hp[i]);
            }
            return res;
        }

        private void fmBangDiem_SizeChanged(object sender, EventArgs e)
        {
            if (Width > 808)
            {
                lsvDiem.Height = 740;
                iperPage = 32;
                pnlPages.Location = new Point(726, 168);

                lsvDiem.Columns["maLHP"].Width = 180;
                lsvDiem.Columns["tenLHP"].Width = 280;
                lsvDiem.Columns["maSV"].Width = 180;
                lsvDiem.Columns["tenSV"].Width = 280;
                lsvDiem.Columns["diemCC"].Width = 128;
                lsvDiem.Columns["diemGK"].Width = 128;
                lsvDiem.Columns["diemKT"].Width = 128;
                lsvDiem.Columns["diemTB"].Width = 128;
            }
            else
            {
                lsvDiem.Height = 414;
                iperPage = 16;
                pnlPages.Location = new Point(320, 162);

                lsvDiem.Columns["maLHP"].Width = 0;
                lsvDiem.Columns["tenLHP"].Width = 236;
                lsvDiem.Columns["maSV"].Width = 0;
                lsvDiem.Columns["tenSV"].Width = 158;
                lsvDiem.Columns["diemCC"].Width = 96;
                lsvDiem.Columns["diemGK"].Width = 84;
                lsvDiem.Columns["diemKT"].Width = 90;
                lsvDiem.Columns["diemTB"].Width = 90;
            }
            DisplayPage(crPage);
        }

        void AddColumn()
        {
            lsvDiem.Columns.Add("stt", "STT", 48);
            lsvDiem.Columns.Add("maLHP", "Mã lớp học phần", 0);
            lsvDiem.Columns.Add("tenLHP", "Lớp học phần", 236);
            lsvDiem.Columns.Add("maSV", "Mã sinh viên", 0);
            lsvDiem.Columns.Add("tenSV", "Sinh viên", 158);
            lsvDiem.Columns.Add("diemCC", "Chuyên cần", 96);
            lsvDiem.Columns.Add("diemGK", "Giữa kỳ", 84);
            lsvDiem.Columns.Add("diemKT", "Kết thúc", 90);
            lsvDiem.Columns.Add("diemTB", "Trung bình", 90);
        }

        void LoadData()
        {
            cbbLocmon.Items.Clear();
            cbbLocmon.Items.Add("-- Tất cả --");
            if (User.Role == 0)
            {
                diems = ToListD(client.GetAllDiemByGV(User.Username));
                foreach (var lop in ToListP(client.GetLopHP()))
                {
                    if (User.Username == lop.MaGiangVien)
                    {
                        cbbLocmon.Items.Add(lop.MaLopHocPhan + " | " + lop.TenMon + " | " + lop.TenGiangVien); 
                        break;
                    }
                }
                if (cbbLocmon.Items.Count > 1)
                {
                    cbbLocmon.SelectedIndex = 1;
                }
                lblSort.Visible = false;
                cbbLocmon.Enabled = false;
            }
            else
            {
                diems = ToListD(client.GetAllDiem());
                foreach (var item in ToListP(client.GetLopHP()))
                {
                    cbbLocmon.Items.Add(item.MaLopHocPhan + " | " + item.TenMon + " | " + item.TenGiangVien);
                }
                cbbLocmon.SelectedIndex = 0;
            }
        }

        void DisplayPage(int page)
        {
            lsvDiem.Items.Clear();
            int startInd = (page - 1) * iperPage;
            int endInd = Math.Min(startInd + iperPage - 1, diems.Count - 1);
            int totalPages = (int)Math.Ceiling((double)diems.Count / iperPage);
            lblcrPage.Text = crPage.ToString();
            lblTotal.Text = totalPages.ToString();

            for (int i = startInd; i <= endInd; i++)
            {
                DTDiem diem = diems[i];

                ListViewItem lvi = new ListViewItem((i + 1).ToString());
                lvi.SubItems.Add(diem.MaLopHocPhan);
                lvi.SubItems.Add(diem.TenLopHocPhan);
                lvi.SubItems.Add(diem.MaSinhVien);
                lvi.SubItems.Add(diem.TenSinhVien);
                lvi.SubItems.Add(diem.DiemChuyenCan.ToString());
                lvi.SubItems.Add(diem.DiemGiuaKy.ToString());
                lvi.SubItems.Add(diem.DiemThi.ToString());
                lvi.SubItems.Add(diem.DiemTrungBinh.ToString());

                lsvDiem.Items.Add(lvi);
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
            int totalPages = (int)Math.Ceiling((double)diems.Count / iperPage);
            if (crPage < totalPages)
            {
                crPage++;
                DisplayPage(crPage);
            }
        }

        DataTable ConvertListToTable(List<DTDiem> diem)
        {
            DataTable dataTable = new DataTable
            {
                TableName = "bangDiem"
            };
            if (diem != null)
            {
                dataTable.Columns.Add("maLHP", typeof(string));
                dataTable.Columns.Add("tenLHP", typeof(string));
                dataTable.Columns.Add("maSV", typeof(string));
                dataTable.Columns.Add("tenSV", typeof(string));
                dataTable.Columns.Add("diemCC", typeof(double));
                dataTable.Columns.Add("diemGK", typeof(double));
                dataTable.Columns.Add("diemKT", typeof(double));
                dataTable.Columns.Add("diemTB", typeof(double));

                foreach (DTDiem die in diems)
                {
                    DataRow row = dataTable.NewRow();
                    row["maLHP"] = die.MaLopHocPhan;
                    row["tenLHP"] = die.TenLopHocPhan;
                    row["maSV"] = die.MaSinhVien;
                    row["tenSV"] = die.TenSinhVien;
                    row["diemCC"] = die.DiemChuyenCan;
                    row["diemGK"] = die.DiemGiuaKy;
                    row["diemKT"] = die.DiemThi;
                    row["diemTB"] = die.DiemTrungBinh;
                    dataTable.Rows.Add(row);
                }
            }
            return dataTable;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            DataTable table = ConvertListToTable(diems);
            new fmReport(table).Show();
        }

        private void lsvDiem_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem item = lsvDiem.SelectedItems[0];
            DTDiem diem = new DTDiem
            {
                MaLopHocPhan = item.SubItems[1].Text,
                TenLopHocPhan = item.SubItems[2].Text,
                MaSinhVien = item.SubItems[3].Text,
                TenSinhVien = item.SubItems[4].Text,
                DiemChuyenCan = double.Parse(item.SubItems[5].Text),
                DiemGiuaKy = double.Parse(item.SubItems[6].Text),
                DiemThi = double.Parse(item.SubItems[7].Text),
                DiemTrungBinh = double.Parse(item.SubItems[8].Text)
            };
            if (User.Role > 1)
            {
                MessageBox.Show(diem.ToString(), "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (new fmEditDiem(diem).ShowDialog() == DialogResult.OK)
            {
                LoadData();
                DisplayPage(crPage);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (new fmAddDiem().ShowDialog() == DialogResult.OK)
            {
                LoadData();
                DisplayPage(crPage);
            }
        }

        private void cbbLocmon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (User.Role == 1)
            {
                if (cbbLocmon.SelectedIndex > 0)
                {
                    string selectedMalop = cbbLocmon.Text.Split('|')[0].Trim();
                    string maGV = "";
                    foreach (var lop in client.GetLopHP())
                    {
                        if (selectedMalop == lop.MaLopHocPhan)
                        {
                            maGV = lop.MaGiangVien; 
                            break;
                        }
                    }
                    diems = ToListD(client.GetAllDiemByGV(maGV));
                    DisplayPage(crPage);
                }
                else
                {
                    diems = ToListD(client.GetAllDiem());
                    DisplayPage(crPage);
                }
            }
        }
    }
}
