using System;
using System.IO;

namespace File_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Ask a user for a number.
            Console.WriteLine("Please enter a number");
            string input = (Console.ReadLine());

            //2. Log that number to a text file.
            File.WriteAllText(@"C:\Users\scfow\logs\File_IO.txt", input);

            //3. Print the text file back to the user.
            Console.WriteLine("\nYou entered " + File.ReadAllText(@"C:\Users\scfow\logs\File_IO.txt"));
            Console.ReadLine();
            

        }
    }
}
