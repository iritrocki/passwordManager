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
        }
        public List<Account> ExposedPasswords { get; set; }
        public List<CreditCard> ExposedCreditCards { get; set; }
        public IDataBreachesAdapter TypeOfConversion { get; set; }

        public void CheckDataBreaches(IDataBreachesAdapter typeOfConverter, User user)
        {
            List<string> dataConvertida = typeOfConverter.AdaptData();

            this.CheckDataBreachesExposure(user, dataConvertida);

        }

        public void CheckDataBreachesExposure(User user, List<string> data)
        {
            foreach(string line in data)
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