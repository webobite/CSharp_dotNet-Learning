using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    public class Program
    {
        static public void Main(String[] args)
        {
            
            Console.WriteLine("Enter the Value : ");
            string str = Console.ReadLine();
            string result = str.ToCurrency();
            Console.WriteLine("RESULT :::: " + result);

            /*
            string str1 = "124";
            string result1 = str1.ToCurrency();
            Console.WriteLine("result1 :"+  result1);
            
            string str2 = "";
            string result2 = str2.ToCurrency();
            Console.WriteLine("result2 :" + result2);

            string str3 = null;
            string result3 = str3.ToCurrency();
            Console.WriteLine("result3 :" + result3);
            */
        }

    }
}

