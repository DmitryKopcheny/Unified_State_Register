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
    public partial class PersonalForm : Form
    {
        private MainForm _mForm;
        private Database _DB;
        private User _user;
        private ReportPassportForm _passportReport;
        private ReportTaxpayerCertificateForm _taxpayerReport;
        private ReportReferenceFromUSRForm _referenceFromUSRReport;
        private ReportBirthCertificateForm _birthCertificateReport;
        private ReportMarriageCertificateForm _marriageCertificateReport;
        private List<ReportTransportCertificateForm> _transportCertificateReports;
        private List<ReportPropertyOwnershipForm> _propertyOwnershipReports;
        public PersonalForm(MainForm mForm, Database DB, User user)
        {
            InitializeComponent();
            _mForm = mForm;
            _DB = DB;
            _user = user;
        }

        private void btnPassport_Click(object sender, EventArgs e)
        {
            try
            {
                _passportReport = new ReportPassportForm(_DB.ReadPassportForReport(_user.PassportId));
                _passportReport.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnTaxpayer_Click(object sender, EventArgs e)
        {
            try
            {
                _taxpayerReport = new ReportTaxpayerCertificateForm(_DB.ReadTaxpayerCertificateForReport(_user.PassportId));
                _taxpayerReport.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnReference_Click(object sender, EventArgs e)
        {
            try
            {
                _referenceFromUSRReport = new ReportReferenceFromUSRForm(_DB.ReadReferenceFromUSRForReport(_user.PassportId));
                _referenceFromUSRReport.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnBirthCertificate_Click(object sender, EventArgs e)
        {
            try
            {
                _birthCertificateReport = new ReportBirthCertificateForm(_DB.ReadBirthCertificateForReport(_user.PassportId));
                _birthCertificateReport.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnMarriageCertificate_Click(object sender, EventArgs e)
        {
            try
            {
                _marriageCertificateReport = new ReportMarriageCertificateForm(_DB.ReadMarriageCertificateForReport(_user.PassportId));
                _marriageCertificateReport.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnTransportCertificate_Click(object sender, EventArgs e)
        {
            try
            {
                List<string[]> values = _DB.ReadTransportCertificateForReport(_user.PassportId);
                foreach (var value in values)
                {
                    ReportTransportCertificateForm form = new ReportTransportCertificateForm(value);
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnPropertyRightCertificate_Click(object sender, EventArgs e)
        {
            try
            {
                List<string[]> values = _DB.ReadPropertyRightCertificateForReport(_user.PassportId);
                foreach (var value in values)
                {
                    ReportPropertyOwnershipForm form = new ReportPropertyOwnershipForm(value);
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            _mForm.makeVisible();
        }

        private void PersonalForm_Load(object sender, EventArgs e)
        {

        }
    }
}
