using System;

namespace ApprovalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Car Insurance Questionaire ---");
            Console.WriteLine();

            // Determine car insurance elegibility

            // What is your age?
            Console.WriteLine("What is your age?");
            string ageInput = Console.ReadLine();
            int userAge = Convert.ToUInt16(ageInput);
            Console.WriteLine();

            // Have you ever had a DUI?
            Console.WriteLine("Have you ever had a DUI? Please answer \"true\" or \"false\".");
            string duiInput = Console.ReadLine();
            bool userDUI = Convert.ToBoolean(duiInput);
            Console.WriteLine();

            // More than 3 speeding tickets?
            Console.WriteLine("How many speeding tickets do you have?");
            string ticketInput = Console.ReadLine();
            int userTicket = Convert.ToUInt16(ticketInput);

            //Approved for insurance?
            Console.WriteLine();
            Console.WriteLine("Check below to see if you have been approved for insurance.");
            Console.WriteLine();
            Console.WriteLine(userAge > 15 && userDUI == false && userTicket < 4);
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
