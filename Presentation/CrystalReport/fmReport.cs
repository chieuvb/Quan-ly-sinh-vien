using System;
using System.Data;
using System.Windows.Forms;

namespace Presentation.CrystalReport
{
    public partial class fmReport : Form
    {
        public fmReport(DataTable datTab)
        {
            InitializeComponent();
            dataTable = datTab;
        }

        readonly DataTable dataTable;

        private void fmReport_Load(object sender, EventArgs e)
        {
            if (dataTable.TableName == "bangDiem")
            {
                rptDiem diem = new rptDiem();
                diem.SetDataSource(dataTable);
                crvReportViewer.ReportSource = diem;
            }
            else if (dataTable.TableName == "sinhVien")
            {
                rptSinh sinh = new rptSinh();
                sinh.SetDataSource(dataTable);
                crvReportViewer.ReportSource = sinh;
            }
            else if (dataTable.TableName == "giangVien")
            {
                rptGiang giang = new rptGiang();
                giang.SetDataSource(dataTable);
                crvReportViewer.ReportSource = giang;
            }
            else if (dataTable.TableName == "khoa")
            {
                rptKhoa khoa = new rptKhoa();
                khoa.SetDataSource(dataTable);
                crvReportViewer.ReportSource = khoa;
            }
            else if (dataTable.TableName == "monHoc")
            {
                rptMon mon = new rptMon();
                mon.SetDataSource(dataTable);
                crvReportViewer.ReportSource = mon;
            }
            else if (dataTable.TableName == "lopHC")
            {
                rptLopHC lopc = new rptLopHC();
                lopc.SetDataSource(dataTable);
                crvReportViewer.ReportSource = lopc;
            }
            else if (dataTable.TableName == "lopHP")
            {
                rptLopHP lopp = new rptLopHP();
                lopp.SetDataSource(dataTable);
                crvReportViewer.ReportSource = lopp;
            }
        }
    }
}
