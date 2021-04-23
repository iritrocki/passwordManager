using System;

namespace passwordManager.Exceptions
{
    [Serializable]
    public class InvalidAccountSiteException : InvalidAccountException
    {
        private string message;

        public override string Message
        {
            get { return message; }
        }

        public InvalidAccountSiteException()
        {
            this.message = "El sitio debe tener entre 3 y 25 caracteres.";
        }
    }
}