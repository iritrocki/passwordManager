using passwordManager.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace passwordManager
{
    public enum ColorClassification
    {
        Red = 1,
        Orange = 2,
        Yellow = 3,
        LightGreen = 4,
        DarkGreen = 5
    }
    public class Account : DataUnit
    {
        
        private string _username;
        private string _password;
        private string _site;
        private string _note;
        private DateTime _modification;
        public string Username { 
            get { return this._username; }
            set 
            {
                if (!this.ValidateUsernameAndPassword(value))
                    throw new InvalidAccountUsernameException();
                this._username = value;
            } }
        public string Password {
            get { return this._password; } 
            set
            {
                if (!this.ValidateUsernameAndPassword(value))
                    throw new InvalidAccountPasswordException();
                ClassifyColor(value);
                this._password = value;

            }
        }

        private void ClassifyColor(string password)
        {
            if (password.Length < 8)
                this.Classification = ColorClassification.Red;
            else if (password.Length <= 14)
                this.Classification = ColorClassification.Orange;
            else
            {
                int cuantity = TypesOfCharacters(password);
                if (cuantity == 1)
                {
                    this.Classification = ColorClassification.Yellow;
                }
                else if (cuantity == 2)
                {
                    if (this.ContainsLowerCase(password) && this.ContainsUpperCase(password)) this.Classification = ColorClassification.LightGreen;
                    else this.Classification = ColorClassification.Yellow;
                }
                else if (cuantity == 3) this.Classification = ColorClassification.LightGreen;
                else this.Classification = ColorClassification.DarkGreen;
            }

        }

        private int TypesOfCharacters(string password)
        {
            int count = 0;
            if (this.ContainsUpperCase(password)) count++;
            if (this.ContainsLowerCase(password)) count++;
            if (this.ContainsDigits(password)) count++;
            if (this.ContainsSpecials(password)) count++;

            return count;
        }

        public string Site {
            get { return this._site; }
            set {
                if (!this.ValidateSite(value))
                    throw new InvalidAccountSiteException();
                this._site = value;
            } 
        }
        
        public string Note {
            get { return this._note; }
            set {
                if (!this.ValidateNotes(value))
                    throw new InvalidAccountNotesException();
                this._note = value;
            }
        }
        public DateTime Modification { get; set; }
        public ColorClassification Classification { get; set; }

        public bool ValidateUsernameAndPassword(string password)
        {
            if (password.Length >= 5 && password.Length <= 25)
                return true;
            return false;
        }

        public bool ValidateSite(string site)
        {
            if (site.Length >= 3 && site.Length <= 25)
                return true;
            return false;
        }

        public bool ValidateNotes(string note)
        {
            if (note.Length > 250)
                return false;
            return true;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj as Account);
        }

        public bool Equals(Account account)
        {
            return this.Username == account.Username && this.Site == account.Site;
        }

        

        public bool ContainsUpperCase(string password)
        {
            return ContainsCharBetweenAsciiValues(password, 65, 90);
        }

        public bool ContainsLowerCase(string password)
        {
            return ContainsCharBetweenAsciiValues(password, 97, 122);
        }
        
        public bool ContainsSpecials(string password)
        {
            return ContainsCharBetweenAsciiValues(password, 32, 47) || ContainsCharBetweenAsciiValues(password, 58, 64) || ContainsCharBetweenAsciiValues(password, 91, 96) || ContainsCharBetweenAsciiValues(password, 123, 126);
        }

        public bool ContainsDigits(string password)
        {
            return ContainsCharBetweenAsciiValues(password, 48, 57);
        }

        private static bool ContainsCharBetweenAsciiValues(string password, int value1, int value2)
        {
            foreach (char n in password)
            {
                int asciiValue = (int)n;
                if (asciiValue >= value1 && asciiValue <= value2)
                    return true;
            }
            return false;
        }

        public void ModifyAccount(Account newAccount)
        {
            this.Username = newAccount.Username;
            this.Password = newAccount.Password;
            this.Site = newAccount.Site;
            this.Note = newAccount.Note;
            this.Modification = DateTime.Now;
        }

        public override string ToString()
        {
            return string.Format("[{0}] [{1}] [{2}]", this.Category.Name, this.Site, this.Username);
        }

        ~Account() { }

    }
}