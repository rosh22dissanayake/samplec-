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
            Console.WriteLine("Speed of car...");

             
         string v1 = Console.ReadLine();

            
            double u1 = Convert.ToDouble(v1);


            Console.WriteLine("Time between two places...");
            
           string v2 = Console.ReadLine();

            
            double u2 = Convert.ToDouble(v2);

            Console.WriteLine("distance between two places...");

            
           string v3 = Console.ReadLine();

            
            double u3 = Convert.ToDouble(v3);


            

          double  average = u1 + u2*u3;
            
             String num = Console.ReadLine();
            int number = Convert.ToInt32(num);
            
             average = average + number;


       double total = average - average * 0.2 ;


            Console.WriteLine("Total value is "  + total);
            Console.ReadLine();
        }
    }
}
