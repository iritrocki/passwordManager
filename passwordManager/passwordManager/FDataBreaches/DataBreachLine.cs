using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passwordManager
{
    public class DataBreachLine
    {
        public string Line { get; set; }

        public int Id { get; set; }

        public DataBreachLine(string line)
        {
            this.Line = line;
        }
    }
}
