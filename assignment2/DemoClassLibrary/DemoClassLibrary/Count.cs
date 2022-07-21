using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Statics, contructor
    Write a Singleton class called Counter. It will have two functions Increment and Decrement that will increase and decrease the count respectively.
    It has one property called count that returns the current counter. The class will have one static getinstance method to return the instance of Counter. 
    Singleton typically means that only one instance of the class can be created.
 */
namespace DemoClassLibrary
{
    public class Count
    {
        protected static readonly int count;

        static Count()
        {
            count = 0;
        }

        public int Increment(int inputIncrement)
        {
            Console.WriteLine("Incrementing value of count value from {0} by {1}", count, inputIncrement);
            return count + inputIncrement;
        }

        public int Decrement(int inputDecrement)
        {
            Console.WriteLine("Decrementing value of count from {0} by {1}", count, inputDecrement);
            return count - inputDecrement;
        }
    }
}
