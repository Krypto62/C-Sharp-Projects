using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        //1.Create a one-dimensional Array of strings. Ask the user to input some text.
        //Create a loop that goes through each string in the Array, adding the user’s text to the string.
        //Then create a loop that prints off each string in the Array on a separate line.

        string[] fruits = { "kiwi", "banana", "kumquat", "papaya" };
        Console.WriteLine("What kind of tropical pet do you own?");
        string userAnimal = Console.ReadLine();

        for (int f = 0; f < fruits.Length; f++)

        {
            Console.WriteLine("Would your " + userAnimal + " like a " + fruits[f] + "?");
        }

        Console.ReadLine();

        //2. Create an infinite loop. -- To accomplish this I simply removed f++ from the For statement above
        //3.Fix the infinite loop so it will execute. --I put f++ back where it belongs

        //4.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.
        //Step 93 keep working on this. ---How do I 

        int[] integerarray = { 1, 2, 3, 4, 5, 6 };
        for (int i = 0; i < integerarray.Length; i++)

        {
            if (integerarray[i] > 3)
            {
                Console.WriteLine("You selected a number higher than" + i);
                //break;
            }
            else if (integerarray[i] < 3)
            {
                Console.WriteLine("You did not select 3");
                //break;
            }
            else
            {
                Console.WriteLine("You selected" + integerarray[i]);
                break;
            }

            Console.ReadLine();


            Console.WriteLine("What was your test score?");
            string input = Console.ReadLine();
            Console.WriteLine("You scored " + input + " out of a possible 85");
            Console.WriteLine();
            Console.WriteLine("Here are the other low scores ");

            List<int> testScores = new List<int>();

            testScores.Add(70);
            testScores.Add(99);
            testScores.Add(64);
            testScores.Add(47);
            testScores.Add(46);
            testScores.Add(81);
            testScores.Add(42);

            foreach (int score in testScores)

            {
                if (score < 70)
                {
                    Console.WriteLine(score);
                }
            }

            //5.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.
            //Step 101
            Console.WriteLine();
            Console.WriteLine("What year is your car?");
            string input2 = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Your car was built in " + input2);
            Console.WriteLine();
            Console.WriteLine("Below are car years considered \"modern\" today");

            List<int> carYears = new List<int>();

            carYears.Add(2018);
            carYears.Add(2017);
            carYears.Add(2016);
            carYears.Add(2015);
            carYears.Add(2014);
            carYears.Add(2013);
            carYears.Add(2012);

            foreach (int car in carYears)

            {
                if (car <= 1968)
                {
                    Console.WriteLine("Your car is considered a 'Classic'!");
                    break;
                }
                else if (car > 1968)
                {
                    Console.WriteLine(car);

                }

            }

            Console.ReadLine();



            //6.Create a List of strings where each item in the list is unique.Ask the user to select text to search for in the List.Create a loop that iterates through the loop and then displays the index of the array that contains matching text on the screen.


            //7.Add code to that above loop that tells a user if they put in text that isn’t in the List.

            //8.Add code to that above loop that stops it from executing once a match has been found.

            //9.Create a List of strings that has at least two identical strings in the List. Ask the user to select text to search for in the List.Create a loop that iterates through the loop and then displays the indices of the array that contain matching text on the screen.


            //10.Add code to that above loop that tells a user if they put in text that isn’t in the List.

            //11.Create a List of strings that has at least two identical strings in the List. Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.


        }
    }
}
