using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int x;
             int y;

             x = 7;
             y = x + 5;

             Console.WriteLine(y);
             Console.ReadLine();
             */

            Console.WriteLine("Tell me you name");
            Console.Write("What's your first name?");
            string myFirstName;
            myFirstName = Console.ReadLine();

            string myLastName;
            Console.Write("Whats your last name?");
            myLastName = Console.ReadLine();

            Console.WriteLine("Hello, " + myFirstName + " " + myLastName);
            Console.ReadLine();


        }
    }
}
