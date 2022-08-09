using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    public class Counter
    {
        private static readonly Counter _counterInstance;
        private int count = 0;

        //note : https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-constructors
        // Static constructor to initialize the static variable.
        // It is invoked before the first instance constructor is 
        static Counter()
        {
            _counterInstance = new Counter();
            Console.WriteLine("Intance initialized");
        }

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
