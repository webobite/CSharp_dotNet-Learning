namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assignment 3
            /**
             * 
                Statics, contructor
                Write a Singleton class called Counter. It will have two functions Increment and Decrement that will increase and decrease the count respectively.
                It has one property called count that returns the current counter. The class will have one static getinstance method to return the instance of Counter. 
                Singleton typically means that only one instance of the class can be created.
             */
            Console.WriteLine("Program starting...");
            Counter counter1 = Counter.GetCounterInstance();
            Counter counter2 = Counter.GetCounterInstance();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Increment with counter-1 by 5 : " + counter1.Increment(5));
                Console.WriteLine("Decrement with counter-2 by 3 : " + counter2.Decrement(3));
            }
            Console.ReadLine();

        }
    }
}