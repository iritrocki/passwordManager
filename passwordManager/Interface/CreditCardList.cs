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
using Repository;

namespace Interface
{
    public partial class CreditCardList : UserControl
    {
        private Panel mainPanel;
        private IDataAccess<CreditCard> daCreditCard = DataAccessManager.GetDataAccessCreditCard();
        private System.Windows.Forms.Timer timer;
        
        public CreditCardList(Panel p)
        {
            InitializeComponent();
            lblErrorCreditCard.Text = "";
            this.mainPanel = p;
            ChargeCreditCardsToList();
        }

        public void ChargeCreditCardsToList()
        {
            List<CreditCard> creditCards = (List<CreditCard>)daCreditCard.GetAll();
            creditCards.Sort(delegate (CreditCard x, CreditCard y) {
                return x.Category.Name.CompareTo(y.Category.Name);
            });
            listViewCreditCards.Items.Clear();
            foreach (CreditCard cc in creditCards)
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
            return string.Format("XXXX XXXX XXXX {0}", last4Digits);
        }

        private void btnAddCreditCard_Click(object sender, EventArgs e)
        {
            UserControl creditCardEditWindow = new AddCreditCard(mainPanel);
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(creditCardEditWindow);
        }

        private void btnModifyCreditCard_Click(object sender, EventArgs e)
        {
            try
            {
                CreditCard selectedCreditCard = (CreditCard)listViewCreditCards.SelectedItems[0].Tag;
                UserControl creditCardEditWindow = new AddCreditCard(mainPanel, selectedCreditCard);
                this.mainPanel.Controls.Clear();
                this.mainPanel.Controls.Add(creditCardEditWindow);
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
                this.daCreditCard.Delete(selectedCreditCard);
                ChargeCreditCardsToList();
            }
            catch (Exception exc)
            {
                lblErrorCreditCard.Text = "Debe seleccionar una tarjeta para eliminarla";
            }
        }
        
        private void listViewCreditCards_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                CreditCard selectedCard = (CreditCard)listViewCreditCards.SelectedItems[0].Tag;
                UserControl thirtySecondsCard = new DetailedCreditCard(selectedCard);
                this.mainPanel.Controls.Clear();
                timer = new System.Windows.Forms.Timer();
                this.mainPanel.Controls.Add(thirtySecondsCard);
                timer.Interval = 30000;
                timer.Tick += new EventHandler(timer_Event);
                timer.Start();
            }
            catch (Exception)
            {

            }
            
        }

        public void timer_Event(object source, EventArgs e)
        {
            timer.Stop();
            
            UserControl newCreditCardList = new CreditCardList(this.mainPanel);
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(newCreditCardList);

        }
    }
}
