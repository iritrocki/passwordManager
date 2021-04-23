using System;

namespace passwordManager.Exceptions
{
    [Serializable]
    public class InvalidAccountUsernameException : InvalidAccountException
    {
        private string message;

        public override string Message
        {
            get { return message; }
        }

        public InvalidAccountUsernameException()
        {
            this.message = "El usuario debe tener entre 5 y 25 caracteres.";
        }
    }
}