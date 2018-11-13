using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Instantiate an Employee object with type "string" as its generic
            //parameter. Assign a list of strings as the property value of Things.
            Employee<string> object1 = new Employee<string>();
            object1.Things = new List<string>() { "Pen", "Pencil", "Stapler"};

            foreach (string word in object1.Things)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine();

            //4. Instantiate an Employee object with type "int" as its generic parameter.
            //Assign a list of integers as the property value of Things.
            Employee<int> object2 = new Employee<int>();
            object2.Things = new List<int>() { 7, 9, 11};

            //5. Create a loop that prints all of the Things to the Console.
            foreach (int num in object2.Things)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();

        }
    }
}
