using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Instantiate an Employee object with type "string" as its generic
            //parameter. Assign a list of strings as the property value of Things.
            Employee<string> object1 = new Employee<string>();
            object1.Things.Add("Pen");
            object1.Things.Add("Pencil");
            object1.Things.Add("Stapler");
            //foreach (string in object1.Things)
            //{
            //    Console.WriteLine(object1.Things);
            //}   
            Console.ReadLine();

            //4. Instantiate an Employee object with type "int" as its generic parameter.
            //Assign a list of integers as the property value of Things.
            Employee<int> object2 = new Employee<int>();
            object2.Things.Add(7);
            object2.Things.Add(9);
            object2.Things.Add(11);

            //5. Create a loop that prints all of the Things to the Console.


            //for (int i = 0; i < object1.Things.Count; i++)
            //{
            //    //print another list items.
            //    for (int j = 0; j < object2.Things.Count; j++)
            //    {
            //        Console.WriteLine("/" + object1.Things[i] + "/" + object2.Things[j]);
            //    }

            //    Console.WriteLine("{0}\t", object2.Things);

            //}
            //foreach (string thing in object1.Things)
            //{
            //    Console.WriteLine(T thing);
            //}
            //Console.ReadLine();
        }
    }
}
