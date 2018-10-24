using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethod_3
{

    public class Program
    {
        //QUESTION: WHICH IS CONSIDERED INSTANTIATING THE CLASS? LINE 23 OR LINE 30?
        public static void Main(string[] args)
        {
            int Susan = Math.TestNum();
            Console.WriteLine();
            Console.WriteLine("Your number multiplied by 50 is " + Susan);
            Console.ReadKey();

            //2. In the Main() method of the console app, instantiate the class and call the one method,
            //passing in an integer, such as 12. Then display the result to the screen.

            Car myCar = new Car();
            Console.WriteLine();
            myCar.Year = 2015;
            Console.WriteLine("After instantiating the Program class, I am passing in an integer, which is the year of my car - " + myCar.Year);
            Console.ReadLine();

/*
            int myCar = Car.TestNum2(12);
            Console.WriteLine();
            Console.WriteLine("In " + myCar + " a car bought today will be 12 years old");
            Console.ReadLine();
**/
        }

    }
    //1. Create a class. In that class, create a method that will take in an integer,
    //do a math operation to it and then return the answer as an integer.


    public class Math
    {
        public static int TestNum()
        {
            int num1 = 50;
            Console.WriteLine("Please enter a number and I will multiply it by 50");
            int input1 = Convert.ToByte(Console.ReadLine());
            int result = input1 * num1;
            return result;
        }

        //3. Add a second method to the class, with the same name, that will take in a decimal,
    }

    class Car
    {
         public int Year { get; set; }

    }

/*
    public class Car
    {
        public static int TestNum2(int num4)
        {
        return (2018 + num4);
        }
    }
**/
}