using Presentation.SerLopHP;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Presentation.Forms.Add
{
    public partial class fmAddLopHP : Form
    {
        public fmAddLopHP()
        {
            InitializeComponent();
        }

        readonly SerLopHPSoapClient client = new SerLopHPSoapClient();

        private void fmAddLopHP_Load(object sender, EventArgs e)
        {
            string ma = "LHP" + (int.Parse(client.GetAllLHP().Max(l => l.MaLopHocPhan).Substring(3)) + 1);
            tbxMa.TextAlign = HorizontalAlignment.Center;
            tbxMa.Text = "Mã lớp: " + ma;

            cbbKhoa.Items.Add("-- Khoa --");
            cbbKhoa.SelectedIndex = 0;
            foreach (var khoa in client.GetAllKhoa())
            {
                cbbKhoa.Items.Add(khoa.MaKhoa + " | " + khoa.TenKhoa);
            }

            cbbMon.Items.Add("-- Môn học --");
            cbbMon.SelectedIndex = 0;
            foreach (var mon in client.GetMonHoc())
            {
                cbbMon.Items.Add(mon.MaMon + " | " + mon.TenMon);
            }

            int crt = DateTime.Now.Year;
            nudNamT.Maximum = crt + 10;
            nudNamT.Minimum = crt - 10;
            nudNamD.Maximum = crt + 10;
            nudNamD.Minimum = crt - 10;
            nudNamT.Value = nudNamD.Value = crt;
        }

        private void cbbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mak = cbbKhoa.Text.Split('|')[0].Trim();
            cbbGiang.Items.Clear();
            cbbGiang.Items.Add("-- Giảng viên --");
            cbbGiang.SelectedIndex = 0;
            foreach (var gv in client.GetGiangVienByKHoa(mak))
            {
                string hv;
                switch (gv.HocVi)
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
                cbbGiang.Items.Add(gv.MaGiangVien + " | " + hv + gv.HoDem + " " + gv.TenGiangVien);
            }
        }

        void CheckValid(DTLophocphan lop)
        {
            string[] nam = lop.NamHoc.Split('-');
            if (lop.MaKhoa.Contains("--"))
            {
                throw new Exception("Vui lòng chọn khoa phù hợp!");
            }
            else if (lop.MaGiangVien.Contains("--"))
            {
                throw new Exception("Vui lòng chọn giảng viên phù hợp!");
            }
            else if (lop.MaMon.Contains("--"))
            {
                throw new Exception("Vui lòng chọn môn học phù hợp!");
            }
            else if (int.Parse(nam[1].Trim()) > int.Parse(nam[0].Trim()) + 1)
            {
                throw new Exception("Kỳ học quá dài!");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                DTLophocphan lop = new DTLophocphan
                {
                    MaLopHocPhan = tbxMa.Text.Split(' ')[2].Trim(),
                    MaMon = cbbMon.Text.Split('|')[0].Trim(),
                    MaGiangVien = cbbGiang.Text.Split('|')[0].Trim(),
                    HocKy = byte.Parse(nudHoc.Value.ToString()),
                    NamHoc = nudNamT.Value + " - " + nudNamD.Value,
                    MaKhoa = cbbKhoa.Text.Split('|')[0].Trim()
                };

                CheckValid(lop);

                if (client.AddLopHP(lop))
                {
                    MessageBox.Show("Mở lớp học phần thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    throw new Exception("Mã lớp đã được sử dụng!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
