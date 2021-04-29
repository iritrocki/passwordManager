using System;

namespace passwordManager.Exceptions
{
    [Serializable]
    public class InvalidSelectionForPasswordException : InvalidAccountException
    {
        private string message;

        public override string Message
        {
            get { return message; }
        }

        public InvalidSelectionForPasswordException()
        {
            this.message = "Debe seleccionar al menos un campo de condiciones para crear su contrasena";
        }
    }
}