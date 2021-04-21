using System;

namespace passwordManager
{
    [Serializable]
    public class InvalidCreditCardCompanyException : Exception
    {
        private string message;

        public override string Message
        {
            get { return message; }
        }
        public InvalidCreditCardCompanyException()
        {
            this.message = "La compania debe tener entre 3 y 25 caracteres.";
        }
    }
}