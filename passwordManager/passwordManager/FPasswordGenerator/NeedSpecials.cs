using System.Collections.Generic;

namespace passwordManager
{
    public class NeedSpecials : PasswordRequirement
    {
        public override void AsciiRangeInitialization()
        {
            (int, int) range1 = (32, 48);
            (int, int) range2 = (58, 65);
            (int, int) range3 = (91, 97);
            (int, int) range4 = (123, 127);
            this.AsciiRanges = new List<(int, int)>();
            this.AsciiRanges.Add(range1);
            this.AsciiRanges.Add(range2);
            this.AsciiRanges.Add(range3);
            this.AsciiRanges.Add(range4);
        }
    }
}