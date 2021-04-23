using passwordManager.Exceptions;
using System;

namespace passwordManager
{
    public class Account : DataUnit
    {
        private string _username;
        private string _site;
        private string _note;
        private DateTime _modification;
        public string Username { 
            get { return this._username; }
            set 
            {
                if (!this.ValidateUsernameAndPassword(value))
                    throw new InvalidAccountUsernameException();
                _username = value;
            } }
        public Password Password { get; set; }
        
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
        

        public bool ValidateUsernameAndPassword(string s)
        {
            if (s.Length >= 5 && s.Length <= 25)
                return true;
            return false;
        }

        public bool ValidateSite(string v)
        {
            if (v.Length >= 3 && v.Length <= 25)
                return true;
            return false;
        }

        public bool ValidateNotes(string v)
        {
            if (v.Length > 250)
                return false;
            return true;
        }
    }
}