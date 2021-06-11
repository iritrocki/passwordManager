using System;

namespace passwordManager.Exceptions
{
    [Serializable]
    public class NullListException : Exception
    {
        private string message;

        public override string Message
        {
            get { return message; }
        }

        public NullListException()
        {
            this.message = "La lista ingresada es nula";
        }
    }
}