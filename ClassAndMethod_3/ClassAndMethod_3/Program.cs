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
            Car myCar = new Car();

            //2. In the Main() method of the console app, instantiate the class and call the one method,
            //passing in an integer, such as 12. Then display the result to the screen.

            Console.WriteLine();
            int num4 = 12;
            Console.WriteLine("In " + myCar.Ford(num4) + " a car bought today will be 12 years old");
            Console.WriteLine();

            //4. In the Main() method of the console app, instantiate
            //the class and call the second method, passing in a decimal.
            //Display the result to the screen.

            float num5 = 10.5f;
            Console.WriteLine("10 pounds torque will yield " + myCar.Ford(num5) + " pounds of pressure");
            Console.ReadLine();

            //6. In the Main() method of the console app, instantiate the class and
            //call the third method, passing in a string that equates to an integer.
            //Display the result to the screen.

            string color = "1";
            Console.WriteLine();
            Console.WriteLine("based on your input of " + myCar.Ford(color));
            Console.ReadLine();
        }
    }

}