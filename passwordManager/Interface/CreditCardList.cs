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
    public partial class CreditCardList : UserControl
    {
        private User user;
        private Panel MainPanel;
        private System.Windows.Forms.Timer timer;
        public CreditCardList(User u,Panel p)
        {
            InitializeComponent();
            lblErrorCreditCard.Text = "";
            this.user = u;
            this.MainPanel = p;
            ChargeCreditCardsToList();
        }

        public void ChargeCreditCardsToList()
        {
            this.user.CreditCards.Sort(delegate (CreditCard x, CreditCard y) {
                return x.Category.Name.CompareTo(y.Category.Name);
            });
            listViewCreditCards.Items.Clear();
            foreach (CreditCard cc in user.CreditCards)
            {
                string shownCCNumber = CreditCardNumberShown(cc.Number);
                string[] row = new string[] { cc.Category.Name, cc.Name, cc.Company, shownCCNumber, string.Format("{0}/{1}", cc.ExpirationMonth, cc.ExpirationYear) };
                ListViewItem item = new ListViewItem(row);
                item.Tag = cc;
                listViewCreditCards.Items.Add(item);
            }
        }

        private static string CreditCardNumberShown(string creditCardNumber)
        {
            string last4Digits = creditCardNumber.Substring(14);
            string shownCCNumber = string.Format("XXXX XXXX XXXX {0}", last4Digits);
            return shownCCNumber;
        }

        private void btnAddCreditCard_Click(object sender, EventArgs e)
        {
            UserControl creditCardEditWindow = new AddCreditCard(user, MainPanel);
            this.MainPanel.Controls.Clear();
            this.MainPanel.Controls.Add(creditCardEditWindow);
        }

        private void btnModifyCreditCard_Click(object sender, EventArgs e)
        {
            try
            {
                CreditCard selectedCreditCard = (CreditCard)listViewCreditCards.SelectedItems[0].Tag;
                UserControl creditCardEditWindow = new AddCreditCard(user, MainPanel, selectedCreditCard);
                this.MainPanel.Controls.Clear();
                this.MainPanel.Controls.Add(creditCardEditWindow);
            }
            catch (Exception exc)
            {
                lblErrorCreditCard.Text = "Debe seleccionar una tarjeta para modificarla";
            }
        }

        private void btnDeleteCreditCard_Click(object sender, EventArgs e)
        {
            try{
                CreditCard selectedCreditCard = (CreditCard)listViewCreditCards.SelectedItems[0].Tag;
                user.TryRemoveCreditCard(selectedCreditCard);
                ChargeCreditCardsToList();
            }
            catch (Exception exc)
            {
                lblErrorCreditCard.Text = "Debe seleccionar una tarjeta para eliminarla";
            }
        }
        

        private void listViewCreditCards_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                CreditCard selectedCard = (CreditCard)listViewCreditCards.SelectedItems[0].Tag;
                UserControl thirtySecondsCard = new DetailedCreditCard(this.user, this.MainPanel, selectedCard);
                this.MainPanel.Controls.Clear();
                timer = new System.Windows.Forms.Timer();
                this.MainPanel.Controls.Add(thirtySecondsCard);
                timer.Interval = 5000;
                timer.Tick += new EventHandler(timer_Event);
                timer.Start();
            }
            catch (Exception)
            {

            }
            
        }

        public void timer_Event(Object source, EventArgs e)
        {
            timer.Stop();
            
            UserControl newCreditCardList = new CreditCardList(this.user, this.MainPanel);
            this.MainPanel.Controls.Clear();
            this.MainPanel.Controls.Add(newCreditCardList);

        }
    }
}
