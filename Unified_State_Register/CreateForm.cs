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
    public partial class CreateForm : Form
    {
        private MainForm _mForm;
        private SearchForm _sForm;
        private Database _DB;
        private string _mode;
        public CreateForm(MainForm mForm, Database DB)
        {
            InitializeComponent();
            _DB = DB;
            _mForm = mForm;
            _sForm = null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _mForm.openSearchForm();
        }

        private void btnBirth_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
            _mode = "BIRTH";
            makeVisible(_mode);
        }
        private void btnPassport_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
            _mode = "PASSPORT";
            makeVisible(_mode);
        }
        private void btnLivePlace_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
            _mode = "LIVE";
            makeVisible(_mode);
        }
        private void btnOwnership_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
            _mode = "OWNERSHIP";
            makeVisible(_mode);
        }
        private void btnMarriage_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
            _mode = "MARRIAGE";
            makeVisible(_mode);
        }
        private void btnDeath_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
            _mode = "DEATH";
            makeVisible(_mode);
        }
        private void btnTaxpayer_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
            _mode = "TAXPAYER";
            makeVisible(_mode);
        }
        private void makeAllInvisible()
        {
            gbRegistrateBirth.Visible = false;
            gbRegistrateLive.Visible = false;
            gbRegistrateMarriage.Visible = false;
            gbRegistrateOwnership.Visible = false;
            gbRegistratePassport.Visible = false;
            gbRegistrateDeath.Visible = false;
            gbRegistrateTaxpayer.Visible = false;
        }

        private void makeVisible(string groupName)
        {
            makeAllInvisible();
            switch(groupName)
            {
                case "BIRTH":
                    gbRegistrateBirth.Visible = true;
                    break;
                case "PASSPORT":
                    gbRegistratePassport.Visible = true;
                    break;
                case "LIVE":
                    gbRegistrateLive.Visible = true;
                    break;
                case "MARRIAGE":
                    gbRegistrateMarriage.Visible = true;
                    break;
                case "OWNERSHIP":
                    gbRegistrateOwnership.Visible = true;
                    break;
                case "DEATH":
                    gbRegistrateDeath.Visible = true;
                    break;
                case "TAXPAYER":
                    gbRegistrateTaxpayer.Visible = true;
                    break;
            }
        }
        private void clearTextBoxes()
        {
            tbActIdMarriage.Clear();
            tbAdressProperty.Clear();
            tbAgencyBirth.Clear();
            tbAgencyProperty.Clear();
            tbAgencyReg.Clear();
            tbAgencyTaxpayer.Clear();
            tbAppartmentLiveC.Clear();
            tbBirthCertBirth.Clear();
            tbBirthReg.Clear();
            tbCadastralIdProperty.Clear();
            tbCertificateIdDeath.Clear();
            tbCountryBirth.Clear();
            tbDeadPassportIdDeath.Clear();
            tbDeathRegistrationAgencyDeath.Clear();
            tbDeathRegistrationPlaceDeath.Clear();
            tbDocumentIdProperty.Clear();
            tbFatherPassport.Clear();
            tbFirstNameBirth.Clear();
            tbFormTaxpayer.Clear();
            tbHouseLiveC.Clear();
            tbHusbandPassportMarriage.Clear();
            tbIdTaxpayer.Clear();
            tbIssuePlaceLiveC.Clear();
            tbIssueReasonProperty.Clear();
            tbIssueYearCar.Clear();
            tbLastNameBirth.Clear();
            tbLastNameReg.Clear();
            tbMotherPassport.Clear();
            tbNameReg.Clear();
            tbObjectIdProperty.Clear();
            tbObjectProperty.Clear();
            tbOwnerPassportProperty.Clear();
            tbOwnershipReasonProperty.Clear();
            tbPassportBirth.Clear();
            tbPassportIdCar.Clear();
            tbPassportIdLiveC.Clear();
            tbPassportReg.Clear();
            tbPassportTaxpayer.Clear();
            tbPatronimicBirth.Clear();
            tbPatronimicReg.Clear();
            //tbPhotoAdressReg.Clear();
            tbPlaceBirth.Clear();
            tbPlaceLiveC.Clear();
            tbPlaceReg.Clear();
            tbRecordIdLiveC.Clear();
            tbReferenceIdLiveC.Clear();
            tbRegionBirth.Clear();
            tbRegionLiveC.Clear();
            tbRegistationAgencyMarriage.Clear();
            tbRegisterNumberCar.Clear();
            tbRegistrarPassportProperty.Clear();
            tbRegistrationPlaceMarriage.Clear();
            tbRequestedStatementsLiveC.Clear();
            tbShareProperty.Clear();
            //tbSignatureReg.Clear();
            tbStreetLiveC.Clear();
            tbTaxpayerReg.Clear();
            tbWifePassportMarriage.Clear();
        }
        

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            if (_sForm != null)
            {
                _sForm.Visible = false;
                _sForm.Dispose();
            }
            _mForm.makeVisible();
        }

        private void btnRegistrate_Click(object sender, EventArgs e)
        {
            try 
            {
                switch (_mode)
                {
                    case "BIRTH":
                        _DB.RecordBirth(getDataFromBirthGroup());
                        break;
                    case "PASSPORT":
                        _DB.RecordPassport(getDataFromPassportGroup());
                        //_DB.RecordPhotoAndSignature(getDataPhotoAndSignatureGroup());
                        break;
                    case "LIVE":
                        _DB.RecordLiveCertificate(getDataFromLiveCertificateGroup());
                        break;
                    case "MARRIAGE":
                        _DB.RecordMarriage(getDataFromMarriageGroup());
                        break;
                    case "OWNERSHIP":
                        if (tabProperty.SelectedTab == tabProperty.TabPages["tabPage1"])
                        {
                            _DB.RecordPropertyOwnership(getDataFromPropertyOwnershipGroup());
                        }
                        if (tabProperty.SelectedTab == tabProperty.TabPages["tabPage2"])
                        {
                            _DB.RecordCarOwnership(getDataFromCarOwnershipGroup());
                        }
                        break;
                    case "DEATH":
                        _DB.RecordDeath(getDataFromDeathGroup());
                        break;
                    case "TAXPAYER":
                        _DB.RecordTaxpayer(getDataFromTaxpayerGroup());
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
                return;
            }
            clearTextBoxes();
        }
        private Dictionary<string, string> getDataFromBirthGroup()
        {
            Dictionary<string, string> textBoxesData = new Dictionary<string, string>();

            textBoxesData.Add("passport", tbPassportBirth.Text);
            textBoxesData.Add("agency", tbAgencyBirth.Text);
            textBoxesData.Add("birth_cert", tbBirthCertBirth.Text);
            textBoxesData.Add("country", tbCountryBirth.Text);
            textBoxesData.Add("first_name", tbFirstNameBirth.Text);
            textBoxesData.Add("last_name", tbLastNameBirth.Text);
            textBoxesData.Add("patronimic", tbPatronimicBirth.Text);
            textBoxesData.Add("place", tbPlaceBirth.Text);
            textBoxesData.Add("region", tbRegionBirth.Text);
            textBoxesData.Add("mother", tbMotherPassport.Text);
            textBoxesData.Add("father", tbFatherPassport.Text);
            textBoxesData.Add("date", dateBirth.Text);
            textBoxesData.Add("sex", cbSexBirth.Text);

            return textBoxesData;
        }
        private Dictionary<string, string> getDataFromPassportGroup()
        {
            Dictionary<string, string> textBoxesData = new Dictionary<string, string>();

            textBoxesData.Add("agency", tbAgencyReg.Text);
            textBoxesData.Add("birth_cert", tbBirthReg.Text);
            textBoxesData.Add("last_name", tbLastNameReg.Text);
            textBoxesData.Add("first_name", tbNameReg.Text);
            textBoxesData.Add("passport", tbPassportReg.Text);
            textBoxesData.Add("patronimic", tbPatronimicReg.Text);
            textBoxesData.Add("place", tbPlaceReg.Text);
            textBoxesData.Add("taxpayer", tbTaxpayerReg.Text);
            textBoxesData.Add("date", dateReg.Text);
            textBoxesData.Add("sex", cbSexReg.Text);

            return textBoxesData;
        }
        /*private Dictionary<string, string> getDataPhotoAndSignatureGroup()
        {
            Dictionary<string, string> textBoxesData = new Dictionary<string, string>();

            textBoxesData.Add("passport", tbPassportReg.Text);
            textBoxesData.Add("photo", tbPhotoAdressReg.Text);
            textBoxesData.Add("signature", tbSignatureReg.Text);

            return textBoxesData;
        }*/
        private Dictionary<string, string> getDataFromLiveCertificateGroup()
        {
            Dictionary<string, string> textBoxesData = new Dictionary<string, string>();

            textBoxesData.Add("appartment", tbAppartmentLiveC.Text);
            textBoxesData.Add("house", tbHouseLiveC.Text);
            textBoxesData.Add("issue", tbIssuePlaceLiveC.Text);
            textBoxesData.Add("place", tbPlaceLiveC.Text);
            textBoxesData.Add("record", tbRecordIdLiveC.Text);
            textBoxesData.Add("reference", tbReferenceIdLiveC.Text);
            textBoxesData.Add("region", tbRegionLiveC.Text);
            textBoxesData.Add("statements", tbRequestedStatementsLiveC.Text);
            textBoxesData.Add("street", tbStreetLiveC.Text);
            textBoxesData.Add("place_type", cbPlaceTypeLiveC.Text);
            textBoxesData.Add("passport", tbPassportIdLiveC.Text);

            return textBoxesData;
        }
        private Dictionary<string, string> getDataFromMarriageGroup()
        {
            Dictionary<string, string> textBoxesData = new Dictionary<string, string>();

            textBoxesData.Add("act", tbActIdMarriage.Text);
            textBoxesData.Add("husband", tbHusbandPassportMarriage.Text);
            textBoxesData.Add("agency", tbRegistationAgencyMarriage.Text);
            textBoxesData.Add("place", tbRegistrationPlaceMarriage.Text);
            textBoxesData.Add("wife", tbWifePassportMarriage.Text);

            return textBoxesData;
        }
        private Dictionary<string, string> getDataFromDeathGroup()
        {
            Dictionary<string, string> textBoxesData = new Dictionary<string, string>();

            textBoxesData.Add("cert", tbCertificateIdDeath.Text);
            textBoxesData.Add("passport", tbDeadPassportIdDeath.Text);
            textBoxesData.Add("place", tbDeathRegistrationPlaceDeath.Text);
            textBoxesData.Add("agency", tbDeathRegistrationAgencyDeath.Text);

            return textBoxesData;
        }
        private Dictionary<string, string> getDataFromPropertyOwnershipGroup()
        {
            Dictionary<string, string> textBoxesData = new Dictionary<string, string>();

            textBoxesData.Add("adress", tbAdressProperty.Text);
            textBoxesData.Add("agency", tbAgencyProperty.Text);
            textBoxesData.Add("cadastral", tbCadastralIdProperty.Text);
            textBoxesData.Add("doc_id", tbDocumentIdProperty.Text);
            textBoxesData.Add("issue", tbIssueReasonProperty.Text);
            textBoxesData.Add("object_id", tbObjectIdProperty.Text);
            textBoxesData.Add("object", tbObjectProperty.Text);
            textBoxesData.Add("passport", tbOwnerPassportProperty.Text);
            textBoxesData.Add("reason", tbOwnershipReasonProperty.Text);
            textBoxesData.Add("registrar", tbRegistrarPassportProperty.Text);
            textBoxesData.Add("share", tbShareProperty.Text);
            textBoxesData.Add("date", dateObjectRegistrationProperty.Text);
            textBoxesData.Add("form", cbOwnershipFormProperty.Text);


            return textBoxesData;
        }
        private Dictionary<string, string> getDataFromCarOwnershipGroup()
        {
            Dictionary<string, string> textBoxesData = new Dictionary<string, string>();

            textBoxesData.Add("year", tbIssueYearCar.Text);
            textBoxesData.Add("passport", tbPassportIdCar.Text);
            textBoxesData.Add("number", tbRegisterNumberCar.Text);

            return textBoxesData;
        }
        private Dictionary<string, string> getDataFromTaxpayerGroup()
        {
            Dictionary<string, string> textBoxesData = new Dictionary<string, string>();

            textBoxesData.Add("agency", tbAgencyTaxpayer.Text);
            textBoxesData.Add("form_id", tbFormTaxpayer.Text);
            textBoxesData.Add("taxpayer", tbIdTaxpayer.Text);
            textBoxesData.Add("passport", tbPassportTaxpayer.Text);

            return textBoxesData;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
        }


    }
}
