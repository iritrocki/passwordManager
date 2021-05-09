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
                string[] row = new string[] { cc.Category.Name, cc.Name, cc.Company, cc.Number, string.Format("{0}/{1}",cc.ExpirationMonth,cc.ExpirationYear)};
                ListViewItem item = new ListViewItem(row);
                item.Tag = cc;
                listViewCreditCards.Items.Add(item);
            }
        }

        private void btnAddCreditCard_Click(object sender, EventArgs e)
        {
            UserControl creditCardEditWindow = new AddCreditCard(user);
            this.MainPanel.Controls.Clear();
            this.MainPanel.Controls.Add(creditCardEditWindow);
        }

        private void btnModifyCreditCard_Click(object sender, EventArgs e)
        {
            try
            {
                CreditCard selectedCreditCard = (CreditCard)listViewCreditCards.SelectedItems[0].Tag;
                UserControl creditCardEditWindow = new AddCreditCard(user,selectedCreditCard);
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
            }
            catch (Exception exc)
            {
                lblErrorCreditCard.Text = "Debe seleccionar una tarjeta para eliminarla";
            }
        }
    }
}
