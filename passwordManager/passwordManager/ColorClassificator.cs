using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passwordManager
{
    public enum ColorClassification
    {
        Red = 1,
        Orange = 2,
        Yellow = 3,
        LightGreen = 4,
        DarkGreen = 5
    }
    public static class ColorClassificator
    {
        public static ColorClassification ClassifyColor(string password)
        {
            PasswordRequirement upper = new NeedUpperCase();
            PasswordRequirement lower = new NeedLowerCase();
            PasswordRequirement digits = new NeedDigits();
            PasswordRequirement specials = new NeedSpecials();
            if (password.Length < 8)
                return ColorClassification.Red;
            else if (password.Length <= 14)
                return ColorClassification.Orange;
            else
            {
                int cuantity = TypesOfCharacters(password);
                if (cuantity == 1)
                {
                    return ColorClassification.Yellow;
                }
                else if (cuantity == 2)
                {
                    if (lower.ContainsRequirement(password) && upper.ContainsRequirement(password)) return ColorClassification.LightGreen;
                    else return ColorClassification.Yellow;
                }
                else if (cuantity == 3) return ColorClassification.LightGreen;
                else return ColorClassification.DarkGreen;
            }

        }

        private static int TypesOfCharacters(string password)
        {
            int count = 0;
            PasswordRequirement upper = new NeedUpperCase();
            PasswordRequirement lower = new NeedLowerCase();
            PasswordRequirement digits = new NeedDigits();
            PasswordRequirement specials = new NeedSpecials();
            if (upper.ContainsRequirement(password)) count++;
            if (lower.ContainsRequirement(password)) count++;
            if (digits.ContainsRequirement(password)) count++;
            if (specials.ContainsRequirement(password)) count++;

            return count;
        }

        public static int[] PasswordStrengthCount(List<Account> accounts)
        {
            int[] colorCount = new int[Enum.GetValues(typeof(ColorClassification)).Length];
            foreach (Account a in accounts)
            {
                colorCount[(int)a.Classification - 1]++;
            }
            return colorCount;
        }

        public static List<Account> FilterBy(ColorClassification classification, List<Account> accounts)
        {
            List<Account> filteredAccounts = new List<Account>();
            foreach (Account a in accounts)
            {
                if (a.Classification == classification)
                    filteredAccounts.Add(a);
            }
            return filteredAccounts;
        }
    }
}
