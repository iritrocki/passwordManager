using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passwordManager.Exceptions
{
    [Serializable]
    public abstract class InvalidCreditCardException : Exception
    {
        private string message;
        public override string Message
        {
            get { return message; }
        }
        public InvalidCreditCardException()
        {
        }
    }
}
