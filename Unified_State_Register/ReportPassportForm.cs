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
    public partial class ReportPassportForm : Form
    {
        private List<string> _passportData;
        public ReportPassportForm(List<string> passportData)
        {
            InitializeComponent();
            _passportData = passportData;
        }

        private void ReportPassportForm_Load(object sender, EventArgs e)
        {
            this.reportPassport.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            Microsoft.Reporting.WinForms.ReportParameter[] parameters = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter ("PassportId", _passportData[0]),
                new Microsoft.Reporting.WinForms.ReportParameter ("FirstName", _passportData[1]),
                new Microsoft.Reporting.WinForms.ReportParameter ("LastName", _passportData[2]),
                new Microsoft.Reporting.WinForms.ReportParameter ("Patronimic", _passportData[3]),
                new Microsoft.Reporting.WinForms.ReportParameter ("Sex", _passportData[4]),
                new Microsoft.Reporting.WinForms.ReportParameter ("IssueDate", Convert.ToDateTime(_passportData[5]).ToString("dd-MM-yyyy")),
                new Microsoft.Reporting.WinForms.ReportParameter ("ValidityDate", Convert.ToDateTime(_passportData[6]).ToString("dd-MM-yyyy")),
                new Microsoft.Reporting.WinForms.ReportParameter ("Agency", _passportData[7]),
                new Microsoft.Reporting.WinForms.ReportParameter ("TaxpayerId", _passportData[8]),
                new Microsoft.Reporting.WinForms.ReportParameter ("RecordId", _passportData[9]),
                new Microsoft.Reporting.WinForms.ReportParameter ("BirthDate", Convert.ToDateTime(_passportData[10]).ToString("dd-MM-yyyy")),
                new Microsoft.Reporting.WinForms.ReportParameter ("BirthPlace", _passportData[11])
            };
            this.reportPassport.LocalReport.SetParameters(parameters);
            this.reportPassport.RefreshReport();
        }
    }
}
