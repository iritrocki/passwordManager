using System;

namespace passwordManager.Exceptions
{
    [Serializable]
    public class InvalidCreditCardExpirationDateException : InvalidCreditCardException
    {
        private string message;

        public override string Message
        {
            get { return message; }
        }
        public InvalidCreditCardExpirationDateException()
        {
            this.message = "La fecha de vencimiento no es valida.";
        }

    }
}