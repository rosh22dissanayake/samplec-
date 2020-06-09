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

            string number1;
            number1 = Console.ReadLine();

            double num1;
            num1 = Convert.ToDouble(number1);


            Console.WriteLine("please enter your average electricity...");
            string number2;
            number2 = Console.ReadLine();

            double num2;
            num2 = Convert.ToDouble(number2);

            Console.WriteLine("please enter your telephone bill...");

            string number3;
            number3 = Console.ReadLine();

            double num3;
            num3 = Convert.ToDouble(number1);

            Console.WriteLine("please enter your water bill...");

            string number4;
            number4 = Console.ReadLine();

            double num4;
            num4 = Convert.ToDouble(number1);

            double add;

            add = num1 + num2+ num3 + num4;


            Console.WriteLine("Addition is "  + add);
            Console.ReadLine();
        }
    }
}
