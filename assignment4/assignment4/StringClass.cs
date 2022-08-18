using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    public static class StringHelper
    {
        public static string ToCurrency(this string inputString)
        {
            try
            {
                if (!string.IsNullOrEmpty(inputString))
                {
                    if(int.TryParse(inputString, out _))
                    {
                        return "$" + inputString;
                    } else
                    {
                        throw new Exception("Input string value is not correct");
                    }
                } else
                {
                    throw new Exception("Input string is either null or empty");
                }
            } catch(Exception e) { throw new Exception(e.Message); }
            
        }

    }
}

