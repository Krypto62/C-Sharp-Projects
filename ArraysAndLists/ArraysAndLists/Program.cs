using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {
            //1. Create a one-dimensional Array of strings. Ask the user to select an index of the Array and then display the string at that index on the screen.

            Console.WriteLine();
            string[] stringArray = new[] { "1 Dozen Eggs", "1 loaf of Bread", "1 8oz Yogurt", "1 Can of Soda", "1 8oz Chips", "1 Fresh Tomato" };
            
            Console.WriteLine("Please pick a number from 0 to 5 to see what grocery item you have won!");
            string userInput1 = Console.ReadLine();
            int userNum1 = Convert.ToByte(userInput1);

            Console.WriteLine("You have won: " + (stringArray[userNum1]));
            Console.WriteLine();

            //2.Create a one-dimensional Array of integers.Ask the user to select an index of the Array and then display the integer at that index on the screen.

            int[] numArray = { 5, 10, 20, 30, 40 };

            Console.WriteLine("About how much do you typically spend for snacks at the theater?");
            Console.WriteLine("     Please select a number from 0 to 4...  \n \t 0 = Nothing \n \t 1 = $10 \n \t 2 = $20 \n \t 3 = $30 \n \t 4 = At least $40");
            string userInput2 = Console.ReadLine();
            int userNum2 = Convert.ToByte(userInput2);
            Console.WriteLine("You selected #" + userNum2);
            Console.WriteLine("Good news! We have decided to add " + (numArray[userNum2]) + " dollars to your snack budget:");

            //3.Add in a message that displays when the user selects an index that doesn’t exist.

            //4.Create a List of strings. Ask the user to select an index of the List and then display the content at that index on the screen.
            Console.WriteLine();
            List<string> nameList = new List<string>();
            nameList.Add("Jim");
            nameList.Add("Susan");
            nameList.Add("Scott");
            nameList.Add("Jennifer");
            nameList.Add("George");
            nameList.Add("John");
            nameList.Add("Erica");
            Console.WriteLine("Our current team consists of the following persons: \n \t 0. Jim \n \t 1. Susan \n \t 2. Scott \n \t 3. Jennifer \n \t 4. George \n \t 5. John \n \t 6. Erica");
            Console.WriteLine();
            Console.WriteLine("     Who would you like to donate your snack to? Pick a number...");
            string userNameInput = Console.ReadLine();
            int NumInput = Convert.ToByte(userNameInput);
            Console.WriteLine(nameList[NumInput] + " will be very happy :)");
      

            Console.ReadLine();
        }
    }
}
