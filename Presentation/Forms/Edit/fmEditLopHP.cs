using Presentation.SerLopHP;
using System;
using System.Windows.Forms;

namespace Presentation.Forms.Edit
{
    public partial class fmEditLopHP : Form
    {
        public fmEditLopHP(DTLophocphan lo)
        {
            InitializeComponent();
            lop = lo;
        }

        readonly SerLopHPSoapClient client = new SerLopHPSoapClient();
        readonly DTLophocphan lop;

        private void fmEditLopHP_Load(object sender, EventArgs e)
        {
            int crt = DateTime.Now.Year;
            nudNamT.Maximum = nudNamD.Maximum = crt + 10;
            nudNamT.Minimum = nudNamD.Minimum = crt - 10;

            tbxMa.Text = "Mã lớp: " + lop.MaLopHocPhan;
            tbxKhoa.Text = "Khoa: " + lop.MaKhoa + " | " + lop.TenKhoa;
            tbxMon.Text = "Môn học: " + lop.MaMon + " | " + lop.TenMon;

            cbbGiang.Items.Add("-- Giảng viên --");
            cbbGiang.SelectedIndex = 0;
            foreach (var gv in client.GetGiangVienByKHoa(lop.MaKhoa))
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
            foreach (var item in cbbGiang.Items)
            {
                if (item.ToString().Contains(lop.MaGiangVien))
                {
                    cbbGiang.SelectedItem = item;
                }
            }

            string[] nam = lop.NamHoc.Split('-');
            nudNamT.Value = int.Parse(nam[0].Trim());
            nudNamD.Value = int.Parse(nam[1].Trim());

            nudHoc.Value = lop.HocKy;

            nudHoc.Enabled = true;
            nudNamT.Enabled = true;
            nudNamD.Enabled = true;
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
                    MaLopHocPhan = tbxMa.Text.Split(' ')[2],
                    MaMon = tbxMon.Text.Split(' ')[2],
                    MaGiangVien = cbbGiang.Text.Split('|')[0].Trim(),
                    MaKhoa = tbxKhoa.Text.Split(' ')[1],
                    HocKy = byte.Parse(nudHoc.Value.ToString()),
                    NamHoc = nudNamT.Value.ToString() + " - " + nudNamD.Value.ToString(),
                };

                CheckValid(lop);

                if (client.EditLopHP(lop))
                {
                    MessageBox.Show("Cập nhật lớp học phần thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    throw new Exception("Không tìm thấy mã lớp!");
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
            try
            {
                if (MessageBox.Show("Lớp học phần này sẽ bị hủy và xóa khỏi hệ thống!\nTiếp tục?", "Cảnh báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    == DialogResult.Yes)
                {
                    DTLophocphan lop = new DTLophocphan
                    {
                        MaLopHocPhan = tbxMa.Text.Split(' ')[2],
                        MaMon = tbxMon.Text.Split(' ')[2],
                        MaKhoa = tbxKhoa.Text.Split(' ')[1]
                    };
                    if (client.DeleteLopHP(lop))
                    {
                        MessageBox.Show("Hủy lớp học phần thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nudNamT_ValueChanged(object sender, EventArgs e)
        {
            nudNamD.Value = nudNamT.Value;
        }

        private void nudNamD_ValueChanged(object sender, EventArgs e)
        {
            if (nudNamD.Value < nudNamT.Value)
            {
                nudNamD.Value = nudNamT.Value;
            }
        }
    }
}
