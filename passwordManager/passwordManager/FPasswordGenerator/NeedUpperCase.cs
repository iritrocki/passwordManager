using System;
using System.Collections.Generic;
using System.Linq;

namespace passwordManager
{
    public class NeedUpperCase: PasswordRequirement
    {

        public override void AsciiRangeInitialization()
        {
            (int, int) range = (65, 91);
            this.AsciiRanges = new List<(int, int)>();
            this.AsciiRanges.Add(range);
        }


    }
}