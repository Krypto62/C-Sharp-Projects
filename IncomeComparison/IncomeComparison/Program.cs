using System;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine();
            Console.WriteLine("-- Person 1 --");
            Console.WriteLine("Hourly Rate?");
            string input1 = Console.ReadLine();
            int num1 = Convert.ToByte(input1);
            Console.WriteLine();

            Console.WriteLine("Hours worked per week?");
            string input2 = Console.ReadLine();
            int num2 = Convert.ToByte(input2);

            Console.WriteLine();
            Console.WriteLine("-- Person 2 --");
            Console.WriteLine("Hourly Rate?");
            string input3 = Console.ReadLine();
            int num3 = Convert.ToByte(input3);
            Console.WriteLine();

            Console.WriteLine("Hours worked per week?");
            string input4 = Console.ReadLine();
            int num4 = Convert.ToByte(input4);
            Console.WriteLine();

            Console.WriteLine("Weekly salary of Person 1:");
            int salary1 = num1 * num2;
            Console.WriteLine(salary1);
            Console.WriteLine();

            Console.WriteLine("Weekly salary of Person 2:");
            int salary2 = num3 * num4;
            Console.WriteLine(salary2);

            Console.WriteLine();
            Console.WriteLine("Does Person 1 earn more money than Person 2?");
            bool earn = salary1 > salary2;
            Console.WriteLine(earn);
            Console.ReadLine();
            

        }
    }
}
