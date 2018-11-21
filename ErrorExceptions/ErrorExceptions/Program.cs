using System;

namespace ErrorExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Exceptions must be handled using "try .. catch".
            try
            {
                // 1. Ask the user for his age.
                Console.WriteLine("How old are you now, or will you be this year?");

                // 2. Display the year the user was born.
                int userAge = Convert.ToInt32(Console.ReadLine());

                // 4. Display appropriate error messages if user enters zero or negative numbers.
                if (userAge == 0 || userAge < 0)
                {
                    Console.WriteLine("Number cannot be null or negative");
                    Console.ReadLine();
                    throw new ArgumentException("Number cannot be null or negative");
                }
                //if (user)
                Console.WriteLine();

                DateTime dNow = DateTime.Now;
                int yearNow = dNow.Year;
                string yearBorn = Convert.ToString(yearNow - userAge);

                Console.WriteLine("\nYou were born in " + yearBorn);
            }
            // 5. Display a general message if exception caused by anything else.
            catch (Exception)
            {
                Console.WriteLine("Please be sure to enter your age in digits only");
            }

            Console.ReadLine();
        }
    }
}
