using System;

namespace passwordManager.Exceptions
{
    [Serializable]
    public class InvalidCreditCardNameException : InvalidCreditCardException
    {
        private string message;

        public override string Message
        {
            get { return message; }
        }
        public InvalidCreditCardNameException()
        {
            this.message = "El nombre debe tener entre 3 y 25 caracteres.";
        }
    }
}