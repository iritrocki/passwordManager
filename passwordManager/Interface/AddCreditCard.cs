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
using Repository;

namespace Interface
{
    public partial class AddCreditCard : UserControl
    {
        const int MONTH = 0;
        const int YEAR = 1;
        private User user;
        private CreditCard modificationCreditCard;
        private Panel mainPanel;
        private IDataAccess<CreditCard> dataAccessCreditCard = DataAccessManager.GetDataAccessCreditCard();

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
            IDataAccess<Category> dataAccessCategory = DataAccessManager.GetDataAccessCategory();
            comboBoxCreditCardCategory.DataSource = dataAccessCategory.GetAll();
            comboBoxCreditCardCategory.DisplayMember = "Name";
        }


        private void btnAcceptNewCreditCard_Click(object sender, EventArgs e)
        {
            try
            {
                CreditCard newCreditCard = CreateNewCreditCard();
                if (modificationCreditCard == null)
                {
                    DataChecker.UniqueCreditCardCheck(newCreditCard, (List<CreditCard>)dataAccessCreditCard.GetAll());
                    this.dataAccessCreditCard.Add(newCreditCard);
                }
                else
                {
                    Modificator.TryModifyCreditCard(modificationCreditCard, newCreditCard, (List<CreditCard>)dataAccessCreditCard.GetAll());
                    this.dataAccessCreditCard.Modify(modificationCreditCard);
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
            string date = txtCreditCardExpiration.Text;
            string notes = txtCreditCardNotes.Text;

            if(category != null)
            {

                CreditCard newCreditCard = new CreditCard()
                {
                    Name = name,
                    Company = company,
                    Number = number,
                    Code = code,
                    Category = category,
                    Notes = notes
                };
                newCreditCard.SetExpirationDate(date);
                return newCreditCard;
            }
            else
            {
                throw new InvalidNullInputExcpetion();
            }

            
           
        }

        
    }

    
}
