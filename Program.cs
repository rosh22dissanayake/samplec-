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
            Console.WriteLine("Power of ball");

             
         string p1 = Console.ReadLine();

            
            double p = Convert.ToDouble(p1);


            Console.WriteLine("overall time of ball between two places");
            
           string t1 = Console.ReadLine();

            
            double t = Convert.ToDouble(t1);

            
          double  energy = p*t;
            
             String num1 = Console.ReadLine();
            int number = Convert.ToInt32(num1);
            
             energy = energy + number;


       double result = energy - energy * 0.5 ;


            Console.WriteLine("Total value is "  + result);
            Console.ReadLine();
        }
    }
}
