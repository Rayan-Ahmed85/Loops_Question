using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.Write(i + " - ");
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            //1111
            for (int i = 1; i <= 20; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            //222

            for (int i = 1; i <= 10; i++)
            {
                for (int j = i; j <= 10; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine();
            }

                        //Star Pattern of Loop
            int n = 9; 

           
            for (int i = 1; i <= n; i++)
            {
                for (int space = 1; space <= n - i; space++)
                    Console.Write(" ");

                for (int star = 1; star <= (2 * i - 1); star++)
                    Console.Write("*");

                Console.WriteLine();
            }

           
            for (int i = n - 1; i >= 1; i--)
            {
                for (int space = 1; space <= n - i; space++)
                    Console.Write(" ");

                for (int star = 1; star <= (2 * i - 1); star++)
                    Console.Write("*");

                Console.WriteLine();
            }
                  //reverse
            for (int i = 9; i >= 1; i--)

            {

                for (int j = i; j >= 1; j--)

                {

                    Console.Write(j);

                }

                Console.WriteLine();

            }

                 // Half Star
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //ABC
            for (int i = 1; i <= 26; i++)
            {
                char Char = (char)('A' + i - 1);
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(Char);
                    if (j < i)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }


        }
    }
}
