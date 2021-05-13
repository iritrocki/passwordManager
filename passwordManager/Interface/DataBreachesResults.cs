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

namespace Interface
{
    public partial class DataBreachesResults : UserControl
    {
        private Panel mainPanel;
        private User user;
        public DataBreachesResults(List<Account> exposedPassword, List<CreditCard> exposedCreditCards, Panel mainPanel, User u)
        {
            InitializeComponent();
            ChargeResults(exposedPassword, exposedCreditCards);
            this.mainPanel = mainPanel;
            this.user = u;
        }

        private void ChargeResults(List<Account> exposedPassword, List<CreditCard> exposedCreditCards)
        {
            int passwordRowCount = 0;
            foreach (Account a in exposedPassword)
            {
                Label lblExposedPassword = new Label();
                lblExposedPassword.AutoSize = true;
                lblExposedPassword.Font = new Font("Microsoft Sans Serif", 8);
                lblExposedPassword.Text = string.Format("- {0}", a.ToString());
                lblExposedPassword.Name = "lblExposedPassword";

                Button btnModify = new Button();
                btnModify.AutoSize = true;
                btnModify.Text = "Modificar";
                btnModify.Name = "btnModify";
                btnModify.Size = new Size(95, 22);
                btnModify.Tag = a;
                btnModify.Click += BtnModify_Click;

                tableLayoutPanelPasswords.Controls.Add(lblExposedPassword, 0, passwordRowCount);
                tableLayoutPanelPasswords.Controls.Add(btnModify, 1, passwordRowCount);


                passwordRowCount++;

            }
            int creditCardRowCount = 0;
            foreach (CreditCard c in exposedCreditCards)
            {

                Label lblExposedCreditCard = new Label();
                lblExposedCreditCard.AutoSize = true;
                lblExposedCreditCard.Font = new Font("Microsoft Sans Serif", 8);
                lblExposedCreditCard.Text = string.Format("- {0}", c.ToString());
                lblExposedCreditCard.Name = "lblExposedCreditCard";

                tableLayoutPanelCreditCards.Controls.Add(lblExposedCreditCard, 0, creditCardRowCount);


                creditCardRowCount++;

            }

        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            Button btnModify = (Button)sender;
            Account modificationAccount = (Account)btnModify.Tag;
            this.mainPanel.Controls.Clear();
            UserControl passwordModifier = new AddPassword(user, modificationAccount, this.mainPanel);
            this.mainPanel.Controls.Add(passwordModifier);
        }
    }
}
