using Presentation.CrystalReport;
using Presentation.SerKhoa;
using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class fmKhoa : Form
    {
        public fmKhoa()
        {
            InitializeComponent();
        }

        readonly SerKhoaSoapClient client = new SerKhoaSoapClient();
        DTKhoa[] khoas;
        int iperPage = 16;
        int crPage = 1;

        private void fmKhoa_Load(object sender, EventArgs e)
        {
            grbAdd.Visible = false;
            tbxMakhoa.Text = "-- Mã khoa --";
            tbxMakhoa.ForeColor = Color.DimGray;
            tbxTenkhoa.Text = "-- Tên khoa --";
            tbxTenkhoa.ForeColor = Color.DimGray;
            tbxDienthoai.Text = "-- Số điện thoại --";
            tbxDienthoai.ForeColor = Color.DimGray;

            lsvKhoa.Columns.Clear();
            lsvKhoa.Columns.Add("stt", "STT", 48);
            lsvKhoa.Columns.Add("mak", "Mã khoa", 200);
            lsvKhoa.Columns.Add("ten", "Tên khoa", 354);
            lsvKhoa.Columns.Add("die", "Điện thoại", 200);

            khoas = client.GetAllKhoa();
            DisplayData(crPage, khoas);
        }

        void DisplayData(int crp, DTKhoa[] kh)
        {
            lsvKhoa.Items.Clear();
            int staInd = (crp - 1) * iperPage;
            int endInd = Math.Min(staInd + iperPage - 1, kh.Length - 1);

            int totalPages = (int)Math.Ceiling((double)kh.Length / iperPage);
            lblcrPage.Text = crPage.ToString();
            lblTotal.Text = totalPages.ToString();

            for (int i = staInd; i <= endInd; i++)
            {
                DTKhoa khoa = kh[i];
                ListViewItem lvi = new ListViewItem((i + 1).ToString());
                lvi.SubItems.Add(khoa.MaKhoa);
                lvi.SubItems.Add(khoa.TenKhoa);
                lvi.SubItems.Add(khoa.SoDienThoai);
                lsvKhoa.Items.Add(lvi);
            }
        }

        DataTable ToDataTable(DTKhoa[] khos)
        {
            DataTable dt = new DataTable { TableName = "khoa" };
            if (khos != null)
            {
                dt.Columns.Add("ma", typeof(string));
                dt.Columns.Add("ten", typeof(string));
                dt.Columns.Add("so", typeof(string));

                foreach (var khoa in khos)
                {
                    DataRow dr = dt.NewRow();
                    dr["ma"] = khoa.MaKhoa;
                    dr["ten"] = khoa.TenKhoa;
                    dr["so"] = khoa.SoDienThoai;
                    dt.Rows.Add(dr);
                }
            }
            return dt;
        }

        private void btnPrin_Click(object sender, EventArgs e)
        {
            DataTable dataTable = ToDataTable(khoas);
            new fmReport(dataTable).Show();
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if (crPage > 1)
            {
                crPage--;
                DisplayData(crPage, khoas);
            }
        }

        private void btnNex_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)khoas.Length / iperPage);
            if (crPage < totalPages)
            {
                crPage++;
                DisplayData(crPage, khoas);
            }
        }

        private void fmKhoa_SizeChanged(object sender, EventArgs e)
        {
            if (Width > 808)
            {
                lsvKhoa.Height = 740;
                pnlPages.Location = new Point(726, 168);
                pnlText.Location = new Point(416, 25);
                grbAdd.Width = 1612;
                iperPage = 32;
            }
            else
            {
                lsvKhoa.Height = 414;
                pnlPages.Location = new Point(320, 162);
                pnlText.Location = new Point(6, 25);
                grbAdd.Width = 800;
                iperPage = 16;
            }
            DisplayData(crPage, khoas);
        }

        private void tbxMakhoa_Enter(object sender, EventArgs e)
        {
            if (tbxMakhoa.Text.Contains("--"))
            {
                tbxMakhoa.Clear();
                tbxMakhoa.ForeColor = Color.Black;
            }
        }

        private void tbxMakhoa_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxMakhoa.Text))
            {
                tbxMakhoa.Text = "-- Mã khoa --";
                tbxMakhoa.ForeColor = Color.DimGray;
            }
            else
            {
                tbxMakhoa.Text = string.Join(" ", tbxMakhoa.Text.Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries));
            }
        }

        private void tbxTenkhoa_Enter(object sender, EventArgs e)
        {
            if (tbxTenkhoa.Text.Contains("--"))
            {
                tbxTenkhoa.Clear(); tbxTenkhoa.ForeColor = Color.Black;
            }
        }

        private void tbxTenkhoa_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxTenkhoa.Text))
            {
                tbxTenkhoa.Text = "-- Tên khoa --";
                tbxTenkhoa.ForeColor = Color.DimGray;
            }
            else
            {
                tbxTenkhoa.Text = string.Join(" ", tbxTenkhoa.Text.Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries));
            }
        }

        private void tbxDienthoai_Enter(object sender, EventArgs e)
        {
            if (tbxDienthoai.Text.Contains("--"))
            {
                tbxDienthoai.Clear(); tbxDienthoai.ForeColor = Color.Black;
            }
        }

        private void tbxDienthoai_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxDienthoai.Text))
            {
                tbxDienthoai.Text = "-- Số điện thoại --";
                tbxDienthoai.ForeColor = Color.DimGray;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (User.Role == 1)
            {
                grbAdd.Visible = true;
                grbAdd.Text = "Thêm khoa";
                tbxMakhoa.Enabled = true;
                tbxMakhoa.TextAlign = HorizontalAlignment.Left;
                tbxMakhoa.Text = "-- Mã khoa --";
                tbxMakhoa.ForeColor = Color.DimGray;
                tbxTenkhoa.Text = "-- Tên khoa --";
                tbxTenkhoa.ForeColor = Color.DimGray;
                tbxDienthoai.Text = "-- Số điện thoại --";
                tbxDienthoai.ForeColor = Color.DimGray;
                btnSubmit.Text = "Thêm";
                btnDelete.Visible = false;
            }
            else
            {
                MessageBox.Show("Yêu cầu bị từ chối!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbxDienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void lsvKhoa_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem item = lsvKhoa.SelectedItems[0];
            DTKhoa khoa = new DTKhoa
            {
                MaKhoa = item.SubItems[1].Text,
                TenKhoa = item.SubItems[2].Text,
                SoDienThoai = item.SubItems[3].Text
            };

            if (User.Role == 1)
            {
                grbAdd.Visible = true;
                grbAdd.Text = "Sửa khoa";
                btnSubmit.Text = "Lưu";
                btnDelete.Visible = true;

                tbxMakhoa.Enabled = false;
                tbxMakhoa.TextAlign = HorizontalAlignment.Center;
                tbxMakhoa.Text = khoa.MaKhoa;
                tbxTenkhoa.Text = khoa.TenKhoa;
                tbxTenkhoa.ForeColor = Color.Black;
                tbxDienthoai.Text = khoa.SoDienThoai;
                tbxDienthoai.ForeColor = Color.Black;
            }
            else if (User.Role == 0)
            {
                MessageBox.Show(khoa.MaKhoa + " | " + khoa.TenKhoa, "Thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        void Check(DTKhoa khoa)
        {
            if (khoa.MaKhoa.Contains("--"))
            {
                throw new Exception("Mã khoa không hợp lệ!");
            }
            else if (khoa.TenKhoa.Contains("--"))
            {
                throw new Exception("Tên khoa không hợp lệ!");
            }
            else if (!Regex.IsMatch(khoa.SoDienThoai, @"^(0[2-9]|01[2689]|09|08[1-9])[0-9]{8}$"))
            {
                throw new Exception("Số điện thoại không hợp lệ!");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var khoa = new DTKhoa
                {
                    MaKhoa = tbxMakhoa.Text.Trim().ToUpper(),
                    TenKhoa = tbxTenkhoa.Text.Trim(),
                    SoDienThoai = tbxDienthoai.Text.Trim()
                };

                Check(khoa);

                if (tbxMakhoa.Enabled)
                {
                    int res = client.AddKhoa(khoa);
                    if (res == 1)
                    {
                        MessageBox.Show("Thêm khoa thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        grbAdd.Visible = false;
                        khoas = client.GetAllKhoa();
                        DisplayData(crPage, khoas);
                    }
                    else if (res == 2)
                    {
                        throw new Exception("Mã khoa này đã được sử dụng!");
                    }
                    else { throw new Exception("Thêm thất bại!"); }
                }
                else
                {
                    int res = client.EditKhoa(khoa);
                    if (res == 1)
                    {
                        MessageBox.Show("Sửa thông tin khoa thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        grbAdd.Visible = false;
                        khoas = client.GetAllKhoa();
                        DisplayData(crPage, khoas);
                    }
                    else if (res == 3)
                    {
                        throw new Exception("Mã khoa không tồn tại!");
                    }
                    else { throw new Exception("Sửa thất bại!"); }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            grbAdd.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Thông tin về khoa đã chọn sẽ bị xóa vĩnh viễn.\n" +
                    "Bạn có muốn tiếp tục?", "Cảnh báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    int res = client.DeleteKhoa(tbxMakhoa.Text);
                    if (res == 1)
                    {
                        MessageBox.Show("Xóa khoa thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        grbAdd.Visible = false;
                        khoas = client.GetAllKhoa();
                        DisplayData(crPage, khoas);
                    }
                    else if (res == 3)
                    {
                        throw new Exception("Mã khoa không tồn tại!");
                    }
                    else
                    {
                        throw new Exception("Xóa thất bại!");
                    }
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
