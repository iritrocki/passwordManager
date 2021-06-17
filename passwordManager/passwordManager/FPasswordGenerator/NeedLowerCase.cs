using System.Collections.Generic;

namespace passwordManager
{
    public class NeedLowerCase : PasswordRequirement
    {
        public override void AsciiRangeInitialization()
        {
            (int, int) range = (97, 123);
            this.AsciiRanges = new List<(int, int)>();
            this.AsciiRanges.Add(range);
        }
    }
}