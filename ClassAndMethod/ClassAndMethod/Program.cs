using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Create a class. In that class, create three methods, each of which will take one integer parameter in and return an integer.
//The methods should do some math operation on the received parameter.Put this class in a separate.cs file in the application.

//2. In the Main() program, ask the user what number they want to do the math operations on.

//3. Call each method in turn, passing the user input to the method. Display the returned integer to the screen.

namespace ClassAndMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("I will be using the numbers 25, 35 and 17 in calculations with your input..");
            Console.WriteLine();

            Math.firstNum();
            Math.secondNum();
            Math.thirdNum();

            Console.ReadLine();
        }
    
    }
}
