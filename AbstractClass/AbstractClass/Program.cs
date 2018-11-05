using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Inside the Main() method, instantiate an Employee object with firstName "Sample"
            //and lastName "Student". Call the SayName() method on the object.
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };

            // 4. Implement the SayName() method inside of the Employee class.
            Console.WriteLine(employee.SayName());
            Console.ReadLine();
        }
    }
}
