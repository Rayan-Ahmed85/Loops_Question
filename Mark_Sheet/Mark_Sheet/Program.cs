using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mark_Sheet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name");
            string Std_name = Console.ReadLine();
            Console.WriteLine("Enter Your Age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Math-Number");
            int math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your English-Number");
            int eng = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Urdu-Number");
            int urdu = Convert.ToInt32(Console.ReadLine());
            int total = math + eng + urdu;
            float percent = total / 300F * 100;
            string grade ;
            Console.WriteLine("MarkSheet");
            Console.WriteLine($"Student_Name : {Std_name}");
            Console.WriteLine($"Student_Age : {age}");
            Console.WriteLine($"Math_Marks : {math}");
            Console.WriteLine($"English_Marks : {eng}");
            Console.WriteLine($"Urdu_Marks : {urdu}");
            Console.WriteLine($"Total_Marks : {total}");
            Console.WriteLine($"Percentage : {percent}");
            if (percent >= 80 && math >=33 && urdu>=33 && eng>=33)
            {
                grade = "A1";
            }
          /*  Console.WriteLine($"Grade :{grade}")*/;
        }
    }
}
