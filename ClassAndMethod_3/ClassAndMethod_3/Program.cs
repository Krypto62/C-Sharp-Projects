using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethod_3
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Math.FirstNum();
    //2.In the Main() method of the console app, instantiate the class and call the one method,
    //passing in an integer, such as 12. Then display the result to the screen.

    //2. In the Main() method of the console app, instantiate the class and call the one method,
    //passing in an integer, such as 12. Then display the result to the screen.
            Math Susan = new Math();
            Console.WriteLine();
            Console.WriteLine("Susan is " + Susan.age + " years old." );
            Console.WriteLine();
            Math.SecondNum(); //NEED TO CHANGE PER INSTRUCTIONS IN STEP 3
            Console.Read();

        }
    }

    //1. Create a class. In that class, create a method that will take in an integer,
    //do a math operation to it and then return the answer as an integer.

    public class Math
    {
        public static void FirstNum()
        {
            int num1 = 50;
            
            Console.WriteLine("Please enter a number and I will multiply it by 50");
            int input1 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine();
            int Answer1 = num1 * input1;
            Console.WriteLine("Your number multiplied by 50 is " + Answer1);
            Console.WriteLine();
        }
       
        public int age = 12;

        //3. Add a second method to the class, with the same name, that will take in a decimal,
        //do a different math operation to it and then return the answer as an integer.

        public static void SecondNum() //NEED TO CHANGE PER INSTRUCTIONS IN STEP 3
        {
            float num3 = 3.14159f;

            Console.WriteLine("Please enter a number with a decimal and I'll divide it by Pi");
            float input2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine();
            float Answer2 = num3 / input2;
            Console.WriteLine("Your number divided by Pi is " + Answer2);
            Console.WriteLine();

        }

    }
}
