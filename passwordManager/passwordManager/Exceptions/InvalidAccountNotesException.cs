using System;

namespace passwordManager.Exceptions
{
    [Serializable]
    public class InvalidAccountNotesException : InvalidAccountException
    {
        private string message;

        public override string Message
        {
            get { return message; }
        }

        public InvalidAccountNotesException()
        {
            this.message = "El sitio debe tener entre 3 y 25 caracteres.";
        }
    }
}