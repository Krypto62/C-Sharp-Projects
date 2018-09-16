using System;

namespace MathCalculations
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a number");
            Console.WriteLine();
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            Console.WriteLine("When we add 25 to it we get " + (number + 25));
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();

            Console.WriteLine("Please enter another number");
            Console.WriteLine();
            string input2 = Console.ReadLine();
            float num1 = Convert.ToSingle(input2);
            Console.WriteLine();
            Console.WriteLine("If we divide this by 12.5 we get " + (num1 / 12.5));
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();

            int var1 = 50;
            Console.WriteLine("Another number please...");
            Console.WriteLine();
            string input3 = Console.ReadLine();
            int num2 = Convert.ToInt32(input3);
            bool num3 = num2 > var1;
            Console.WriteLine("Let's see if it is greater than 50");
            Console.WriteLine(num3);
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();

            Console.WriteLine("One last number please...");
            Console.WriteLine();
            string input4 = Console.ReadLine();
            int num4 = Convert.ToInt32(input4);
            int remainder = num4 % 7;
            Console.WriteLine("Looks like you have " + remainder + " left over");
            Console.WriteLine("Press ENTER to finish");
            Console.ReadLine();


        }
    }
}
