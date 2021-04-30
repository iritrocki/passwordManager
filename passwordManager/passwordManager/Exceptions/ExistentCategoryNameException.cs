using System;

namespace passwordManager.Exceptions
{
    [Serializable]
    public class ExistentCategoryNameException: Exception
    {
        private string message;

        public override string Message
        {
            get { return message; }
        }

        public ExistentCategoryNameException()
        {
            this.message = "Ya existe una categoria con ese nombre.";
        }
    }
}