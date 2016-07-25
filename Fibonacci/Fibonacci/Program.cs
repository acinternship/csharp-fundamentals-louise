using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

               int a, b, i, aux, position_1, position_2, position_3;

                ;

                a = 0;
                b = 1;
                position_1 = 6;
                position_2 = 13;
                position_3 = 16;

                Console.WriteLine("The fibonacci number's position and its value: ");
                Console.WriteLine("");
                Console.WriteLine("Position | Fibonacci Number");

                for (i = 2; i <= position_3; i++)
                {
                    aux = a;
                    a = b;
                    b = aux + b;



                    if (position_1 == i)
                    {
                        Console.Write(position_1);
                        Console.Write("        |    ");
                        Console.WriteLine(b);
                    }

                    else if (position_2 == i)
                    {
                        Console.Write(position_2);
                        Console.Write("       |    ");
                        Console.WriteLine(b);
                    }


                    else if (position_3 == i)
                    {
                        Console.Write(position_3);
                        Console.Write("       |    ");
                        Console.WriteLine(b);
                    }


                }
                Console.ReadLine();
            }

        }
    }
