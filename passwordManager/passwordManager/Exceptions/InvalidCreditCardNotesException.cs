using System;

namespace passwordManager.Exceptions
{
    [Serializable]
    public class InvalidCreditCardNotesException : InvalidCreditCardException
    {
        private string message;

        public override string Message
        {
            get { return message; }
        }
        public InvalidCreditCardNotesException()
        {
            this.message = "Las notas exceden los 250 caracteres permitidos.";
        }
    }
}