
﻿using passwordManager.Exceptions;
using System;
using System.Collections.Generic;


namespace passwordManager
{
    public class User
    {
        public User()
        {
            this.Status = false;
            this.Categories = new List<Category>();
            this.Accounts = new List<Account>();
            this.CreditCards = new List<CreditCard>();
            this.ColorCount = new int[Enum.GetValues(typeof(Account.Color)).Length];
        }

        public bool Status { get; private set; }
        public string MasterKey { get; set; }
        public List<Category> Categories { get; set; }
        public List<Account> Accounts { get; set; }
        public List<CreditCard> CreditCards { get; set; }
        public int[] ColorCount { get; set; }

        public void SignIn(string input)
        {
            if(input == this.MasterKey)
            {
                this.Status = true;
            }
            else
            {
                throw new InvalidMasterKeyException();
            }
        }

        public void SignOut()
        {
            this.Status = false;
        }

        public void ChangeMasterKey(string actualMasterKey, string newMasterKey)
        {
            if(actualMasterKey == this.MasterKey)
                this.MasterKey = newMasterKey;
            else
                throw new InvalidMasterKeyException();
        }

        public void TryAddCategory(Category c)
        {
            foreach(Category n in this.Categories)
            {
                CategoryComparison(c.Name, n.Name);
            }
            this.Categories.Add(c);
        }


        public void TryModifyCategory(Category toChange, string v)
        {
            foreach(Category c in this.Categories)
            {
                if(toChange != c)
                {
                    CategoryComparison(c.Name, v);
                }
            }
            toChange.ModifyCategory(v);
        }

        private static void CategoryComparison(String c, String n)
        {
            if (c.ToUpper() == n.ToUpper())
            {
                throw new ExistentCategoryNameException();
            }
        }

        public void TryAddAccount(Account a)
        {
            foreach (Account acc in this.Accounts)
            {
                AccountsComparison(acc, a);

            }
            this.Accounts.Add(a);
            this.ColorCount[(int)a.Classification]++;
        }

        public void TryModifyAccount(Account account, Account modificationAccount)
        {
            foreach (Account acc in this.Accounts)
            {
                if (account != acc)
                {
                    AccountsComparison(acc, modificationAccount);
                }
            }
            account.ModifyAccount(modificationAccount);
        }

        private void AccountsComparison(Account a, Account b)
        {
            if (a.Equals(b))
                throw new ExistentAccountException();
        }

        public void TryRemoveAccount(Account a)
        {
            if (this.Accounts.Contains(a))
            {
                this.Accounts.Remove(a);
                this.ColorCount[(int)a.Classification]--;
            }
            else
                throw new InexistentAccountException();
        }

        public void TryAddCreditCard(CreditCard cc)
        {
            foreach(CreditCard c in this.CreditCards)
            {
                CreditCardComparison(cc, c);
            }
            this.CreditCards.Add(cc);
        }

        

        public void TryModifyCreditCard(CreditCard creditCard, CreditCard modifiedCreditCard)
        {
            foreach(CreditCard c in this.CreditCards)
            {
                if (c != creditCard)
                    CreditCardComparison(c, modifiedCreditCard);
            }
            creditCard.ModifyCreditCard(modifiedCreditCard);
        }

        private static void CreditCardComparison(CreditCard cc, CreditCard c)
        {
            if (c.Equals(cc))
                throw new ExistentCreditCardException();
        }

        public void TryRemoveCreditCard(CreditCard cc)
        {
            if (this.CreditCards.Contains(cc))
            {
                this.CreditCards.Remove(cc);
            }
            else
                throw new InexistentCreditCardException();
        }
        
        public List<Account> FilterBy(Account.Color classification)
        {
            List<Account> filteredAccounts = new List<Account>();
            foreach(Account a in this.Accounts)
            {
                if (a.Classification == classification)
                    filteredAccounts.Add(a);
            }
            return filteredAccounts;
        }

        
    }
}