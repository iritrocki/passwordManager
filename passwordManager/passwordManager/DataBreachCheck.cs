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

        public void CheckDataBreaches(IDataBreachesAdapter typeOfConverter, User u)
        {
            List<string> dataConvertida = typeOfConverter.AdaptData();

            this.CheckDataBreachesExposure(u, dataConvertida);

        }

        public void CheckDataBreachesExposure(User u, List<string> data)
        {
            foreach(string str in data)
            {
                if (!this.IsCreditCardNumber(str))
                {
                    PasswordComparison(u, str);
                }
                else
                {
                    CreditCardNumberComparison(u, str);
                }
            }
        }

        private void CreditCardNumberComparison(User u, string str)
        {
            foreach (CreditCard cc in u.CreditCards)
            {
                if (str == cc.Number)
                    ExposedCreditCards.Add(cc);
            }
        }

        private void PasswordComparison(User u, string str)
        {
            foreach (Account acc in u.Accounts)
            {
                if (str == acc.Password)
                    ExposedPasswords.Add(acc);
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