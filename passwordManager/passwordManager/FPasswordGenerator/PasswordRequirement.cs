
using System.Collections.Generic;
using System.Linq;

namespace passwordManager
{
    public abstract class PasswordRequirement
    {
        public List<int> AsciiNumbers { get; set; }
        public List<(int, int)> AsciiRanges { get; set; }

        public PasswordRequirement()
        {
            this.AsciiNumbers = new List<int>();
            this.AsciiRanges = new List<(int, int)>();
            AsciiRangeInitialization();
            ChargeAsciiList();
            
        }

        public void ChargeAsciiList()
        {
            foreach ((int, int) pair in this.AsciiRanges)
            {
                this.AsciiNumbers.AddRange(Enumerable.Range(pair.Item1, (pair.Item2 - pair.Item1)));
            }

        }

        public abstract void AsciiRangeInitialization();

        public char GenerateCharacter()
        {
            AsciiRangeRandomNumber rdm = new AsciiRangeRandomNumber(AsciiNumbers);
            return (char)rdm.Number;
        }

        public bool ContainsRequirement(string password)
        {
            foreach ((int, int) pair in this.AsciiRanges)
            {
                if (ContainsCharBetweenAsciiValues(password, pair))
                    return true;
            }
            return false;
        }

        private static bool ContainsCharBetweenAsciiValues(string password, (int,int) range)
        {
            foreach (char n in password)
            {
                int asciiValue = (int)n;
                if (asciiValue >= range.Item1 && asciiValue < range.Item2)
                    return true;
            }
            return false;
        }

        

    }
}