using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethod__2
{
    class Program
    {
        public static int num3 { get; private set; }

        static void Main(string[] args)
        //1. Create a class. In that class, create a void method that takes two integers as parameters(arguments).
        //Have the method do a math operation on the first integer and display the second integer to the screen.
        {
            Console.WriteLine("Please enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Thank you. Now please enter another number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

        //3. Call the method in the class, passing in two numbers.
            DoStuff.Add (500, num1, num2);
            Console.WriteLine();
            Console.WriteLine("---Press ENTER to learn how old my dog is---");
            Console.ReadKey();

        //2. In the Main() method of the console app, instantiate the class.
        //4. Call the method in the class, specifying the parameters by name.
            DoStuff dog = new DoStuff();
            Console.WriteLine();
            Console.WriteLine(dog.name + " is " + dog.age + " years old");
            Console.ReadKey();
        }

    }

    public class DoStuff
    {
       
        public static void Add(int num0, int num1, int num2)
        {
            Console.WriteLine("Your first number + 500 = " + (num0 + num1));
            Console.WriteLine();
            Console.WriteLine("The second number you added is " + num2);
        }

        public string name = "Oliver";
        public int age = 2;

    }
}
