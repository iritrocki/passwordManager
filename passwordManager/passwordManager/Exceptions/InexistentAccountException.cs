using System;

namespace passwordManager.Exceptions
{
    [Serializable]
    public class InexistentAccountException: Exception
    {
        private string message;
        public override string Message
        {
            get { return message; }
        }
        public InexistentAccountException()
        {
        }
    }
}