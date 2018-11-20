using System;

namespace ConstantVarChaining
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Create a const variable
            const string businessName = "Welcome to Dewey Cheatem and Howe";
            Console.WriteLine("\n" + businessName);

            Student student = new Student();
        }
    }
    public class Student
    {
        //3. Chain two constructors together.
        public Student() : this(25) //Execute the public Student (int age) method
        {  
        }
        public Student(int age)
        {
            //2. Create a variable using the keyword "var".
            var YearsOld = age;
            Console.WriteLine("Our business is " + YearsOld + " years old.");
            Console.ReadLine();
        }  
    }
}
