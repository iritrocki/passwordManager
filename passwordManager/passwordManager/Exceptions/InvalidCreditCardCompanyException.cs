using System;

namespace passwordManager.Exceptions
{
    [Serializable]
    public class InvalidCreditCardCompanyException : InvalidCreditCardException
    {
        private string message;

        public override string Message
        {
            get { return message; }
        }
        public InvalidCreditCardCompanyException()
        {
            this.message = "La companía debe tener entre 3 y 25 caracteres.";
        }
    }
}