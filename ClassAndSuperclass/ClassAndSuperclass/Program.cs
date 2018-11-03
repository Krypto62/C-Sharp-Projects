using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndSuperclass
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Inside of the Main method, instantiate and initialize an Employee
            // object with a first name of "Sample" and a last name of "Student".

            Employee Person = new Employee();
            Person.Firstname = "Sample";
            Person.Lastname = "Student";

            //5. Call the superclass method SayName() on the Employee object.
            Person.SayName();
        }
    }
}
