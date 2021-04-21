using System;

namespace passwordManager
{
    [Serializable]
    public class InvalidCreditCardNameException : Exception
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