using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace AssembleAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {       
            string text = "A class is the most powerful data type in C#. Like a structure, " +
                           "a class defines the data and behavior of the data type. ";
            

            WebClient client = new WebClient();
            string reply = client.DownloadString("Http://msdn.microsoft.com");
           

            Console.WriteLine(reply);
            File.WriteAllText(@"C:\Lesson17", reply);
            Console.ReadLine();
        }
    }
}
