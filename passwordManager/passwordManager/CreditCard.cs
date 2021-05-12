using passwordManager.Exceptions;
using System;

namespace passwordManager
{
    public class CreditCard : DataUnit
    {
        private string _name;
        private string _company;
        private string _number;
        private string _code;
        private int _expirationMonth;
        private int _expirationYear;
        private string _notes;
        public string Name
        {
            get { return this._name; }
            set
            {
                if (!this.ValidateText(value))
                    throw new InvalidCreditCardNameException();
                this._name = value;
            }
        }
        public string Company {
            get { return this._company; }
            set
            {
                if (!this.ValidateText(value))
                    throw new InvalidCreditCardCompanyException();
                this._company = value;
            }
        }
        public string Number
        {
            get { return this._number; }
            set
            {
                if (!this.ValidateNumber(value))
                    throw new InvalidCreditCardNumberException();
                this._number = value;
            }
        }
        public string Code
        {
            get {return this._code;}
            set
            {
                if (!this.ValidateCode(value))
                    throw new InvalidCreditCardCodeException();
                this._code = value;
            }
        }

        public int ExpirationMonth {
            get { return this._expirationMonth; }
            set 
            {
                if (!this.ValidateExpirationMonth(value))
                    throw new InvalidCreditCardExpirationDateException();
                this._expirationMonth = value;
            }
        }
        public int ExpirationYear {
            get { return this._expirationYear; }
            set
            {
                if (!this.ValidateExpirationYear(value))
                    throw new InvalidCreditCardExpirationDateException();
                this._expirationYear = value;
            }
        }

        public string Notes {
            get {return this._notes; }
            set {
               if (!this.ValidateNotes(value))
                    throw new InvalidCreditCardNotesException();
                this._notes = value;
            } }

        public bool ValidateNumber(string number)
        {
            string[] subs = number.Split(' ');
            int caracteres = 0;
            foreach (string s in subs)
            {
                caracteres += s.Length;
                foreach (char digit in s)
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

        public bool ValidateCode(string code)
        {
            if (code.Length == 3 || code.Length == 4)
            {
                foreach(char i in code)
                {
                    if((int)i < 48 || (int)i > 57)
                    {
                        return false;
                    }

                }
                return true;
            }
            return false;
        }

        public bool ValidateText(string text)
        {
            if (text.Length >= 3 && text.Length <= 25)
                return true;
            return false;
        }

        public bool ValidateExpirationYear(int year)
        {
            if(year > 1000 && year < 10000)
                return true;
            return false;
        }

        public bool ValidateExpirationMonth(int month)
        {
            if (month >= 1 && month <= 12)
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
            return base.Equals(obj as CreditCard);
        }

        public bool Equals(CreditCard creditCard)
        {
            return this.Number == creditCard.Number;
        }

        public void ModifyCreditCard(CreditCard newCreditCard)
        {
            this.Name = newCreditCard.Name;
            this.Company = newCreditCard.Company;
            this.Number = newCreditCard.Number;
            this.Notes = newCreditCard.Notes;
            this.ExpirationMonth = newCreditCard.ExpirationMonth;
            this.ExpirationYear = newCreditCard.ExpirationYear;
            this.Code = newCreditCard.Code;
        }

        public override string ToString()
        {
            return string.Format("[{0}] [{1}] [{2}]", this.Name, this.Company, this.Number);
        }

        ~CreditCard(){ }


    }
}