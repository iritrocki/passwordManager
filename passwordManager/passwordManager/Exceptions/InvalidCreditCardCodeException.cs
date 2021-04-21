using System;

namespace passwordManager
{
    [Serializable]
    public class InvalidCreditCardCodeException : Exception
    {
        private string message;

        public override string Message
        {
            get { return message; }
        }
        public InvalidCreditCardCodeException()
        {
            this.message = "El codigo de seguridad debe tener 3 o 4 digitos.";
        }
    }
}