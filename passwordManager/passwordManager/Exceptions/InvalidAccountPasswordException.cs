using System;

namespace passwordManager.Exceptions
{
    [Serializable]
    public class InvalidAccountPasswordException : InvalidAccountException
    {
        private string message;

        public override string Message
        {
            get { return message; }
        }

        public InvalidAccountPasswordException()
        {
            this.message = "La contraseña debe tener entre 5 y 25 caracteres.";
        }
    }
}