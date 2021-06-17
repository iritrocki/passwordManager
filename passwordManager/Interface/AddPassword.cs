using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using passwordManager;
using passwordManager.Exceptions;
using Repository;

namespace Interface
{
    public partial class AddPassword : UserControl
    {
        private Account modificationAccount;
        private Panel mainPanel;
        private IDataAccess<Account> dataAccessAccount = DataAccessManager.GetDataAccessAccount();
        private IDataAccess<DataBreachCheck> daDataBreaches = DataAccessManager.GetDataAccessDataBreaches();
        private bool viewPassword;

        public AddPassword(Panel main)
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            lblError.Text = "";
            lblDataBreaches.Text = "";
            lblDuplicated.Text = "";
            lblSecure.Text = "";
            this.viewPassword = false;
            this.mainPanel = main;
            ChargeComboBox();
        }

        public AddPassword(Account a, Panel main)
        {
            InitializeComponent();
            this.modificationAccount = a;
            txtPassword.PasswordChar = '*';
            lblError.Text = "";
            lblDataBreaches.Text = "";
            lblDuplicated.Text = "";
            lblSecure.Text = "";
            this.viewPassword = false;
            this.mainPanel = main;
            txtSite.Text = string.Format("{0}", a.Site);
            txtNotes.Text = string.Format("{0}", a.Note);
            txtUsername.Text = string.Format("{0}", a.Username);
            ChargeComboBox();
        }

        public void ChargeComboBox()
        {
            IDataAccess<Category> dataAccessCategory = DataAccessManager.GetDataAccessCategory();
            comboBoxCategories.DataSource = dataAccessCategory.GetAll();
            comboBoxCategories.DisplayMember = "Name";
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                Account newAccount = CreateNewAccount();
                if (modificationAccount == null)
                {
                    DataChecker.UniqueAccountCheck(newAccount, (List<Account>)dataAccessAccount.GetAll());
                    this.dataAccessAccount.Add(newAccount);
                    
                }
                else
                {
                    Modificator.TryModifyAccount(this.modificationAccount, newAccount, (List<Account>)dataAccessAccount.GetAll());
                    this.dataAccessAccount.Modify(modificationAccount);
                }
                this.mainPanel.Controls.Clear();
                UserControl passwordList = new PasswordList(mainPanel, (List<Account>)dataAccessAccount.GetAll());
                this.mainPanel.Controls.Add(passwordList);

            }catch(InvalidAccountException exc)
            {
                lblError.Text = exc.Message;
            }
            catch (InvalidNullInputExcpetion exc)
            {
                lblError.Text = exc.Message;
            }
        }

        private Account CreateNewAccount()
        {
            Category category = comboBoxCategories.SelectedItem as Category;
            string site = txtSite.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string notes = txtNotes.Text;
            if (category != null)
            {
                Account newAccount = new Account()
                {
                    Category = category,
                    Site = site,
                    Username = username,
                    Password = password,
                    Note = notes,
                    Modification = DateTime.Now
                };
                return newAccount;
            }
            else
                throw new InvalidNullInputExcpetion();
            
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            try
            {
                List<PasswordRequirement> passwordRequirements = CheckRequirementsNeeded();
                int length = (int)upDownLenght.Value;
                PasswordGenerator passwordGenerator = new PasswordGenerator(length, passwordRequirements);
                txtPassword.Text = passwordGenerator.Password;
            }
            catch (InvalidAccountException exception)
            {
                lblError.Text = exception.Message;
            }

        }
        
        private List<PasswordRequirement> CheckRequirementsNeeded()
        {
            List<PasswordRequirement> passwordRequirements = new List<PasswordRequirement>();
            UpperCaseCheckbox(passwordRequirements);
            LowerCaseCheckbox(passwordRequirements);
            DigitsCheckbox(passwordRequirements);
            SpecialsCheckbox(passwordRequirements);
            return passwordRequirements;
        }

        private void SpecialsCheckbox(List<PasswordRequirement> passwordRequirements)
        {
            if (checkBoxSpecials.Checked)
            {
                NeedSpecials specials = new NeedSpecials();
                passwordRequirements.Add(specials);
            }
        }

        private void DigitsCheckbox(List<PasswordRequirement> passwordRequirements)
        {
            if (checkBoxDigits.Checked)
            {
                NeedDigits digits = new NeedDigits();
                passwordRequirements.Add(digits);
            }
        }

        private void LowerCaseCheckbox(List<PasswordRequirement> passwordRequirements)
        {
            if (checkBoxLower.Checked)
            {
                NeedLowerCase lower = new NeedLowerCase();
                passwordRequirements.Add(lower);
            }
        }

        private void UpperCaseCheckbox(List<PasswordRequirement> passwordRequirements)
        {
            if (checkBoxUpper.Checked)
            {
                NeedUpperCase upper = new NeedUpperCase();
                passwordRequirements.Add(upper);
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = "";
            if (txtPassword.Text == "") 
            {
                lblDataBreaches.Text = "";
                lblDuplicated.Text = "";
                lblSecure.Text = "";
            }else
            {
                PasswordAnalysis passwordAnalysis = new PasswordAnalysis((List<DataBreachCheck>)daDataBreaches.GetAll(), (List<Account>)dataAccessAccount.GetAll());
                passwordAnalysis.RunAnalysis(txtPassword.Text);
                if (passwordAnalysis.DataBreach)
                {
                    lblDataBreaches.Text = "Aparece en un Data Breach";
                    lblDataBreaches.ForeColor = System.Drawing.Color.Orange;
                }
                else
                {
                    lblDataBreaches.Text = "No aparece en Data Breaches";
                    lblDataBreaches.ForeColor = System.Drawing.Color.Green;
                }
                if (passwordAnalysis.Duplicated)
                {
                    lblDuplicated.Text = "Contraseña duplicada";
                    lblDuplicated.ForeColor = System.Drawing.Color.Orange;
                }
                else
                {
                    lblDuplicated.Text = "Contraseña única";
                    lblDuplicated.ForeColor = System.Drawing.Color.Green;
                }
                if (!passwordAnalysis.Secure)
                {
                    lblSecure.Text = "Contraseña insegura";
                    lblSecure.ForeColor = System.Drawing.Color.Orange;
                }
                else
                {
                    lblSecure.Text = "Contraseña segura";
                    lblSecure.ForeColor = System.Drawing.Color.Green;
                }
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (!viewPassword)
            {
                txtPassword.PasswordChar = '\0';
                btnView.Text = "Ocultar";
            }
            else
            {
                txtPassword.PasswordChar = '*';
                btnView.Text = "Ver";
            }
            viewPassword = !viewPassword;
        }

        private void txtSite_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = "";
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = "";
        }

        private void txtNotes_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = "";
        }

        private void upDownLenght_ValueChanged(object sender, EventArgs e)
        {
            lblError.Text = "";
        }

        private void checkBoxUpper_CheckedChanged(object sender, EventArgs e)
        {
            lblError.Text = "";
        }

        private void checkBoxLower_CheckedChanged(object sender, EventArgs e)
        {
            lblError.Text = "";
        }

        private void checkBoxDigits_CheckedChanged(object sender, EventArgs e)
        {
            lblError.Text = "";
        }

        private void checkBoxSpecials_CheckedChanged(object sender, EventArgs e)
        {
            lblError.Text = "";
        }
    }
}
