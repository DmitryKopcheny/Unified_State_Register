using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unified_State_Register
{
    public partial class ReportMarriageCertificateForm : Form
    {
        private List<string> _marriageCertificateData;
        public ReportMarriageCertificateForm(List<string> marriageCertificateData)
        {
            InitializeComponent();
            _marriageCertificateData = marriageCertificateData;
        }

        private void ReportMarriageCertificateForm_Load(object sender, EventArgs e)
        {
            this.reportMarriageCertificate.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            Microsoft.Reporting.WinForms.ReportParameter[] parameters = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter ("RegDate", Convert.ToDateTime(_marriageCertificateData[0]).ToString("dd-MM-yyyy")),
                new Microsoft.Reporting.WinForms.ReportParameter ("ActId", _marriageCertificateData[1]),
                new Microsoft.Reporting.WinForms.ReportParameter ("HusbandBefore", _marriageCertificateData[2]),
                new Microsoft.Reporting.WinForms.ReportParameter ("HusbandAfter", _marriageCertificateData[3]),
                new Microsoft.Reporting.WinForms.ReportParameter ("WifeBefore", _marriageCertificateData[4]),
                new Microsoft.Reporting.WinForms.ReportParameter ("WifeAfter", _marriageCertificateData[5]),
                new Microsoft.Reporting.WinForms.ReportParameter ("RegPlace", _marriageCertificateData[6]),
                new Microsoft.Reporting.WinForms.ReportParameter ("Agency", _marriageCertificateData[7]),
                new Microsoft.Reporting.WinForms.ReportParameter ("HusbandName", _marriageCertificateData[8]),
                new Microsoft.Reporting.WinForms.ReportParameter ("WifeName", _marriageCertificateData[9]),
                new Microsoft.Reporting.WinForms.ReportParameter ("HusbandBirthDate", Convert.ToDateTime(_marriageCertificateData[10]).ToString("dd-MM-yyyy")),
                new Microsoft.Reporting.WinForms.ReportParameter ("WifeBirthDate", Convert.ToDateTime(_marriageCertificateData[11]).ToString("dd-MM-yyyy"))
            };
            this.reportMarriageCertificate.LocalReport.SetParameters(parameters);
            this.reportMarriageCertificate.RefreshReport();
        }
    }
}
