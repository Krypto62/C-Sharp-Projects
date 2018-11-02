using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethod_4
{
    class Program
    {
        public static void Main(string[] args)
        {

            //2.In the Main() method of the console app, instantiate the class.
            Stats myStats = new Stats();

            //3.Ask the user to input two numbers, one at a time.
            //Let them know they need not enter anything for the second number.
            Console.WriteLine("Please enter either one or two numbers and press \"Enter\"");
            
            string[] input = Console.ReadLine().Split();
            
            //Parse element 0
            int num1 = int.Parse(input[0]);

            //I'm trying to allow for a missing second number and then tell the code
            //to use a number 1 instead of nothing.
            if (int.Parse(input[1]) == IsNullOrEmpty())
            {
                int num2 = int.Parse(1);
            }

            //Parse element 1
            int num2 = int.Parse(input[1]);
            Console.WriteLine();
            Console.WriteLine("When we multiply your first number by 20 and then add \nyour second number (if you entered one) to it, we get " + myStats.ERA(num1, num2));
            Console.ReadLine();
            
            

        }
    }
}
