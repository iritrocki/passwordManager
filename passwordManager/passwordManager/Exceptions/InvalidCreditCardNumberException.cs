using System;

namespace passwordManager.Exceptions
{
    [Serializable]
    public class InvalidCreditCardNumberException : InvalidCreditCardException
    {
        private string message;

        public override string Message
        {
            get { return message; }
        }
        public InvalidCreditCardNumberException()
        {
            this.message = "El numero debe tener 16 digitos.";
        }
    }
}