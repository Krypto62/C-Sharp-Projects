using System;

namespace ClassAndSuperclass
{
    //1. Create a class called Person and give it two properties,
    //each of data type string. One called FirstName, the other LastName.
    class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        //2. Give this class a void method called SayName() that takes no parameters and simply
        // writes the person's full name to the console in the format of: "Name: [full name]".

        public void SayName()
        {
            Console.WriteLine("Name: " + Firstname + " " + Lastname);
            Console.ReadLine();
        }
    }
}
