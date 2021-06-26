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
    public partial class ReportPropertyOwnershipForm : Form
    {
        private string[] _propertyOwnershipData;
        public ReportPropertyOwnershipForm(string[] propertyOwnershipData)
        {
            InitializeComponent();
            _propertyOwnershipData = propertyOwnershipData;
        }

        private void ReportPropertyOwnershipForm_Load(object sender, EventArgs e)
        {
            this.reportPropertyOwnership.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            Microsoft.Reporting.WinForms.ReportParameter[] parameters = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter ("DocId", _propertyOwnershipData[0]),
                new Microsoft.Reporting.WinForms.ReportParameter ("RegDate", Convert.ToDateTime(_propertyOwnershipData[1]).ToString("dd-MM-yyyy")),
                new Microsoft.Reporting.WinForms.ReportParameter ("Agency", _propertyOwnershipData[2]),
                new Microsoft.Reporting.WinForms.ReportParameter ("OwnershipReason", _propertyOwnershipData[3]),
                new Microsoft.Reporting.WinForms.ReportParameter ("IssueReason", _propertyOwnershipData[4]),
                new Microsoft.Reporting.WinForms.ReportParameter ("OwnershipForm", _propertyOwnershipData[5]),
                new Microsoft.Reporting.WinForms.ReportParameter ("Share", _propertyOwnershipData[6]),
                new Microsoft.Reporting.WinForms.ReportParameter ("PropertyObject", _propertyOwnershipData[7]),
                new Microsoft.Reporting.WinForms.ReportParameter ("ObjectId", _propertyOwnershipData[8]),
                new Microsoft.Reporting.WinForms.ReportParameter ("Adress", _propertyOwnershipData[9]),
                new Microsoft.Reporting.WinForms.ReportParameter ("CadastralId", _propertyOwnershipData[10]),
                new Microsoft.Reporting.WinForms.ReportParameter ("ObjectRegDate",Convert.ToDateTime(_propertyOwnershipData[11]).ToString("dd-MM-yyyy")),
                new Microsoft.Reporting.WinForms.ReportParameter ("RegistrarName", _propertyOwnershipData[12]),
                new Microsoft.Reporting.WinForms.ReportParameter ("OwnerName", _propertyOwnershipData[13]),
                new Microsoft.Reporting.WinForms.ReportParameter ("OwnerTaxpayerId", _propertyOwnershipData[14])
            };
            this.reportPropertyOwnership.LocalReport.SetParameters(parameters);
            this.reportPropertyOwnership.RefreshReport();
        }
    }
}
