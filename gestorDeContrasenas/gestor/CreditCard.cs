using System;

namespace passwordManager
{
    public class CreditCard
    {
        public string name { 
            get => name;
            set 
            {
                if (!this.validateText(value))
                    throw new InvalidCreditCardNameException();
                name = value;
            } 
        }
        public string company { get; set; }
        public string number { 
            get => number;
            set
            {
                if (!this.validateNumber(value))
                    throw new InvalidCreditCardNumberException();
                number = value;
            }
            }
        public string code { 
            get => code;
            set 
            {
                if (!this.validateCode(value))
                    throw new InvalidCreditCardCodeException();
                code = value;
            } 
        }

        public bool validateNumber(string number)
        {
            string[] subs = number.Split(' ');
            int caracteres = 0;
            foreach(string s in subs)
            {
                caracteres += s.Length;
            }
            if(caracteres == 16)
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
            if(v.Length >= 3 && v.Length <= 25)
                return true;
            return false;
        }
    }
}