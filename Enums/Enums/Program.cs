using System;


namespace Enums
{
    class Program
    //www.dotnetperls.com/enum-parse
    {
        static void Main(string[] args)
        {
            //2. Prompt the user to enter the current day of the week.
            Console.WriteLine("Please enter the current day of the week");
            string value = Console.ReadLine();

            //3. Assign the value to a variable of that enum data type you just created.

            //4. Wrap the above statement in a try/catch block and have it print
            //"Please enter an actual day of the week." to the console if an error occurs.

            try
            {
                DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), value);

                if (day == DayOfWeek.Sunday)
                {
                    Console.WriteLine("Sunday has a value of 0.");
                }
                if (day == DayOfWeek.Monday)
                {
                    Console.WriteLine("Monday has a value of 1.");
                }
                if (day == DayOfWeek.Tuesday)
                {
                    Console.WriteLine("Tuesday has a value of 2.");
                }
                if (day == DayOfWeek.Wednesday)
                {
                    Console.WriteLine("Wednesday has a value of 3.");
                }
                if (day == DayOfWeek.Thursday)
                {
                    Console.WriteLine("Thursday has a value of 4.");
                }
                if (day == DayOfWeek.Friday)
                {
                    Console.WriteLine("Friday has a value of 5.");
                }
                if (day == DayOfWeek.Saturday)
                {
                    Console.WriteLine("Saurday has a value of 6.");
                }
            }
            catch (System.ArgumentException ex)
            {
                Console.WriteLine("Please enter an actual day of the week");
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
    class Week
    {
        //1. Create an enum for the days of the week.
        public DayOfWeek Day { get; set; }
    }
        public enum DayOfWeek
    {
        Sunday = 0,
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6
    }
}
