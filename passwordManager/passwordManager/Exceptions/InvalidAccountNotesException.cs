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
            this.message = "Las notas exceden los 250 caracteres permitidos.";
        }
    }
}