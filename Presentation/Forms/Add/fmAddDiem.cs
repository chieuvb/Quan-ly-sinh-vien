using Presentation.SerDiem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Presentation.Forms.Add
{
    public partial class fmAddDiem : Form
    {
        public fmAddDiem()
        {
            InitializeComponent();
        }

        readonly SerDiemSoapClient client = new SerDiemSoapClient();
        DTLophocphan[] lops;

        private void fmAddDiem_Load(object sender, EventArgs e)
        {
            cbbLopHP.SelectedIndex = 0;
            cbbSinhVien.SelectedIndex = 0;
            LoadDataToComboBox();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbLopHP.SelectedIndex > 0 && cbbSinhVien.SelectedIndex > 0)
                {
                    DTDiem diem = new DTDiem
                    {
                        MaLopHocPhan = cbbLopHP.Text.Split('|')[0].Trim(),
                        MaSinhVien = cbbSinhVien.Text.Split('|')[0].Trim(),
                        DiemChuyenCan = string.IsNullOrEmpty(tbxDiemCC.Text) ? 0 : double.Parse(tbxDiemCC.Text),
                        DiemGiuaKy = string.IsNullOrEmpty(tbxDiemGK.Text) ? 0 : double.Parse(tbxDiemGK.Text),
                        DiemThi = string.IsNullOrEmpty(tbxDiemKT.Text) ? 0 : double.Parse(tbxDiemKT.Text),
                        DiemTrungBinh = string.IsNullOrEmpty(tbxDiemTB.Text) ? 0 : double.Parse(tbxDiemTB.Text)
                    };

                    switch (client.AddDiem(diem))
                    {
                        case 0:
                            MessageBox.Show("Nhập điểm thành công!", "Thông báo",
                                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DialogResult = DialogResult.OK;
                            Close();
                            break;
                        case 1:
                            throw new Exception("Nhập điểm thất bại!");
                        case 2:
                            throw new Exception("Không tìm thấy mã sinh viên!");
                    }
                }
                else
                {
                    throw new Exception("Vui lòng chọn lớp học phần và sinh viên phù hợp!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void LoadDataToComboBox()
        {
            lops = client.GetLopHP();
            if (User.Role == 1)
            {
                for (int i = 0; i < lops.Length; i++)
                {
                    cbbLopHP.Items.Add(lops[i].MaLopHocPhan + " | " + lops[i].TenMon + " | " + lops[i].TenGiangVien);
                }
            }
            else if (User.Role == 0)
            {
                cbbLopHP.Items.Clear();
                cbbLopHP.Items.Add("-- Lớp học phần --");
                foreach (var lop in lops)
                {
                    if (User.Username == lop.MaGiangVien)
                    {
                        cbbLopHP.Items.Add(lop.MaLopHocPhan + " | " + lop.TenMon + " | " + lop.TenGiangVien); 
                        break;
                    }
                }
                if (cbbLopHP.Items.Count > 1)
                {
                    cbbLopHP.SelectedIndex = 1;
                }
                List<DTSinhvien> sinhViens = client.GetSinhViens(User.Username).ToList();
                cbbSinhVien.SelectedIndex = 0;
                foreach (var sv in sinhViens)
                {
                    cbbSinhVien.Items.Add(sv.MaSinhVien + " | " + sv.TenSinhVien);
                }
            }
        }

        private void cbbLopHP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (User.Role == 1)
            {
                if (cbbLopHP.SelectedIndex > 0)
                {
                    string magv = "";
                    string lopHP = cbbLopHP.Text.Split('|')[0].Trim();
                    foreach (var item in lops)
                    {
                        if (lopHP == item.MaLopHocPhan)
                        {
                            magv = item.MaGiangVien;
                        }
                    }
                    List<DTSinhvien> sinhViens = client.GetSinhViens(magv).ToList();
                    cbbSinhVien.Items.Clear();
                    cbbSinhVien.Items.Add("-- Sinh viên chưa có điểm --");
                    cbbSinhVien.SelectedIndex = 0;
                    foreach (var sv in sinhViens)
                    {
                        cbbSinhVien.Items.Add(sv.MaSinhVien + " | " + sv.TenSinhVien);
                    }
                }
            }
        }

        void TinhDiemTB()
        {
            double diemCC = 0;
            double diemGK = 0;
            double diemKT = 0;

            if (!string.IsNullOrEmpty(tbxDiemCC.Text))
            {
                diemCC = double.Parse(tbxDiemCC.Text);
            }
            if (!string.IsNullOrEmpty(tbxDiemGK.Text))
            {
                diemGK = double.Parse(tbxDiemGK.Text);
            }
            if (!string.IsNullOrEmpty(tbxDiemKT.Text))
            {
                diemKT = double.Parse(tbxDiemKT.Text);
            }

            tbxDiemTB.Text = ((diemCC + diemGK + diemKT) / 3).ToString("F2");
        }

        private void tbxDiemCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.';
            if (e.KeyChar == '.')
            {
                e.Handled = tbxDiemCC.Text.Contains(".");
            }
        }

        private void tbxDiemCC_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(tbxDiemCC.Text, out double value))
            {
                if (value > 10)
                {
                    tbxDiemCC.Text = "10";
                }
            }
            TinhDiemTB();
        }

        private void tbxDiemGK_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.';
            if (e.KeyChar == '.')
            {
                e.Handled = tbxDiemGK.Text.Contains(".");
            }
        }

        private void tbxDiemGK_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(tbxDiemGK.Text, out double value))
            {
                if (value > 10)
                {
                    tbxDiemGK.Text = "10";
                }
            }
            TinhDiemTB();
        }

        private void tbxDiemThi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.';
            if (e.KeyChar == '.')
            {
                e.Handled = tbxDiemKT.Text.Contains(".");
            }
        }

        private void tbxDiemThi_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(tbxDiemKT.Text, out double value))
            {
                if (value > 10)
                {
                    tbxDiemKT.Text = "10";
                }
            }
            TinhDiemTB();
        }
    }
}
