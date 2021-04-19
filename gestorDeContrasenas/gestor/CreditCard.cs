using System;

namespace gestor
{
    public class CreditCard
    {
        public string name { get; set; }
        public string company { get; set; }
        public string number { get; set; }
        public string code { get; set; }

        public bool validateNumber(string number)
        {
            string[] subs = number.Split(' ');
            int caracteres = 0;
            foreach(string s in subs)
            {
                caracteres += s.Length;
            }
            if(caracteres == 16)
                return true;
            return false;
        }

        public bool validateCode(string code)
        {
            if (code.Length < 3)
                return false;
            return true;
        }
    }
}