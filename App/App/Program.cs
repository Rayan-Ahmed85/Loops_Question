using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("I am Learning C#");
            Console.WriteLine("It is awesome!");
            Console.WriteLine(3 + 3);
            string name = "Rayan";
            int myNum = 15;
            double myDoubleNum = 54.99f;  
            char myLetter = 'D';
            bool myBool = true;
            Console.WriteLine($"Double : {myDoubleNum} Char : {myLetter} Boolean : {myBool} Integer : {myNum} String : {name}");

            Console.WriteLine("Enter Your First_Name");
           String First_Name = Console.ReadLine();
            Console.WriteLine("Enter Your Last_Name");
            String Last_Name = Console.ReadLine();
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine($"HEllo!{First_Name.ToUpper() +  Last_Name.ToUpper()}");
            Console.WriteLine("Your age is: " + age);
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
        }
    }
}
