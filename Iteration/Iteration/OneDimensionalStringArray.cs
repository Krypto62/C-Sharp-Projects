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
            
        

    }
}
