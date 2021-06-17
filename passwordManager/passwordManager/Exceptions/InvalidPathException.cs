using System;

namespace passwordManager.Exceptions
{
    [Serializable]
    public class InvalidPathException:Exception
    {
        private string message;

        public override string Message
        {
            get { return message; }
        }
        public InvalidPathException()
        {
            this.message = "El directorio ingresado no es válido.";
        }
    }
}