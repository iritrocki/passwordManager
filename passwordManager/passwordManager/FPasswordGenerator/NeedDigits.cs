using System.Collections.Generic;

namespace passwordManager
{
    public class NeedDigits : PasswordRequirement
    {
        public override void AsciiRangeInitialization()
        {
            (int, int) range = (48, 58);
            this.AsciiRanges = new List<(int, int)>();
            this.AsciiRanges.Add(range);
        }
    }
}