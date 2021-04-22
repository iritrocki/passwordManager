using passwordManager.Exceptions;
using System;

namespace passwordManager
{
    public class CreditCard : DataUnit
    {
        public string name
        {
            get => name;
            set
            {
                if (!this.validateText(value))
                    throw new InvalidCreditCardNameException();
                name = value;
            }
        }
        public string company { 
            get => company;
            set
            {
                if (!this.validateText(value))
                    throw new InvalidCreditCardCompanyException();
                company = value;
            }
        }
        public string number
        {
            get => number;
            set
            {
                if (!this.validateNumber(value))
                    throw new InvalidCreditCardNumberException();
                number = value;
            }
        }
        public string code
        {
            get => code;
            set
            {
                if (!this.validateCode(value))
                    throw new InvalidCreditCardCodeException();
                code = value;
            }
        }

        public int expirationMonth { 
            get => expirationMonth;
            set 
            {
                if (!this.validateExpirationMonth(value))
                    throw new InvalidCreditCardExpirationDateException();
                expirationMonth = value;
            }
        }
        public int expirationYear {
            get => expirationYear;
            set
            {
                if (!this.validateExpirationYear(value))
                    throw new InvalidCreditCardExpirationDateException();
                expirationYear = value;
            }
        }

        public string notes { 
            get => notes;
            set {
               if (!this.validateNotes(value))
                    throw new InvalidCreditCardNotesException();
                notes = value;
            } }

        public bool validateNumber(string number)
        {
            string[] subs = number.Split(' ');
            int caracteres = 0;
            foreach (string s in subs)
            {
                caracteres += s.Length;
            }
            if (caracteres == 16)
                return true;
            return false;
        }

        public bool validateCode(string code)
        {
            if (code.Length == 3 || code.Length == 4)
                return true;
            return false;
        }

        public bool validateText(string v)
        {
            if (v.Length >= 3 && v.Length <= 25)
                return true;
            return false;
        }

        public bool validateExpirationYear(int year)
        {
            if(year > 1000 && year < 10000)
                return true;
            return false;
        }

        public bool validateExpirationMonth(int month)
        {
            if (month >= 1 && month <= 12)
                return true;
            return false;
        }

        public bool validateNotes(string note)
        {
            if (note.Length > 250)
                return false;
            return true;
        }


    }
}