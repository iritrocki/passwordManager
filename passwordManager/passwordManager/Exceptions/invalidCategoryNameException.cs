using System;

namespace passwordManager.Exceptions
{
    [Serializable]
    public class invalidCategoryNameException : Exception
    {
        private string message;

        public override string Message
        {
            get { return message; }
        }

        public invalidCategoryNameException()
        {
            this.message = "El nombre de la categoría debe tener entre 3 y 15 caracteres.";
        }
    }
}