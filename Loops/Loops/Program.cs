using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            string input;

            Console.WriteLine("Enter numbers continuously. Type 'exit' to finish.");
            Console.WriteLine("Rules: Skip negatives, stop if > 100, show even/odd info.");

            while (true)
            {
                Console.Write("Enter a number: ");
                input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    break;
                }

                if (int.TryParse(input, out int number))
                {
                    if (number < 0)
                    {
                        Console.WriteLine("Negative number skipped.");
                        continue;
                    }

                    if (number > 100)
                    {
                        Console.WriteLine("Number greater than 100. Stopping the loop.");
                        break;
                    }

                    if (number % 2 == 0)
                    {
                        Console.WriteLine("Even Number");
                    }
                    else
                    {
                        Console.WriteLine("Odd Number");
                    }

                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }

            Console.WriteLine("\nNumbers entered:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }

            Console.WriteLine($"\nSum of numbers: {sum}");
        }
        }
    }

