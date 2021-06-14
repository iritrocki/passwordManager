using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passwordManager
{
    public class RandomInstance
    {
        private static Random _randomInstance = null;

        public static Random GetRandomInstance()
        {
            if(_randomInstance == null)
            {
                _randomInstance = new Random();
            }
            return _randomInstance;
        }
    }
}
