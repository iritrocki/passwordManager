using System;

namespace passwordManager.Exceptions
{
    [Serializable]
    public class ExistentAccountException: Exception
    {
        private string message;

        public override string Message
        {
            get { return message; }
        }

        public ExistentAccountException()
        {
            this.message = "Ya existe una contrasena para el usuario y sitio ingresados.";
        }
    }
}