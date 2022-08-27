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
            string convertedString = "";
            if (!string.IsNullOrEmpty(inputString) && int.TryParse(inputString, out _))
            {
                convertedString = "$" + inputString;
                return convertedString;
            }
            else
            {
                throw new ArgumentException("Parameter cannot be null or words which cannot be parsed in Integrer");
            }
        }

    }
}

