using System;

namespace ClassAndMethod_5
{
    //1. Create a class. In that class, create a void method that outputs
    //an integer. Have the method divide the data passed to it by 2.

    public class Car
    {
        public void Model(int num1)
        {
            int num2 = num1 / 2;
            Console.WriteLine("Your number divided by 2 is " + num2);
            Console.WriteLine("Press \"Enter\" to continue...");
            Console.ReadLine();
        }
        //4. Create a method with output parameters.
        //5. Overload a method.
        public double Model(double num3)
        {
            double num4 = num3 / 2;
            return num4;
        }

    }

    //6. Declare a class to be static.
    static class Trucks
    {
        static void Foreign()
        {

        }

    }
}
