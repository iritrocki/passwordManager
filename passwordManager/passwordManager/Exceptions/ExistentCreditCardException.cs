using System;

namespace passwordManager.Exceptions
{
    [Serializable]
    public class ExistentCreditCardException: InvalidCreditCardException
    {
        private string message;

        public override string Message
        {
            get { return message; }
        }

        public ExistentCreditCardException()
        {
            this.message = "Ya existe una tarjeta con ese numero.";
        }
    }
}