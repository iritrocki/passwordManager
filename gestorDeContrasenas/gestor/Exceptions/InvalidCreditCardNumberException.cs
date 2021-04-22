using System;

namespace passwordManager
{
    [Serializable]
    public class InvalidCreditCardNumberException : Exception
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