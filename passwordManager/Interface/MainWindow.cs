using passwordManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class MainWindow : Form
    {
        private User user;
        
        
        public MainWindow(User u)
        {
            InitializeComponent();
            this.user = u;
        }

        private void btnCategoryList_Click(object sender, EventArgs e)
        {
            pnlMainUserControl.Controls.Clear();
            UserControl categoryList = new CategoryList(user, pnlMainUserControl);
            pnlMainUserControl.Controls.Add(categoryList);
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            user.SignOut();
            Form login = new Login(user);
            login.Show();
            this.Visible = false;
        }

        private void btnCreditCardList_Click(object sender, EventArgs e)
        {
            pnlMainUserControl.Controls.Clear();
            UserControl creditCradList = new CreditCardList(user, pnlMainUserControl);
            pnlMainUserControl.Controls.Add(creditCradList);
        }

        private void btnPasswordList_Click(object sender, EventArgs e)
        {
            pnlMainUserControl.Controls.Clear();
            UserControl passwordList = new PasswordList(user, pnlMainUserControl,user.Accounts);
            pnlMainUserControl.Controls.Add(passwordList);
        }


        private void btnCheckDataBreaches_Click(object sender, EventArgs e)
        {
            pnlMainUserControl.Controls.Clear();
            UserControl dataBreaches = new DataBreaches(user, pnlMainUserControl);
            pnlMainUserControl.Controls.Add(dataBreaches);
        }

        private void btnPasswordStrength_Click(object sender, EventArgs e)
        {
            pnlMainUserControl.Controls.Clear();
            UserControl passwordStrength = new PasswordStrength(user, pnlMainUserControl);
            pnlMainUserControl.Controls.Add(passwordStrength);
        }

        private void btnChangeMasterKey_Click(object sender, EventArgs e)
        {
            pnlMainUserControl.Controls.Clear();
            UserControl changeMasterkey = new ModifyMasterKey(user, pnlMainUserControl);
            pnlMainUserControl.Controls.Add(changeMasterkey);
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
