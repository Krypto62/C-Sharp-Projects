using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethod
{
    public class Math
    {
        //public int num1 { get; set; }
        public static void firstNum()
        {
            int num1 = 25;
            Console.WriteLine("Please enter a number");
            int input1 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Your number " + input1 + ", when multiplied by " + num1 + " = " + (input1 * num1));
            Console.WriteLine();
        }

        public static void secondNum()
        {
            int num2 = 35;
            Console.WriteLine("Please enter a second number");
            double input2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Your number " + input2 + ", when it's divided by " + num2 + " = " + (input2 / num2));
            Console.WriteLine();
        }

        public static void thirdNum()
        {
            int num3 = 17;
            Console.WriteLine("Please enter a third number");
            double input3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Your number " + input3 + ", when it's subtracted from " + num3 + " = " + (num3 - input3));
            Console.WriteLine();
        }
        
    }


    
}
