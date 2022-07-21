using System;

namespace csharpAssignmentProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program starting...");
            Console.WriteLine("-------------------");

            Console.Write("Enter String to find its length : ");
            string inputString = Console.ReadLine();
            int result = 0;

            try
            {
                result = LengthHelper.FindStringLengthWithPredefinedMethod(inputString);
                Console.WriteLine("Your result: {0:0.##}\n", result);
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception occured at Main Class : ", e.Message);
            }
        }
    }
}