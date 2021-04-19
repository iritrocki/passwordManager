using System;

namespace gestor
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
            this.message = "El nombre de la categoria debe tener entre 3 y 15 caracteres.";
        }
    }
}