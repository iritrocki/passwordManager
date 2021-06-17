using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passwordManager
{
    public static class Validator
    {
        public static bool ValidateStringLength(string s, (int, int) range)
        {
            if (s.Length >= range.Item1 && s.Length <= range.Item2)
                return true;
            return false;
        }

        public static bool ValidateCreditCardNumber(string number)
        {
            foreach (char character in number)
            {
                if (!(IsADigit(character) || IsASpace(character)))
                    return false;
            }
            string[] subs = number.Split(' ');
            if (subs.Length != 4)
            {
                return false;
            }
            foreach (string s in subs)
            {
                if (s.Length != 4)
                    return false;

            }

            return true;
        }

        public static bool IsASpace(char character)
        {
            return (int)character == 32;
        }

        public static bool ValidateCreditCardCode(string code)
        {
            if (code.Length == 3 || code.Length == 4)
            {
                foreach (char i in code)
                {
                    if (!(IsADigit(i)))
                    {
                        return false;
                    }

                }
                return true;
            }
            return false;
        }

        public static bool ValidateExpirationMonth(int month)
        {
            if (month >= 1 && month <= 12)
                return true;
            return false;
        }

        public static bool ValidateExpirationYear(int year)
        {
            if (year > 1000 && year < 10000)
                return true;
            return false;
        }

        public static bool ValidateExpirationDateInput(string date)
        {
            foreach (char character in date)
            {
                if (!(IsADigit(character) || IsASlash(character)))
                    return false;
            }
            string[] subs = date.Split('/');
            if (subs.Length != 2)
            {
                return false;
            }
            return true;
        }

        public static bool IsASlash(char character)
        {
            return (int)character == 47;
        }

        public static bool IsADigit(char character)
        {
            return (int)character >= 48 && (int)character <= 57;
        }

    }
}

