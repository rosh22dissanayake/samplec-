using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start speed of stone...");

             
         string number1 = Console.ReadLine();

            
            double num1 = Convert.ToDouble(number1);


            Console.WriteLine("Accelaration of stone...");
            
           string number2 = Console.ReadLine();

            
            double num2 = Convert.ToDouble(number2);

            Console.WriteLine("Time of stone between two places...");

            
           string number3 = Console.ReadLine();

            
            double num3 = Convert.ToDouble(number1);


            

          double  speed = num1 + num2*num3;
            
             String num = Console.ReadLine();
            int number = Convert.ToInt32(num);
            
             speed = speed + number;


       double overall = speed - speed * 0.2 ;


            Console.WriteLine("Total value is "  + overall);
            Console.ReadLine();
        }
    }
}
