using System;

namespace ClassAndMethod_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. In the Main() method, instantiate that class.
            Car myCar = new Car();

            //3.Have the user enter a number. Call the method on that number.
            //Display the output to the screen. It should be the entered number, divided by two.
            Console.WriteLine("Please enter an integer and I will divide it by two");
            int num1 = Convert.ToInt32(Console.ReadLine());
            myCar.Model(num1);

            Console.WriteLine();
            double num3 = 3.14; 
            Console.WriteLine("3.14 divided by two is " + myCar.Model(num3));
            Console.ReadLine();
        }
    }   
}
