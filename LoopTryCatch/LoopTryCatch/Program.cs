using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a list of integers. Ask the user for a number to divide each number in the list by.
            //Write a loop that takes each integer in the list, divides it by the number the user entered,
            //and displays the result to the screen.
            //Run that code, entering in non-zero numbers as the user. Look at the displayed results.
            //Run that code, entering in zero as the number to divide by. Note any error messages you get. Output is the infinity symbol.
            //Run that code, entering in a string as the number to divide by. Note any error messages you get.
            try
            {
                Console.WriteLine();

                int[] intList = { 5, 10, 15, 20, 25, 30, 35, 40 };
                Console.WriteLine("Please enter a number");
                double input = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                for (int i = 0; i < intList.Length; i++)
                {
                    double x = (intList[i] / input);
                    Console.WriteLine(intList[i] + " divided by " + input + " = " + x);
                    Console.WriteLine();
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message + " Please be sure to enter only a number");
            }

            Console.Read();


            }
    }
}
