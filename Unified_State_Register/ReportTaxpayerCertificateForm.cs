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
    public partial class ReportTaxpayerCertificateForm : Form
    {
        private List<string> _taxpayerData;
        public ReportTaxpayerCertificateForm(List<string> taxpayerData)
        {
            InitializeComponent();
            _taxpayerData = taxpayerData;
        }

        private void ReportTaxpayerCertificateForm_Load(object sender, EventArgs e)
        {
            this.reportTaxpayerCertificate.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            Microsoft.Reporting.WinForms.ReportParameter[] parameters = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter ("Name", _taxpayerData[0]),
                new Microsoft.Reporting.WinForms.ReportParameter ("BirthDate", Convert.ToDateTime(_taxpayerData[1]).ToString("dd-MM-yyyy")),
                new Microsoft.Reporting.WinForms.ReportParameter ("TaxpayerId", _taxpayerData[2]),
                new Microsoft.Reporting.WinForms.ReportParameter ("RegDate", Convert.ToDateTime(_taxpayerData[3]).ToString("dd-MM-yyyy")),
                new Microsoft.Reporting.WinForms.ReportParameter ("Agency", _taxpayerData[4]),
                new Microsoft.Reporting.WinForms.ReportParameter ("FormId", _taxpayerData[5])

            };
            this.reportTaxpayerCertificate.LocalReport.SetParameters(parameters);
            this.reportTaxpayerCertificate.RefreshReport();
        }
    }
}
