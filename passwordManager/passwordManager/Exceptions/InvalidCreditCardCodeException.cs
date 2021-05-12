using System;

namespace passwordManager.Exceptions
{
    [Serializable]
    public class InvalidCreditCardCodeException : InvalidCreditCardException
    {
        private string message;

        public override string Message
        {
            get { return message; }
        }
        public InvalidCreditCardCodeException()
        {
            this.message = "El código de seguridad debe tener 3 o 4 dígitos.";
        }
    }
}