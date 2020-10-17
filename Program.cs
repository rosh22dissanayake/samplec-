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
            Console.WriteLine("please enter your rent bill...");

             
         string number1 = Console.ReadLine();

            
            double num1 = Convert.ToDouble(number1);


            Console.WriteLine("please enter your average electricity...");
            
           string number2 = Console.ReadLine();

            
            double num2 = Convert.ToDouble(number2);

            Console.WriteLine("please enter your telephone bill...");

            
           string number3 = Console.ReadLine();

            
            double num3 = Convert.ToDouble(number1);

            Console.WriteLine("please enter your water bill...");

            
           string number4 = Console.ReadLine();

         
            double num4 = Convert.ToDouble(number1);

            

          double  total = num1 + num2+ num3 + num4;
            
             String num = Console.ReadLine();
            int number = Convert.ToInt32(num);
            
             total = total + number;


       double overall = total - total * 0.2 ;


            Console.WriteLine("Total value is "  + overall);
            Console.ReadLine();
        }
    }
}
