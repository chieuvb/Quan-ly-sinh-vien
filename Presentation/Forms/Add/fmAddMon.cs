using Presentation.SerMonhoc;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation.Forms.Add
{
    public partial class fmAddMon : Form
    {
        public fmAddMon()
        {
            InitializeComponent();
        }

        readonly SerMonhocSoapClient client = new SerMonhocSoapClient();

        private void fmAddMon_Load(object sender, EventArgs e)
        {
            cbbTin.SelectedIndex = 0;
            cbbKhoa.SelectedIndex = 0;
            tbxMa.Text = "-- Mã môn --";
            tbxMa.ForeColor = Color.DimGray;
            tbxTen.Text = "-- Tên môn học --";
            tbxTen.ForeColor = Color.DimGray;

            foreach (var khoa in client.GetAllKhoa())
            {
                cbbKhoa.Items.Add(khoa.MaKhoa + " | " + khoa.TenKhoa);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var mon = new DTMonhoc
                {
                    MaMon = tbxMa.Text.Trim().ToUpper(),
                    TenMon = tbxTen.Text.Trim(),
                    SoTinChi = cbbTin.SelectedIndex > 0 ? byte.Parse(cbbTin.Text.Trim()) : (byte)0,
                    MaKhoa = cbbKhoa.Text.Split('|')[0].Trim()
                };

                if (mon.MaMon.Contains("--"))
                {
                    throw new Exception("Mã môn không hợp lệ!");
                }
                else if (mon.TenMon.Contains("--"))
                {
                    throw new Exception("Tên môn không hợp lệ!");
                }
                else if (mon.SoTinChi <= 0)
                {
                    throw new Exception("Số tín chỉ không hợp lệ!");
                }
                else if (mon.MaKhoa.Contains("--"))
                {
                    throw new Exception("Khoa không hợp lệ!");
                }

                if (client.AddMonHoc(mon))
                {
                    MessageBox.Show("Thêm môn học thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    throw new Exception("Mã môn học đã được sử dụng!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbxMa_Enter(object sender, EventArgs e)
        {
            if (tbxMa.Text.Contains("--"))
            {
                tbxMa.Clear();
                tbxMa.ForeColor = Color.Black;
            }
        }

        private void tbxMa_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxMa.Text))
            {
                tbxMa.Text = "-- Mã môn --";
                tbxMa.ForeColor = Color.DimGray;
            }
            else
            {
                tbxMa.Text = string.Join(" ", tbxMa.Text.Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries));
            }
        }

        private void tbxTen_Enter(object sender, EventArgs e)
        {
            if (tbxTen.Text.Contains("--"))
            {
                tbxTen.Clear(); tbxTen.ForeColor = Color.Black;
            }
        }

        private void tbxTen_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxTen.Text))
            {
                tbxTen.Text = "-- Tên môn --";
                tbxTen.ForeColor = Color.DimGray;
            }
            else
            {
                tbxTen.Text = string.Join(" ", tbxTen.Text.Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries));
            }
        }
    }
}
