using System;
using System.Runtime.Serialization;

namespace passwordManager.Exceptions
{
    [Serializable]
    public class InexistentCreditCardException : Exception
    {
        private string message;
        public override string Message
        {
            get { return message; }
        }
        public InexistentCreditCardException()
        {
        }
    }
}