using passwordManager;
using System;
using System.Collections.Generic;

namespace passwordManager
{
    public class DataBreachCheck
    {
        public DataBreachCheck()
        {
            ExposedPasswords = new List<Account>();
            ExposedCreditCards = new List<CreditCard>();
            DataBreaches = new List<DataBreachLine>();
            this.Date = DateTime.Now;
        }
        public List<Account> ExposedPasswords { get; set; }
        public List<CreditCard> ExposedCreditCards { get; set; }
        public List<DataBreachLine> DataBreaches { get; set; }
        public IDataBreachesAdapter TypeOfConversion { get; set; }
        public DateTime Date { get; set; }
        public int Id { get; set; }

        public void CheckDataBreaches(IDataBreachesAdapter typeOfConverter, List<Account> accounts, List<CreditCard> creditCards)
        {
            TypeOfConversion = typeOfConverter;
            GetAdaptedData();
            this.CheckDataBreachesExposure(accounts, creditCards);
        }

        private void GetAdaptedData()
        {
            List<string> dataBreaches = TypeOfConversion.AdaptData();
            foreach (string line in dataBreaches)
            {
                DataBreachLine dbLine = new DataBreachLine(line);
                this.DataBreaches.Add(dbLine);

            }
        }

        public void CheckDataBreachesExposure(List<Account> accounts, List<CreditCard> creditCards)
        {
            foreach (DataBreachLine line in DataBreaches)
            {
                if (!Validator.ValidateCreditCardNumber(line.Line))
                {
                    PasswordComparison(line.Line, accounts);
                }
                else
                {
                    CreditCardNumberComparison(line.Line, creditCards);
                }
            }
        }

        private void CreditCardNumberComparison(string exposed, List<CreditCard> creditCards)
        {
            foreach (CreditCard creditCard in creditCards)
            {
                if (exposed == creditCard.Number)
                    ExposedCreditCards.Add(creditCard);
            }
        }

        private void PasswordComparison(string password, List<Account> accounts)
        {
            foreach (Account account in accounts)
            {
                if (password == account.Password)
                    ExposedPasswords.Add(account);
            }
        }


        ~DataBreachCheck() { }
    }
}