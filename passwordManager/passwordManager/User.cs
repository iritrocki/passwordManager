
﻿using passwordManager.Exceptions;
using System;
using System.Collections.Generic;

﻿using System.Collections.Generic;


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
                if(c.Name.ToUpper() == n.Name.ToUpper())
                {
                    throw new ExistentCategoryNameException();
                }
            }
            this.Categories.Add(c);
        }

        public void TryAddAccount(Account a)
        {
            foreach(Account acc in this.Accounts)
            {
                if (acc.Site == a.Site && acc.Username == a.Username)
                    throw new ExistentAccountException();
            }
            this.Accounts.Add(a);
            this.ColorCount[(int)a.Classification] ++;
        }


        public void TryAddCreditCard(CreditCard cc)
        {
            foreach(CreditCard c in this.CreditCards)
            {
                if(c.Number == cc.Number)
                    throw new ExistentCreditCardException();
            }
            this.CreditCards.Add(cc);
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