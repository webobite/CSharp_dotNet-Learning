using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpAssignmentProject
{
    /**
     * Assignment - 1 - Write a class LengthHelper with function findLength that takes string as parameter and returns the length of string. This can be a class libarary/console.
     * 
     *   Create a unit test project using Xunit and write test cases to find length of string for "", "123", "123456789010", NULL
     */
    public class LengthHelper
    {
        public static int FindStringLengthWithPredefinedMethod(string inputString)
        {
            try
            {
                if (inputString.GetType() == typeof(string))
                {
                    return inputString.Length;
                }
            } catch(Exception e)
            {
                Console.WriteLine("Exception occured at LengthHelper.FindStringLength : ", e.Message);
                throw new Exception(e.Message);
            }
            // Something needed to be returned
            throw new Exception("Something went wrong !!");

        }

    }
}
