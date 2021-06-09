using passwordManager.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace passwordManager
{
    
    public class Account : DataUnit
    {
        public Account() { }
        
        private string _username;
        private string _password;
        private string _site;
        private string _note;
        private DateTime _modification;

        public int Id { get; set; }

        public string Username { 
            get { return this._username; }
            set 
            {
                if (!Validator.ValidateStringLength(value, (5, 25)))
                    throw new InvalidAccountUsernameException();
                this._username = value;
            } 
        }

        public string Password {
            get { return this._password; } 
            set
            {
                if (!Validator.ValidateStringLength(value, (5, 25)))
                    throw new InvalidAccountPasswordException();
                this.Classification = ColorClassificator.ClassifyColor(value);
                this._password = value;

            }
        }

        public string Site {
            get { return this._site; }
            set {
                if (!Validator.ValidateStringLength(value, (3, 25)))
                    throw new InvalidAccountSiteException();
                this._site = value;
            } 
        }
        
        public string Note {
            get { return this._note; }
            set {
                if (!Validator.ValidateStringLength(value, (0, 250)))
                    throw new InvalidAccountNotesException();
                this._note = value;
            }
        }
        public DateTime Modification { get; set; }

        public ColorClassification Classification { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj as Account);
        }

        public bool Equals(Account account)
        {
            return this.Username == account.Username && this.Site == account.Site;
        }


        public void ModifyAccount(Account newAccount)
        {
            this.Username = newAccount.Username;
            this.Password = newAccount.Password;
            this.Site = newAccount.Site;
            this.Note = newAccount.Note;
            this.Modification = DateTime.Now;
            this.Category = newAccount.Category;
        }

        public override string ToString()
        {
            return string.Format("[{0}] [{1}] [{2}]", this.Category.Name, this.Site, this.Username);
        }

        ~Account() { }

    }
}