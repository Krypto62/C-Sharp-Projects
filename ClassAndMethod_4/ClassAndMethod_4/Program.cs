using System;

namespace ClassAndMethod_4
{
    class Program
    {
        public static void Main(string[] args)
        {

            //2. In the Main() method of the console app, instantiate the class.
            Stats myStats = new Stats();

            //3. Ask the user to input two numbers, one at a time.
            //Let them know they need not enter anything for the second number.
            Console.WriteLine("Please enter a number and press \"Enter\"");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You may enter another number or just press \"Enter\" for none.");
            string num2 = Console.ReadLine();

            if (num2 == "")
            {
                Console.WriteLine("The result of the equation is " + myStats.ERA(num1));
            }
            else
            {
                Console.WriteLine("The result of the equation is " + myStats.ERA(num1, Convert.ToInt32(num2)));
            }

            Console.ReadLine();
        }
    }
}
