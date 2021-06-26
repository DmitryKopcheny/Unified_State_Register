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
    public partial class ReportReferenceFromUSRForm : Form
    {
        private List<string> _referenceFromUSRData;
        public ReportReferenceFromUSRForm(List<string> referenceFromUSRData)
        {
            InitializeComponent();
            _referenceFromUSRData = referenceFromUSRData;
        }

        private void ReportReferenceFromUSRForm_Load(object sender, EventArgs e)
        {

            this.reportReferenceFromUSR.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            Microsoft.Reporting.WinForms.ReportParameter[] parameters = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter ("Name", _referenceFromUSRData[0]),
                new Microsoft.Reporting.WinForms.ReportParameter ("BirthDate",  Convert.ToDateTime(_referenceFromUSRData[1]).ToString("dd-MM-yyyy")),
                new Microsoft.Reporting.WinForms.ReportParameter ("BirthPlace", _referenceFromUSRData[2]),
                new Microsoft.Reporting.WinForms.ReportParameter ("RecordId", _referenceFromUSRData[3]),
                new Microsoft.Reporting.WinForms.ReportParameter ("ReferenceId", _referenceFromUSRData[4]),
                new Microsoft.Reporting.WinForms.ReportParameter ("RegistrationPlace",_referenceFromUSRData[5]),
                new Microsoft.Reporting.WinForms.ReportParameter ("IssuePlace", _referenceFromUSRData[6]),
                new Microsoft.Reporting.WinForms.ReportParameter ("RegDate", Convert.ToDateTime(_referenceFromUSRData[7]).ToString("dd-MM-yyyy")),
                new Microsoft.Reporting.WinForms.ReportParameter ("ReqStatements", _referenceFromUSRData[8]),
            };
            this.reportReferenceFromUSR.LocalReport.SetParameters(parameters);
            this.reportReferenceFromUSR.RefreshReport();
        }
    }
}
