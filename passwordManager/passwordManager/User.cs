
﻿using passwordManager.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

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
            this.ColorCount = new int[Enum.GetValues(typeof(ColorClassification)).Length];
        }

        public int Id { get; set; }


        private string _masterKey;

        public bool Status { get; set; }
        public string MasterKey
        {
            get { return this._masterKey; }
            set
            {
                if (!this.ValidateMasterKey(value))
                    throw new InvalidMasterKeyException();
                else
                    this._masterKey = value;

            }
        }
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

        public void TryAddCategory(Category category)
        {
            foreach(Category cat in this.Categories)
            {
                CategoryComparison(category.Name, cat.Name);
            }
            this.Categories.Add(category);
        }

        public void TryModifyCategory(Category toChange, string name)
        {
            foreach(Category category in this.Categories)
            {
                if(toChange != category)
                {
                    CategoryComparison(category.Name, name);
                }
            }
            toChange.ModifyCategory(name);
        }

        private static void CategoryComparison(String name1, String name2)
        {
            if (name1.ToUpper() == name2.ToUpper())
            {
                throw new ExistentCategoryNameException();
            }
        }

        public void UniqueAccountCheck(Account accountToAdd)
        {
            foreach (Account account in this.Accounts)
            {
                AccountsComparison(account, accountToAdd);

            }
            this.ColorCount[(int)accountToAdd.Classification-1]++;
        }

        public void TryModifyAccount(Account actualAccount, Account modificationAccount)
        {
            foreach (Account account in this.Accounts)
            {
                if (actualAccount != account)
                {
                    AccountsComparison(account, modificationAccount);
                }
            }
            ColorClassification actualColor = actualAccount.Classification;
            this.ColorCount[(int)actualColor - 1]--;
            actualAccount.ModifyAccount(modificationAccount);
            ColorClassification modificationColor = modificationAccount.Classification;
            this.ColorCount[(int)modificationColor - 1]++;
        }

        private void AccountsComparison(Account account1, Account account2)
        {
            if (account1.Equals(account2))
                throw new ExistentAccountException();
        }

        //public void TryRemoveAccount(Account accountToRemove)
        //{
        //    if (this.Accounts.Contains(accountToRemove))
        //    {
        //        this.ColorCount[(int)accountToRemove.Classification-1]--;
        //    }
        //    else
        //        throw new InexistentAccountException();
        //}

        public void TryAddCreditCard(CreditCard creditCardToAdd)
        {
            foreach(CreditCard card in this.CreditCards)
            {
                CreditCardComparison(creditCardToAdd, card);
            }
            this.CreditCards.Add(creditCardToAdd);
        }

        

        public void TryModifyCreditCard(CreditCard actualCreditCard, CreditCard modifiedCreditCard)
        {
            foreach(CreditCard card in this.CreditCards)
            {
                if (card != actualCreditCard)
                    CreditCardComparison(card, modifiedCreditCard);
            }
            actualCreditCard.ModifyCreditCard(modifiedCreditCard);
        }

        private static void CreditCardComparison(CreditCard creditCard1, CreditCard creditCard2)
        {
            if (creditCard1.Equals(creditCard2))
                throw new ExistentCreditCardException();
        }

        public void TryRemoveCreditCard(CreditCard creditCardToRemove)
        {
            if (this.CreditCards.Contains(creditCardToRemove))
            {
                this.CreditCards.Remove(creditCardToRemove);
            }
            else
                throw new InexistentCreditCardException();
        }
        
        public List<Account> FilterBy(ColorClassification classification)
        {
            List<Account> filteredAccounts = new List<Account>();
            foreach(Account a in this.Accounts)
            {
                if (a.Classification == classification)
                    filteredAccounts.Add(a);
            }
            return filteredAccounts;
        }


        public bool ValidateMasterKey(string masterKey)
        {
            if (masterKey.Length >= 5 && masterKey.Length <= 25)
                return true;
            else
                return false;
        }
    }
}