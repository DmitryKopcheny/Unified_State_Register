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
    public partial class SearchForm : Form
    {
        private MainForm _mForm;
        private Database _DB;
        public SearchForm(MainForm mForm, Database DB)
        {
            InitializeComponent();
            CreateColumnsInDataGrids();
            ShowColumnsByCheckBoxes();
            _DB = DB;
            _mForm = mForm;
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            _mForm.makeVisible();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControl.SelectedTab == tabControl.TabPages["tabPassport"])
                {
                    dataGridPassport.Rows.Clear();
                    fillDataGridPassport(_DB.ReadPassportData(ReadPassportTexboxes()));
                }
                if (tabControl.SelectedTab == tabControl.TabPages["tabTransport"])
                {
                    dataGridCar.Rows.Clear();
                    fillDataGridCar(_DB.ReadTransportData(tbTransportRegId.Text));
                }
                if (tabControl.SelectedTab == tabControl.TabPages["tabProperty"])
                {
                    dataGridProperty.Rows.Clear();
                    fillDataGridProperty(_DB.ReadPropertyData(tbpropertyDocId.Text));
                }
                if (tabControl.SelectedTab == tabControl.TabPages["tabDeath"])
                {
                    dataGridDeath.Rows.Clear();
                    fillDataGridDeath(_DB.ReadOffspringData(tbDeathId.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            ShowColumnsByCheckBoxes();

        }
        private void fillDataGridPassport(List<string[]> values)
        {
            foreach (var value in values)
            {
                dataGridPassport.Rows.Add(value);
            }
        }
        private void fillDataGridCar(List<string[]> values)
        {
            foreach (var value in values)
            {
                dataGridCar.Rows.Add(value);
            }
        }
        private void fillDataGridProperty(List<string[]> values)
        {
            foreach (var value in values)
            {
                dataGridProperty.Rows.Add(value);
            }
        }
        private void fillDataGridDeath(List<string[]> values)
        {
            foreach (var value in values)
            {
                dataGridDeath.Rows.Add(value);
            }
        }
        private Dictionary<string, string> ReadPassportTexboxes()
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("passport", cbDocType.Text != "Паспорт" ? "%" : string.IsNullOrEmpty(tbDocId.Text) ? "%" : tbDocId.Text);
            data.Add("taxpayer", cbDocType.Text != "КПП" ? "%" : string.IsNullOrEmpty(tbDocId.Text) ? "%" : tbDocId.Text);
            data.Add("reference", cbDocType.Text != "Витяг з ЄДР" ? "%" : string.IsNullOrEmpty(tbDocId.Text) ? "%" : tbDocId.Text);
            data.Add("first_name", string.IsNullOrEmpty(tbFirstName.Text) ? "%" : tbFirstName.Text);
            data.Add("last_name", string.IsNullOrEmpty(tbLastName.Text) ? "%" : tbLastName.Text);
            data.Add("patronimic", string.IsNullOrEmpty(tbPatronimic.Text) ? "%" : tbPatronimic.Text);
            data.Add("place", (string.IsNullOrEmpty(tbRegion.Text) ? "%" : tbRegion.Text) + 
                              (string.IsNullOrEmpty(tbPlace.Text) ? "%" : tbPlace.Text) +
                              (string.IsNullOrEmpty(tbStreet.Text) ? "%" : tbStreet.Text) +
                              (string.IsNullOrEmpty(tbHouse.Text) ? "%" : tbHouse.Text) +
                              (string.IsNullOrEmpty(tbAppartment.Text) ? "%" : tbAppartment.Text));
            return data;
        }
        private void CreateColumnsInDataGrids()
        {
            dataGridPassport.Columns.Add("colPassport", "Паспорт");
            dataGridPassport.Columns.Add("colFirstName", "Ім\'я");
            dataGridPassport.Columns.Add("colLastName", "Прізвище");
            dataGridPassport.Columns.Add("colPatronimic", "По Батькові");
            dataGridPassport.Columns.Add("colSex", "Стать");
            dataGridPassport.Columns.Add("colPassportIssue", "Дата видачі");
            dataGridPassport.Columns.Add("colPassportValidity", "Дійсний до");
            dataGridPassport.Columns.Add("colPassportAgency", "Орган, що видав");
            
            dataGridPassport.Columns.Add("colTaxpayer", "КПП");
            dataGridPassport.Columns.Add("colBirth", "Свід. про нар.");
            dataGridPassport.Columns.Add("colRecord", "Витяг з ЄДР");

            dataGridPassport.Columns.Add("colBirthDate", "Дата народження");
            dataGridPassport.Columns.Add("colFatherPassport", "Паспорт Батька");
            dataGridPassport.Columns.Add("colMotherPassport", "Паспорт матері");
            dataGridPassport.Columns.Add("colBirtPlace", "Місце народження");
            dataGridPassport.Columns.Add("colBirthReg", "Місце реєстрації");

            dataGridPassport.Columns.Add("colReference", "Номер витягу");
            dataGridPassport.Columns.Add("colLivePlace", "Місце проживання");
            dataGridPassport.Columns.Add("colIssuePlace", "Місце отримання");
            dataGridPassport.Columns.Add("colRegDate", "Дата занесення до реєстру");
            dataGridPassport.Columns.Add("colStatements", "Відомості, що запитуються");
            
            dataGridPassport.Columns.Add("colHusband", "Чоловік");
            dataGridPassport.Columns.Add("colWife", "Дружина");
            dataGridPassport.Columns.Add("colAct", "Акт");


            dataGridCar.Columns.Add("colRegId","Реєстраційний номер");
            dataGridCar.Columns.Add("colIssueYear", "Рік випуску");
            dataGridCar.Columns.Add("colRegDate", "Дата реєстрації");
            dataGridCar.Columns.Add("colPassport", "Паспорт володаря");
            dataGridCar.Columns.Add("colValidityDate", "Дійсний до");

            dataGridProperty.Columns.Add("colDocId", "Номер документу");
            dataGridProperty.Columns.Add("colRegDate", "Дата реєстрації");
            dataGridProperty.Columns.Add("colAgency", "Агенство");
            dataGridProperty.Columns.Add("colRegistrar", "Парспарт реєстратора");
            dataGridProperty.Columns.Add("colOwnershipReason", "Причина володіння");
            dataGridProperty.Columns.Add("colIssueReason", "Причина видачі");
            dataGridProperty.Columns.Add("colOwnershipForm", "Форма власності");
            dataGridProperty.Columns.Add("colShare", "Доля");
            dataGridProperty.Columns.Add("colOwnerPassport", "Паспорт володаря");
            dataGridProperty.Columns.Add("colPropertyObject", "Об'єкт");
            dataGridProperty.Columns.Add("colObjectId", "Номер об\'єкту");
            dataGridProperty.Columns.Add("colAdress", "Адреса");
            dataGridProperty.Columns.Add("colCadastralId", "Кадастровий номер");
            dataGridProperty.Columns.Add("colObjectRegDate", "Дата рєстрації об\'єкту");

            dataGridDeath.Columns.Add("colPassport", "Паспорт нащадка");
            dataGridDeath.Columns.Add("colFirstName", "Ім\'я");
            dataGridDeath.Columns.Add("colSecondName", "Прізвище");
            dataGridDeath.Columns.Add("colPatronimic", "По Батькові");
            dataGridDeath.Columns.Add("colSex", "Стать");
            dataGridDeath.Columns.Add("colBirthId", "Свідоцтво про нар.");
            dataGridDeath.Columns.Add("colBirthDate", "Дата нар.");
            dataGridDeath.Columns.Add("colFather", "Паспорт Батька");
            dataGridDeath.Columns.Add("colMother", "Паспорт Матері");
            dataGridDeath.Columns.Add("colBirthPlace", "Місце народження");
            dataGridDeath.Columns.Add("colRegPlace", "Місце реєстрації");
        }
        private void ShowColumnsByCheckBoxes()
        {
            bool passportVisibility = chbPassport.Checked,
                 birthCertificateVisibility = chbBirth.Checked,
                 liveCertificateVisibility = chbLive.Checked,
                 taxpayerCertificateVisibility = chbTaxpayer.Checked,
                 marriageCertificateVisibility = chbMarriage.Checked;

            dataGridPassport.Columns["colPassport"].Visible = passportVisibility;
            dataGridPassport.Columns["colFirstName"].Visible = passportVisibility;
            dataGridPassport.Columns["colLastName"].Visible = passportVisibility;
            dataGridPassport.Columns["colPatronimic"].Visible = passportVisibility;
            dataGridPassport.Columns["colSex"].Visible = passportVisibility;
            dataGridPassport.Columns["colPassportIssue"].Visible = passportVisibility;
            dataGridPassport.Columns["colPassportValidity"].Visible = passportVisibility;
            dataGridPassport.Columns["colPassportAgency"].Visible = passportVisibility;
            
            dataGridPassport.Columns["colBirth"].Visible = birthCertificateVisibility;
            dataGridPassport.Columns["colBirthDate"].Visible = birthCertificateVisibility;
            dataGridPassport.Columns["colBirtPlace"].Visible = birthCertificateVisibility;
            dataGridPassport.Columns["colFatherPassport"].Visible = birthCertificateVisibility;
            dataGridPassport.Columns["colMotherPassport"].Visible = birthCertificateVisibility;
            dataGridPassport.Columns["colBirthReg"].Visible = birthCertificateVisibility;
            
            dataGridPassport.Columns["colRecord"].Visible = liveCertificateVisibility;
            dataGridPassport.Columns["colLivePlace"].Visible = liveCertificateVisibility;
            dataGridPassport.Columns["colIssuePlace"].Visible = liveCertificateVisibility;
            dataGridPassport.Columns["colRegDate"].Visible = liveCertificateVisibility;
            dataGridPassport.Columns["colReference"].Visible = liveCertificateVisibility;
            dataGridPassport.Columns["colStatements"].Visible = liveCertificateVisibility;
            
            dataGridPassport.Columns["colTaxpayer"].Visible = taxpayerCertificateVisibility;
            
            dataGridPassport.Columns["colHusband"].Visible = marriageCertificateVisibility;
            dataGridPassport.Columns["colWife"].Visible = marriageCertificateVisibility;
            dataGridPassport.Columns["colAct"].Visible = marriageCertificateVisibility;
            
        }

        private void chbPassport_CheckedChanged(object sender, EventArgs e)
        {
            ShowColumnsByCheckBoxes();
        }
        private void chbBirth_CheckedChanged(object sender, EventArgs e)
        {
            ShowColumnsByCheckBoxes();
        }
        private void chbLive_CheckedChanged(object sender, EventArgs e)
        {
            ShowColumnsByCheckBoxes();
        }
        private void chbTaxpayer_CheckedChanged(object sender, EventArgs e)
        {
            ShowColumnsByCheckBoxes();
        }
        private void chbMarriage_CheckedChanged(object sender, EventArgs e)
        {
            ShowColumnsByCheckBoxes();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbAppartment.Clear();
            tbDeathId.Clear();
            tbDocId.Clear();
            tbFirstName.Clear();
            tbHouse.Clear();
            tbLastName.Clear();
            tbPatronimic.Clear();
            tbPlace.Clear();
            tbpropertyDocId.Clear();
            tbRegion.Clear();
            tbStreet.Clear();
            tbTransportRegId.Clear();
        }
    }
}
