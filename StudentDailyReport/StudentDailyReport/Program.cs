using System;

namespace TheTechAcademy
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("");
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Thank you. What page number?");
            string page = Console.ReadLine();
            byte BytePage = Convert.ToByte(page);
            Console.WriteLine("");
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string help = Console.ReadLine();
            bool boolhelp = Convert.ToBoolean(help);
            Console.WriteLine("");
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string experience = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            byte ByteHours = Convert.ToByte(hours);
            Console.WriteLine("");
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}

