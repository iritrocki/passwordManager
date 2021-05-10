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
using passwordManager.Exceptions;

namespace Interface
{
    public partial class AddCreditCard : UserControl
    {
        private const int MONTH = 0;
        private const int YEAR = 1;
        private User user;
        private CreditCard modificationCreditCard;
        private Panel mainPanel;
        public AddCreditCard(User u, Panel p)
        {
            
            InitializeComponent();
            lblCreditCardError.Text = "";
            this.user = u;
            this.mainPanel = p;
            ChargeComboBox();
        }
        public AddCreditCard(User u, Panel p, CreditCard creditCard)
        {
            InitializeComponent();
            lblCreditCardError.Text = "";
            this.user = u;
            this.mainPanel = p;
            this.modificationCreditCard = creditCard;
            txtCreditCardName.Text =  creditCard.Name;
            txtCreditCardCompany.Text = creditCard.Company;
            txtCreditCardCode.Text = creditCard.Code;
            txtCreditCardNumber.Text = creditCard.Number;
            txtCreditCardExpiration.Text = string.Format("{0}/{1}", creditCard.ExpirationMonth, creditCard.ExpirationYear);
            txtCreditCardNotes.Text = creditCard.Notes;

            ChargeComboBox();
        }

        public void ChargeComboBox()
        {

            comboBoxCreditCardCategory.DataSource = user.Categories;
            comboBoxCreditCardCategory.DisplayMember = "Name";

        }


        public int GetExpirationDate(string date, int index)
        {
            string[] expirationDate = date.Split('/');
            int integer = Int32.Parse(expirationDate[index]);
            return integer;
        }

        private void btnAcceptNewCreditCard_Click(object sender, EventArgs e)
        {

            try
            {
                CreditCard newCreditCard = CreateNewCreditCard();

                if (modificationCreditCard == null)
                {
                    user.TryAddCreditCard(newCreditCard);
                }
                else
                {
                    user.TryModifyCreditCard(modificationCreditCard, newCreditCard);
                }
                mainPanel.Controls.Clear();
                UserControl creditCardList = new CreditCardList(user, mainPanel);
                mainPanel.Controls.Add(creditCardList);
            }
            catch (InvalidCreditCardException exc)
            {
                lblCreditCardError.Text = exc.Message;
            }
            catch(InvalidNullInputExcpetion exc)
            {
                lblCreditCardError.Text = exc.Message;
            }
        }

        private CreditCard CreateNewCreditCard()
        {
            Category category = comboBoxCreditCardCategory.SelectedItem as Category;
            string name = txtCreditCardName.Text;
            string company = txtCreditCardCompany.Text;
            string number = txtCreditCardNumber.Text;
            string code = txtCreditCardCode.Text;
            int expirationMonth = GetExpirationDate(txtCreditCardExpiration.Text, MONTH);
            int expirationYear = GetExpirationDate(txtCreditCardExpiration.Text, YEAR);
            string notes = txtCreditCardNotes.Text;
            if(category != null)
            {

                CreditCard newCreditCard = new CreditCard()
                {
                    Name = name,
                    Company = company,
                    Number = number,
                    Code = code,
                    ExpirationMonth = expirationMonth,
                    ExpirationYear = expirationYear,
                    Category = category
                };
                return newCreditCard;
            }
            else
            {
                throw new InvalidNullInputExcpetion();
            }
            
           
        }
    }
}
