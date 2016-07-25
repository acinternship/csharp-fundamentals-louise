using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a sentence:\t ");
            string text = Console.ReadLine();

            int wordCount = text.Split(' ').Length;
            int charCount = text.Length;

            Console.WriteLine("\n");

            Console.WriteLine("The Number of Words are:\t" + wordCount);
            Console.WriteLine("The Number of Characters are:\t" + charCount);
            Console.ReadLine();
        }
    }
}
