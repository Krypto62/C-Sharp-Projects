using System;

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
            Console.WriteLine("What do we call a student who quits? Press \"Enter\" to see...");
            Console.ReadLine();

            // and implement the Quit() method in any way you choose.
            Employee formerEmployee = new Employee() { FirstName = "Lame", LastName = "Student" };
            formerEmployee.Quit();

            //3. Use polymorphism to create an object of type IQuittable and call the Quit() method on it.
            IQuittable formerEmployee2 = new Employee() { FirstName = "Another Lame", LastName = "Student" };
            formerEmployee2.Quit();
        }
    }
}
