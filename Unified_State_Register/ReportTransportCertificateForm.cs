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
    public partial class ReportTransportCertificateForm : Form
    {
        private string[] _transportCertificateData;
        public ReportTransportCertificateForm(string[] transportCertificateData)
        {
            InitializeComponent();
            _transportCertificateData = transportCertificateData;
        }

        private void ReportTransportCertificateForm_Load(object sender, EventArgs e)
        {
            this.reportTransportCertificate.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            Microsoft.Reporting.WinForms.ReportParameter[] parameters = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter ("RegId", _transportCertificateData[0]),
                new Microsoft.Reporting.WinForms.ReportParameter ("IssueYear", _transportCertificateData[1]),
                new Microsoft.Reporting.WinForms.ReportParameter ("RegDate",  Convert.ToDateTime(_transportCertificateData[2]).ToString("dd-MM-yyyy")),
                new Microsoft.Reporting.WinForms.ReportParameter ("ValDate", Convert.ToDateTime(_transportCertificateData[3]).ToString("dd-MM-yyyy")),
                new Microsoft.Reporting.WinForms.ReportParameter ("Name", _transportCertificateData[4]),
                new Microsoft.Reporting.WinForms.ReportParameter ("RegLive",_transportCertificateData[5]),
            };
            this.reportTransportCertificate.LocalReport.SetParameters(parameters);
            this.reportTransportCertificate.RefreshReport();
        }
    }
}
