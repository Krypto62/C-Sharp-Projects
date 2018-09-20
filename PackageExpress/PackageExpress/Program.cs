using System;


namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            //The first line of the program must be: “Welcome to Package Express. Please follow the instructions below.”
            //The user must then be prompted for the package weight.
            int packWeight = 50;

                Console.WriteLine("Welcome to Package Express. Please follow the instructions below:");
                Console.WriteLine();
                Console.WriteLine("Please enter the package WEIGHT");
          
            int userPackWeight = Convert.ToByte(Console.ReadLine());

            //If the weight is greater than 50, display the error message, “Package too heavy to be shipped via Package Express.
            //Have a good day.” At this point the program would end.
            if (userPackWeight > packWeight)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);              
            }
            
            //The user must then be prompted for the package width.
                Console.WriteLine();
                Console.WriteLine("What is the package WIDTH");
            int userPackWidth = Convert.ToByte(Console.ReadLine());

            //The user must then be prompted for the package height.
                Console.WriteLine();
                Console.WriteLine("What is the package HEIGHT?");
            int userPackHeight = Convert.ToByte(Console.ReadLine());

            //The user must then be prompted for the package length.
            int dimSum = 50;
                Console.WriteLine();
                Console.WriteLine("What is the package LENGTH?");
            int userPackLength = Convert.ToByte(Console.ReadLine());
        
                Console.WriteLine();
            //If the sum of the dimensions is greater than 50, display the error message,
            //“Package too big to be shipped via Package Express.” At this point the program would end.

            int userDimSum = (userPackWidth + userPackHeight + userPackLength);
            int userTotalDim = ((userDimSum * userPackWeight) / 100);
            
            if (userDimSum > dimSum)
            {
                Console.WriteLine("Package TOO BIG to be shipped via Package Express.");
            }

            //The sum total of dimensions are then multiplied by the weight and divided by 100.
            //The result of that calculation is the quote.
            //Display the quote to the user as a dollar amount.

            else
            {
                Console.WriteLine("Your estimated total for shipping this package is: {0:C}", Convert.ToDecimal(userTotalDim));
            }
            Console.WriteLine();
            Console.WriteLine("Thank you for using Package Express!");
            Console.ReadLine();

        }
    }
}
