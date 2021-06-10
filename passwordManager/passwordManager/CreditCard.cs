using passwordManager.Exceptions;
using System;
using System.Collections.Generic;

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

        public int Id { get; set; }

        public List<DataBreachCheck> dataBreaches { get; set; }

        public string Name
        {
            get { return this._name; }
            set
            {
                if (!Validator.ValidateStringLength(value, (3, 25)))
                    throw new InvalidCreditCardNameException();
                this._name = value;
            }
        }
        public string Company {
            get { return this._company; }
            set
            {
                if (!Validator.ValidateStringLength(value, (3, 25)))
                    throw new InvalidCreditCardCompanyException();
                this._company = value;
            }
        }
        public string Number
        {
            get { return this._number; }
            set
            {
                if (!Validator.ValidateCreditCardNumber(value))
                    throw new InvalidCreditCardNumberException();
                this._number = value;
            }
        }
        public string Code
        {
            get {return this._code;}
            set
            {
                if (!Validator.ValidateCreditCardCode(value))
                    throw new InvalidCreditCardCodeException();
                this._code = value;
            }
        }

        public int ExpirationMonth {
            get { return this._expirationMonth; }
            set 
            {
                if (!Validator.ValidateExpirationMonth(value))
                    throw new InvalidCreditCardExpirationDateException();
                this._expirationMonth = value;
            }
        }
        public int ExpirationYear {
            get { return this._expirationYear; }
            set
            {
                if (!Validator.ValidateExpirationYear(value))
                    throw new InvalidCreditCardExpirationDateException();
                this._expirationYear = value;
            }
        }

        public void SetExpirationDate(string date)
        {
            
            if (!Validator.ValidateExpirationDateInput(date))
                throw new InvalidCreditCardExpirationDateException();
            string[] expirationDate = date.Split('/');
            this.ExpirationMonth = Int32.Parse(expirationDate[0]);
            this.ExpirationYear = Int32.Parse(expirationDate[1]);
            
        }

        public string Notes {
            get {return this._notes; }
            set {
               if (!Validator.ValidateStringLength(value, (0,250)))
                    throw new InvalidCreditCardNotesException();
                this._notes = value;
            } 
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
            this.Category = newCreditCard.Category;
        }

        public override string ToString()
        {
            return string.Format("[{0}] [{1}] [{2}]", this.Name, this.Company, this.Number);
        }

        ~CreditCard(){ }


    }
}