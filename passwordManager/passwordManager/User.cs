
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

        public bool Status { get; set; }
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
            this.ColorCount[(int)a.Classification-1]++;
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
                this.ColorCount[(int)a.Classification-1]--;
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

        public string GeneratePassword(int length, bool upper, bool lower, bool digits, bool specials)
        {
            if (upper || lower || digits || specials)
            {
                int cont = 0;
                string password = "";
                List<int> ASCII_numbers = new List<int>();
                Random rdm = new Random();
                if (upper)
                {
                    ASCII_numbers.AddRange(Enumerable.Range(65, (91 - 65)));
                    int asciiLetterCode = rdm.Next(65, 91);
                    password = password.Insert(0, ((char)asciiLetterCode).ToString());
                    cont++;
                }
                if (lower)
                {
                    ASCII_numbers.AddRange(Enumerable.Range(97, (123 - 97)));
                    int asciiLetterCode = rdm.Next(97, 123);
                    int position = rdm.Next(0, password.Length);
                    password = password.Insert(position, ((char)asciiLetterCode).ToString());
                    cont++;
                }
                if (digits)
                {
                    ASCII_numbers.AddRange(Enumerable.Range(48, (58 - 48)));
                    int asciiLetterCode = rdm.Next(48, 58);
                    int position = rdm.Next(0, password.Length);
                    password = password.Insert(position, ((char)asciiLetterCode).ToString());
                    cont++;
                }
                if (specials)
                {
                    ASCII_numbers.AddRange(Enumerable.Range(32, (48 - 32)));
                    ASCII_numbers.AddRange(Enumerable.Range(58, (65 - 58)));
                    ASCII_numbers.AddRange(Enumerable.Range(91, (97 - 91)));
                    ASCII_numbers.AddRange(Enumerable.Range(123, (127 - 123)));

                    int[] randomNumbersEspeciales = new int[] { rdm.Next(32, 48), rdm.Next(58, 65), rdm.Next(91, 97), rdm.Next(123, 127) };
                    int posArray = rdm.Next(0, randomNumbersEspeciales.Length);

                    int asciiLetterCode = randomNumbersEspeciales[posArray];
                    int position = rdm.Next(0, password.Length);

                    password = password.Insert(position, ((char)asciiLetterCode).ToString());
                    cont++;
                }
                for (int i = cont; i < length; i++)
                {

                    int index = rdm.Next(0, ASCII_numbers.Count);
                    int asciiLetterCode = ASCII_numbers[index];
                    int position = rdm.Next(0, (cont - 1));
                    password = password.Insert(position, ((char)asciiLetterCode).ToString());
                    cont++;
                }

                return password;
            }
            else
                throw new InvalidSelectionForPasswordException();
        }
    }
}