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
        private User user;
        private Panel mainPanel;
        private Account myAccount;

        public DetailedPassword(User u,Panel p,Account acc)
        {
            InitializeComponent();
            this.user = u;
            this.mainPanel = p;
            this.myAccount = acc;
            ClearLabels();
            ChargeLabels();
        }

        public void ClearLabels()
        {
            lblDetailPassword.Text = "";
            lblDetailCategory.Text = "";
            lblDetailSite.Text = "";
            lblDetailUsername.Text = "";
            lblDetailNotes.Text = "";
        }
        public void ChargeLabels()
        {
            lblDetailPassword.Text = myAccount.Password;
            lblDetailCategory.Text = myAccount.Category.Name;
            lblDetailSite.Text = myAccount.Site;
            lblDetailUsername.Text = myAccount.Username;
            lblDetailNotes.Text = myAccount.Note;
        }
        
    }
}
