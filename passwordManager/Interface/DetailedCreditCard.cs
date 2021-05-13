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
    public partial class DetailedCreditCard : UserControl
    {
        private CreditCard myCreditCard;
        public DetailedCreditCard(CreditCard cc)
        {
            InitializeComponent();
            this.myCreditCard = cc;
            ClearLabels();
            ChargeLabels();

        }

        public void ClearLabels()
        {
            lblDetailNumber.Text = "";
            lblDetailCode.Text = "";
            lblDetailExpiration.Text = "";
            lblDetailCategory.Text = "";
            lblDetailName.Text = "";
            lblDetailCompany.Text = "";
            lblDetailNotes.Text = "";
        }

        public void ChargeLabels()
        {
            lblDetailNumber.Text = myCreditCard.Number;
            lblDetailCode.Text = myCreditCard.Code;
            lblDetailExpiration.Text = string.Format("{0}/{1}",myCreditCard.ExpirationMonth,myCreditCard.ExpirationYear);
            lblDetailCategory.Text = myCreditCard.Category.Name;
            lblDetailName.Text = myCreditCard.Name;
            lblDetailCompany.Text = myCreditCard.Company;
            lblDetailNotes.Text = myCreditCard.Notes;

        }
    }
}
