using System;

namespace OverloadedOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            employee1.Id = 7;
            employee2.Id = 23;

            bool isTrue = true;
            bool isFalse = false;

            //Overload the "==" operator so it checks if two Employee objects are equal
            //by comparing their Id property.
            isTrue = employee1 == employee2;
            isFalse = employee1 != employee2;

            Console.WriteLine(isTrue);
            Console.WriteLine(isFalse);
            Console.ReadLine();

        }
    }

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }

        static public bool operator == ( Employee x, Employee y)
        { 
        bool result = x.Id == y.Id;
            return result;
        }

        static public bool operator != (Employee x, Employee y)
        {
        bool result = x.Id != y.Id;
            return result;
        }
    }
}
