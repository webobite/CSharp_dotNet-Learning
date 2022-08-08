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
            Console.WriteLine("Increment with counter1 : " + counter1.Increment(6));
            Console.WriteLine("Increment with counter2 : " + counter2.Increment(9));
            Console.WriteLine("Increment with counter1 : " + counter1.Increment(9));
            Console.WriteLine("Decrement with counter2 : " + counter2.Decrement(9));
            Console.WriteLine("Decrement with counter1 : " + counter1.Decrement(7));
            Console.WriteLine("Decrement with counter2 : " + counter2.Decrement(8));
            Console.ReadLine();

        }
    }
}