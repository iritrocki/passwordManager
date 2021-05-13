using System;

namespace passwordManager.Exceptions
{
    [Serializable]
    public class InvalidMasterKeyException : Exception
    {
        private string message;

        public override string Message
        {
            get { return message; }
        }

        public InvalidMasterKeyException()
        {
            this.message = "La contraseña ingresada es incorrecta";
        }
    }
}