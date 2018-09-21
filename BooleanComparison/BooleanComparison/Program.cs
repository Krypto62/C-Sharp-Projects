using System;


namespace BooleanComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many times has Lebron James made it to the NBA finals?");
            int number = Convert.ToByte(Console.ReadLine());
            bool isGuessed = number == 8;

            while (!isGuessed)
            {

                switch (number)
                {
                    case 0:
                        Console.WriteLine("0 is too few.");
                        Console.WriteLine();
                        Console.WriteLine("Guess again");

                        number = Convert.ToByte(Console.ReadLine());
                        Console.WriteLine();
                        break;

                    case 1:
                        Console.WriteLine("1 is too few.");
                        Console.WriteLine();
                        Console.WriteLine("Guess again");
                        number = Convert.ToByte(Console.ReadLine());
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.WriteLine("2 is too few.");
                        Console.WriteLine();
                        Console.WriteLine("Guess again");
                        number = Convert.ToByte(Console.ReadLine());
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.WriteLine("3 is too few.");
                        Console.WriteLine();
                        Console.WriteLine("Guess again");
                        number = Convert.ToByte(Console.ReadLine());
                        Console.WriteLine();
                        break;

                    case 4:
                        Console.WriteLine("4 is too few.");
                        Console.WriteLine();
                        Console.WriteLine("Guess again");
                        number = Convert.ToByte(Console.ReadLine());
                        Console.WriteLine();
                        break;

                    case 5:
                        Console.WriteLine("5 is too few.");
                        Console.WriteLine();
                        Console.WriteLine("Guess again");
                        number = Convert.ToByte(Console.ReadLine());
                        Console.WriteLine();
                        break;

                    case 6:
                        Console.WriteLine("6 is too few.");
                        Console.WriteLine();
                        Console.WriteLine("Guess again");
                        number = Convert.ToByte(Console.ReadLine());
                        Console.WriteLine();
                        break;

                    case 7:
                        Console.WriteLine("7 is too few.");
                        Console.WriteLine();
                        Console.WriteLine("Guess again");
                        number = Convert.ToByte(Console.ReadLine());
                        Console.WriteLine();
                        break;

                    case 8:
                        Console.WriteLine("That's right! 8 times!! Great guess. Thanks for playing!");
                        isGuessed = true;
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("That is too high.");
                        Console.WriteLine();
                        Console.WriteLine("Guess again");
                        number = Convert.ToByte(Console.ReadLine());
                        Console.WriteLine();
                        break;
                        
                }
            }
            Console.Read();




        }
    }
}
