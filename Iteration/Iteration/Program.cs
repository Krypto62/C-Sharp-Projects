using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        //1.Create a one-dimensional Array of strings. Ask the user to input some text.
        //Create a loop that goes through each string in the Array, adding the user’s text to the string.
        //Then create a loop that prints off each string in the Array on a separate line.

        //string[] fruits = { "kiwi", "banana", "kumquat", "papaya" };
        //Console.WriteLine("What kind of tropical pet do you own?");
        //string userAnimal = Console.ReadLine();

        //for (int f = 0; f < fruits.Length; f++)

        //{
        //    Console.WriteLine("Would your " + userAnimal + " like a " + fruits[f] + "?");
        //}


        //Console.ReadLine();

        //2. Create an infinite loop. -- To accomplish this I simply removed f++ from the For statement above
        //3.Fix the infinite loop so it will execute. --I put f++ back where it belongs

        //4.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.

        //for (int i = 0; i < 4; i++)
        //{
        //    Console.WriteLine("You have iterated through this loop 4 times");
        //}
        //Console.ReadLine();


        //5.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.
        //Step 101

        //for (int i = 0; i <= 7; i++)
        //{
        //    Console.WriteLine("You have iterated through this loop 8 times");
        //}
        //Console.ReadLine();



        //6.Create a List of strings where each item in the list is unique. Ask the user to select text to search for in the List.
        //Create a loop that iterates through the loop and then displays the index of the array that contains matching text on the screen.
        Console.WriteLine("A few famous dogs are: Lassie, Toto, Pluto, and Snoopy");
        Console.WriteLine("Please enter the name of one of them to search for");
        string input = Console.ReadLine();

        string[] dogs = { "Lassie", "Toto", "Pluto", "Snoopy" };
        for (int i = 0; i < dogs.Length; i++)
        {
            if (dogs[i] == input)
            {
                Console.WriteLine(dogs[i] + " is a great dog and is at index " + i);
                break;

            }

            //7.Add code to that above loop that tells a user if they put in text that isn’t in the List.

            else if (dogs[i] != input)
            {
                Console.WriteLine(dogs[i] + " is at index " + i );
                //goto done;
            }
           
        }
    //done:
        //Console.WriteLine("End");
        Console.ReadLine();

        //8.Add code to that above loop that stops it from executing once a match has been found.
        //Satisfied this by adding  ***break;*** to the if statement above

        //9.Create a List of strings that has at least two identical strings in the List. Ask the user to select text to search for in the List.Create a loop that iterates through the loop and then displays the indices of the array that contain matching text on the screen.


        //10.Add code to that above loop that tells a user if they put in text that isn’t in the List.

        //11.Create a List of strings that has at least two identical strings in the List. Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.



    }
}
