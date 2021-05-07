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

namespace Interface
{
    public partial class AddPassword : UserControl
    {
        private User user;
        private Account modificationAccount;

        public AddPassword(User u)
        {
            this.user = u;
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            ChargeComboBox();
        }

        public AddPassword(User u, Account a)
        {
            this.user = u;
            this.modificationAccount = a;
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            ChargeComboBox();
        }

        public void ChargeComboBox()
        {

            comboBoxCategories.DataSource = this.user.Categories;
            comboBoxCategories.DisplayMember = "Name";
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                Account newAccount = CreateNewAccount();
                if (modificationAccount == null)
                {
                    user.TryAddAccount(newAccount);
                }
                else
                {
                    user.TryModifyAccount(this.modificationAccount, newAccount);
                }

            }catch(InvalidAccountException exc)
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

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            try
            {
                bool upper = checkBoxUpper.Checked;
                bool lower = checkBoxLower.Checked;
                bool digits = checkBoxDigits.Checked;
                bool specials = checkBoxSpecials.Checked;
                int length = (int)upDownLenght.Value;
                string generatedPassword = user.GeneratePassword(length, upper, lower, digits, specials);
                txtPassword.Text = generatedPassword;
            }
            catch (InvalidSelectionForPasswordException exception)
            {
                lblError.Text = exception.Message;
            }

        }
    }
}
