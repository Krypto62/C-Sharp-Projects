using System;

namespace ApprovalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Car Insurance Questionaire ---");
            Console.WriteLine();
            Console.WriteLine("What is your age?");
            string input1 = Console.ReadLine();
            int num1 = Convert.ToByte(input1);
            Console.WriteLine();

            string duiTrue = "yes";
            string duiFalse = "no";
            Console.WriteLine("Have you ever had a DUI?");
            string input2 = Console.ReadLine();
            //bool val1 = Convert.ToBoolean(input2);
            Console.WriteLine();

            string speedTrue = "yes";
            string speedFalse = "no";
            Console.WriteLine("Do you have more than 3 speeding tickets?");
            string input3 = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Qualified?");
            bool isQualified = (num1 > 15 && duiFalse == input2 && speedFalse == input3);
            Console.WriteLine(isQualified);
            //bool isNotQualified = (num1 <= 15 && duiTrue == "yes" && speedFalse == "no");

            
            Console.WriteLine();

        }
    }
}
