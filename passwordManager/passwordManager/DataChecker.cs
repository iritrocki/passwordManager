using passwordManager.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passwordManager
{
    public static class DataChecker
    {
        public static void UniqueCategoryCheck(Category category, List<Category> categories)
        {
            foreach (Category cat in categories)
            {
                CategoryComparison(category.Name, cat.Name);
            }
        }

        public static void CategoryComparison(String name1, String name2)
        {
            if (name1.ToUpper() == name2.ToUpper())
            {
                throw new ExistentCategoryNameException();
            }
        }

        public static void UniqueAccountCheck(Account accountToAdd, List<Account> accounts)
        {
            foreach (Account account in accounts)
            {
                AccountsComparison(account, accountToAdd);

            }
        }

        public static void AccountsComparison(Account account1, Account account2)
        {
            if (account1.Equals(account2))
                throw new ExistentAccountException();
        }

        public static void UniqueCreditCardCheck(CreditCard creditCardToAdd, List<CreditCard> creditCards)
        {
            foreach (CreditCard card in creditCards)
            {
                CreditCardComparison(creditCardToAdd, card);
            }
        }

        public static void CreditCardComparison(CreditCard creditCard1, CreditCard creditCard2)
        {
            if (creditCard1.Equals(creditCard2))
                throw new ExistentCreditCardException();
        }
    }
}
