using Presentation.SerMonhoc;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation.Forms.Edit
{
    public partial class fmEditMon : Form
    {
        public fmEditMon(DTMonhoc mo)
        {
            InitializeComponent();
            monHoc = mo;
        }

        readonly SerMonhocSoapClient client = new SerMonhocSoapClient();
        readonly DTMonhoc monHoc;

        private void fmEditMon_Load(object sender, EventArgs e)
        {
            tbxMa.ReadOnly = true;
            tbxMa.TextAlign = HorizontalAlignment.Center;
            tbxMa.Text = "Mã môn: " + monHoc.MaMon;
            tbxTen.Text = monHoc.TenMon;
            cbbTin.Text = monHoc.SoTinChi.ToString();

            foreach (var khoa in client.GetAllKhoa())
            {
                cbbKhoa.Items.Add(khoa.MaKhoa + " | " + khoa.TenKhoa);
            }
            foreach (var item in cbbKhoa.Items)
            {
                if (item.ToString().Contains(monHoc.MaKhoa))
                {
                    cbbKhoa.SelectedItem = item; break;
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                DTMonhoc mon = new DTMonhoc
                {
                    MaMon = tbxMa.Text.Split(' ')[2],
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

                if (client.UpdateMonHoc(mon))
                {
                    MessageBox.Show("Sửa thông tin môn học thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    throw new Exception("Không thể sửa do có lỗi trong quá trình truy xuất dữ liệu!");
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
                if (MessageBox.Show("Môn học sẽ bị xóa vĩnh viễn!", "Cảnh báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (client.DeleteMonHoc(tbxMa.Text.Split(' ')[2]))
                    {
                        MessageBox.Show("Xóa môn học thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        throw new Exception("Không thể xóa do có lỗi trong quá trình truy xuất dữ liệu!");
                    }
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
