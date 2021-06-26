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
    public partial class ReportBirthCertificateForm : Form
    {
        private List<string> _birthCertificateData;
        public ReportBirthCertificateForm(List<string> birthCertificateData)
        {
            InitializeComponent();
            _birthCertificateData = birthCertificateData;
        }

        private void ReportBirthCertificateForm_Load(object sender, EventArgs e)
        {
            this.reportBirthCertificate.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            Microsoft.Reporting.WinForms.ReportParameter[] parameters = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter ("Name", _birthCertificateData[0]),
                new Microsoft.Reporting.WinForms.ReportParameter ("CertificateId", _birthCertificateData[1]),
                new Microsoft.Reporting.WinForms.ReportParameter ("BirthDate", Convert.ToDateTime(_birthCertificateData[2]).ToString("dd-MM-yyyy")),
                new Microsoft.Reporting.WinForms.ReportParameter ("BirthPlace", _birthCertificateData[3]),
                new Microsoft.Reporting.WinForms.ReportParameter ("RegPlace", _birthCertificateData[4]),
                new Microsoft.Reporting.WinForms.ReportParameter ("Father", _birthCertificateData[5]),
                new Microsoft.Reporting.WinForms.ReportParameter ("Mother",_birthCertificateData[6])
            };
            this.reportBirthCertificate.LocalReport.SetParameters(parameters);
            this.reportBirthCertificate.RefreshReport();
        }
    }
}
