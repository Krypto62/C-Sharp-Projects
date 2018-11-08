using System;

namespace AbstractClass
{
    // 3. Create another class called Employee and have it inherit from the Person class.

    // Step 126 #2. Have your Employee class from the previous drill inherit that interface

    class Employee : Person, IQuittable
    {
        public void Quit()
        {
            string name = FirstName + " " + LastName;
            Console.WriteLine(name);
            Console.ReadLine();
        }
    }
}
