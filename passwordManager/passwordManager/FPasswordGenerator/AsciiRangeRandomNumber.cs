using System;
using System.Collections.Generic;

namespace passwordManager
{
    public class AsciiRangeRandomNumber
    {
        private List<int> _asciiNumbers;
        private Random _random = RandomInstance.GetRandomInstance();
        public int Number { get; set; }

        public AsciiRangeRandomNumber(List<int> numbers)
        {
            this._asciiNumbers = numbers;
            RandomizeNumber();
        }

        public void RandomizeNumber()
        {
            int asciiLetterPosition = _random.Next(0, _asciiNumbers.Count);
            this.Number = _asciiNumbers[asciiLetterPosition];
        }

    }
}