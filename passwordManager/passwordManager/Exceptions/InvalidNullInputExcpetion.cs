
using System;

namespace passwordManager.Exceptions
{
    [Serializable]
    public class InvalidNullInputExcpetion : Exception
    {
        private string message;

        public override string Message
        {
            get { return message; }
        }

        public InvalidNullInputExcpetion()
        {
            this.message = "La categoría no puede ser nula";
        }
    }
}