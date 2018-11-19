using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAndTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Prints the current date and time to the console.
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine();

            //2. Asks the user for a number.
            Console.WriteLine("Please enter an integer\n");
            //DateTime input = Convert.ToDateTime(Console.ReadLine());
            int input = Convert.ToInt32(Console.ReadLine());

            //3. Prints to te console the exact time it will be in X hours,
            //X being the number the user entered in step 2.

            DateTime futureTime = DateTime.Now.AddHours(input);
            Console.WriteLine("\nIn " + input + " hours, it will be " + futureTime);
            Console.ReadLine();
        }
    }
}
