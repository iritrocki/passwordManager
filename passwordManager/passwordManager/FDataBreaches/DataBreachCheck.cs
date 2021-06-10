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
            this.Date = DateTime.Now;
        }
        public List<Account> ExposedPasswords { get; set; }
        public List<CreditCard> ExposedCreditCards { get; set; }
        public List<string> DataBreaches { get; set; }
        public IDataBreachesAdapter TypeOfConversion { get; set; }
        public DateTime Date { get; set; }
        public int Id { get; set; }

        public void CheckDataBreaches(IDataBreachesAdapter typeOfConverter, User user)
        {
            DataBreaches = typeOfConverter.AdaptData();
            this.CheckDataBreachesExposure(user);
        }

        public void CheckDataBreachesExposure(User user)
        {
            foreach(string line in DataBreaches)
            {
                if (!this.IsCreditCardNumber(line))
                {
                    PasswordComparison(user, line);
                }
                else
                {
                    CreditCardNumberComparison(user, line);
                }
            }
        }

        private void CreditCardNumberComparison(User user, string exposed)
        {
            foreach (CreditCard creditCard in user.CreditCards)
            {
                if (exposed == creditCard.Number)
                    ExposedCreditCards.Add(creditCard);
            }
        }

        private void PasswordComparison(User user, string password)
        {
            foreach (Account account in user.Accounts)
            {
                if (password == account.Password)
                    ExposedPasswords.Add(account);
            }
        }

        public bool IsCreditCardNumber(string number)
        {
            string[] subs = number.Split(' ');
            int caracteres = 0;
            foreach (string s in subs)
            {
                caracteres += s.Length;
                foreach(char digit in s)
                {
                    if (NotADigit(digit))
                        return false;
                }
            }
            if (caracteres != 16)
                return false;
            return true;
        }

        private static bool NotADigit(char digit)
        {
            return !((int)digit >= 48 && (int)digit <= 57);
        }

        ~DataBreachCheck() { }
    }
}