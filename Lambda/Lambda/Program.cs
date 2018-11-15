using System;
using System.Linq;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. In the Main() method, create a list of at least 10 employees.
            //Each employee should have a first and last name, as well as an Id.
            //At least two employees should have the first name "Joe".

            var list = new[]
                {
                    new { FirstName = "Joe", LastName = "Schmo", Age = 35 },
                    new { FirstName = "Sue", LastName = "Blue", Age = 20 },
                    new { FirstName = "Kim", LastName = "Blim", Age = 18 },
                    new { FirstName = "Bill", LastName = "Krill", Age = 19 },
                    new { FirstName = "Alice", LastName = "Malice", Age = 22 },
                    new { FirstName = "Joe", LastName = "Piscapo", Age = 32 },
                    new { FirstName = "Tom", LastName = "Thumb", Age = 35 },
                    new { FirstName = "Ana", LastName = "Banana", Age = 27 },
                    new { FirstName = "Joe", LastName = "Pogo", Age = 48 },
                    new { FirstName = "Tina", LastName = "Molina", Age = 43 }
                }.ToList();

            foreach (var item in list)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.Age);
            }
            Console.WriteLine();
            Console.WriteLine();

            //2. Using a foreach loop, create a new list of all employees with the first name "Joe".

            foreach (var item in list)
            {
                if (item.FirstName == "Joe")
                {
                    Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.Age);
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            //3. Do the same thing again, but this time with a lambda expression.
 
            var newList = list.Where(i => i.FirstName == "Joe").ToList();
            newList.ForEach(i => Console.WriteLine(i.FirstName + " " + i.LastName + " " + i.Age));

            Console.ReadLine();
        }
    }
}
