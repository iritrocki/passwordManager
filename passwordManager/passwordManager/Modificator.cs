using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passwordManager
{
    public static class Modificator
    {
        public static void TryModifyCategory(Category toChange, string name, List<Category> categories)
        {
            foreach (Category category in categories)
            {
                if (toChange.Id != category.Id)
                {
                    DataChecker.CategoryComparison(category.Name, name);
                }
            }
            toChange.ModifyCategory(name);
        }

        public static void TryModifyAccount(Account actualAccount, Account modificationAccount, List<Account> accounts)
        {
            foreach (Account account in accounts)
            {
                if (actualAccount.Id != account.Id)
                {
                    DataChecker.AccountsComparison(account, modificationAccount);
                }
            }
            actualAccount.ModifyAccount(modificationAccount);
        }

        public static void TryModifyCreditCard(CreditCard actualCreditCard, CreditCard modifiedCreditCard, List<CreditCard> creditCards)
        {
            foreach (CreditCard card in creditCards)
            {
                if (card.Id != actualCreditCard.Id)
                    DataChecker.CreditCardComparison(card, modifiedCreditCard);
            }
            actualCreditCard.ModifyCreditCard(modifiedCreditCard);
        }

    }
}
