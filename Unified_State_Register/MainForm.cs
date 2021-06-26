using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Unified_State_Register
{
    public partial class MainForm : Form
    {
        private Database _DB;
        private SearchForm _sForm;
        private CreateForm _cForm;
        private PersonalForm _pForm;
        private User _signedUser;
        public MainForm(Database DB)
        {
            InitializeComponent();
            _DB = DB;
            tbSignInPassword.UseSystemPasswordChar = true;
            tbSignUpPassword.UseSystemPasswordChar = true;
            tbSignUpPasswordRepeat.UseSystemPasswordChar = true;

        }
        public void makeVisible()
        {
            this.Visible = true;
            if (_sForm != null)
            {
                _sForm.Visible = false;
                _sForm.Dispose();
            }
            if (_cForm != null)
            {
                _cForm.Visible = false;
                _cForm.Dispose();
            }
            if (_pForm != null)
            {
                _pForm.Visible = false;
                _pForm.Dispose();
            }
            _signedUser = null;
        }
        public void openSearchForm()
        {
            _sForm = new SearchForm(this, _DB);
            _sForm.Show();
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                _signedUser = new User(tbSignInName.Text, tbSignInPassword.Text);
                _signedUser = _DB.SignIn(_signedUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
                return;
            }
            tbSignInName.Clear();
            tbSignInPassword.Clear();
            if (_signedUser.Permission == 'C')
            {
                _cForm = new CreateForm(this, _DB);
                this.Visible = false;
                _cForm.Show();
            }
            if (_signedUser.Permission == 'A')
            {
                _sForm = new SearchForm(this, _DB);
                this.Visible = false;
                _sForm.Show();
            }
            if (_signedUser.Permission == 'S')
            {
                _pForm = new PersonalForm(this, _DB, _signedUser);
                this.Visible = false;
                _pForm.Show();
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            User newUser = null;
            if (tbSignUpPassword.Text != tbSignUpPasswordRepeat.Text)
            {
                MessageBox.Show("Паролі не співпадають");
            }
            else
            {
                try
                {
                    newUser = new User(tbSignUpName.Text, tbSignUpPassword.Text, tbSignUpPassportId.Text);
                    _DB.SignUp(newUser);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка: " + ex.Message);
                }
            }
            tbSignUpName.Clear();
            tbSignUpPassword.Clear();
            tbSignUpPasswordRepeat.Clear();
            tbSignUpPassportId.Clear();
        }
    }
}
