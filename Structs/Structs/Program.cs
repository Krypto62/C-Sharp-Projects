using System;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. In the Main() method, create an object of data type Number
            //and assign an amount to it.

            Number num1 = new Number();
            num1.Amount = 89;

            //3. Print this amount to the console.
            Console.WriteLine(num1.Amount);
            Console.ReadLine();
        }
    }
}
