using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    public class Counter
    {
        private static readonly Counter _counterInstance = new Counter();
        private int count = 0;

        public static Counter GetCounterInstance()
        {
            return _counterInstance;
        }

        public int Increment(int incrementValue)
        {
            return count += incrementValue;
        }

        public int Decrement(int decrementValue)
        {
            if(count == 0) return 0;
            return count -= decrementValue;
        }
    }
}
