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
        private DataBreachCheck dataBreachCheck;
        public DataBreachesResults(DataBreachCheck dataBreachCheck, Panel mainPanel)
        {
            InitializeComponent();
            this.dataBreachCheck = dataBreachCheck;
            ChargeResults();
            this.mainPanel = mainPanel;
        }

        private void ChargeResults()
        {
            int passwordRowCount = 0;
            foreach (Account a in this.dataBreachCheck.ExposedPasswords)
            {
                Label lblExposedPassword = new Label();
                lblExposedPassword.AutoSize = true;
                lblExposedPassword.Font = new Font("Microsoft Sans Serif", 8);
                lblExposedPassword.Text = string.Format("- {0}", a.ToString());
                lblExposedPassword.Name = "lblExposedPassword";
                tableLayoutPanelPasswords.Controls.Add(lblExposedPassword, 0, passwordRowCount);

                if(a.Modification > this.dataBreachCheck.Date)
                {
                    Label lblModifiedPassword = new Label();
                    lblModifiedPassword.AutoSize = true;
                    lblModifiedPassword.Font = new Font("Microsoft Sans Serif", 8);
                    lblModifiedPassword.Text = "Modificada";
                    lblModifiedPassword.Name = "lblModifiedPassword";
                    tableLayoutPanelPasswords.Controls.Add(lblModifiedPassword, 1, passwordRowCount);
                }
                else
                {
                    Button btnModify = new Button();
                    btnModify.AutoSize = true;
                    btnModify.Text = "Modificar";
                    btnModify.Name = "btnModify";
                    btnModify.Size = new Size(95, 22);
                    btnModify.Tag = a;
                    btnModify.Click += BtnModify_Click;
                    tableLayoutPanelPasswords.Controls.Add(btnModify, 1, passwordRowCount);
                }
                passwordRowCount++;

            }
            int creditCardRowCount = 0;
            foreach (CreditCard c in this.dataBreachCheck.ExposedCreditCards)
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
            UserControl passwordModifier = new AddPassword(modificationAccount, this.mainPanel);
            this.mainPanel.Controls.Add(passwordModifier);
        }
    }
}
