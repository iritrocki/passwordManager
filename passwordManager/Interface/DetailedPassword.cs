using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using passwordManager;

namespace Interface
{
    public partial class DetailedPassword : UserControl
    {
        private Account myAccount;

        public DetailedPassword(Account acc)
        {
            InitializeComponent();
            this.myAccount = acc;
            ClearLabels();
            ChargeLabels();
        }

        public void ClearLabels()
        {
            txtDetailPassword.Text = "";
            lblDetailCategory.Text = "";
            lblDetailSite.Text = "";
            lblDetailUsername.Text = "";
            lblDetailNotes.Text = "";
        }
        public void ChargeLabels()
        {
            txtDetailPassword.Text= myAccount.Password;
            lblDetailCategory.Text = myAccount.Category.Name;
            lblDetailSite.Text = myAccount.Site;
            lblDetailUsername.Text = myAccount.Username;
            lblDetailNotes.Text = myAccount.Note;
        }
        
    }
}
