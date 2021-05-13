using System;

namespace passwordManager.Exceptions
{
    [Serializable]
    public class ExistentAccountException: InvalidAccountException
    {
        private string message;

        public override string Message
        {
            get { return message; }
        }

        public ExistentAccountException()
        {
            this.message = "Ya existe una contraseña para el usuario y sitio ingresados.";
        }
    }
}