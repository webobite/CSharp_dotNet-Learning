using DemoClassLibrary;

namespace DemoConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assignment 2
            Console.WriteLine("Program starting...");
            Demo demo = new Demo();
            demo.Message();

            Count countObj = new Count();
            int increaseByFive = countObj.Increment(5);
            int decreaseByOne = countObj.Decrement(1);
            Console.WriteLine($"Increment by 5 : {increaseByFive} ");
            Console.WriteLine($"Decrement by 1 : {decreaseByOne}");
        }
    }
}