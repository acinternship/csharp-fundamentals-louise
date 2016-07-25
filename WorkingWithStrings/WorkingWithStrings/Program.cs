using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "My \"so-called\" life";
            //string myString = "What if I need a \nnew line?";
            //string myString = "Go to your c:\\ drive";
            //string myString = @"Go to your c:\ drive";

            //tring myString = "  That summer we took threes across the board";

            //string myString = String.Format("{1} = {0}", "First", "Second");

            //string myString = string.Format("{0 :C}", 123, 45);

            //string myString = string.Format("{0:N}", 123456789);

            //string myString = string.Format("{0:P}", .123);

            //string myString = string.Format("Phone Number: {0:(###) - ### ####}", 123456789);

            /*  for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString();
            }
            */

            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(1);

            }

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
