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
        //Console.WriteLine("A few famous dogs are: Lassie, Toto, Pluto, and Snoopy");
        //Console.WriteLine("Please enter the name of one of them to search for");
        //string input = Console.ReadLine();

        //string[] dogs = { "Lassie", "Toto", "Pluto", "Snoopy" };
        //for (int i = 0; i < dogs.Length; i++)
        //{
        //    if (dogs[i] == input)
        //    {
        //        Console.WriteLine(dogs[i] + " is a great dog and is at index " + i);
        //        //8.Add code to the loop that stops it from executing once a match has been found.
        //        break;
        //    }

        //    //7.Add code to the loop that tells a user if they put in text that isn’t in the List.
        //    else if (dogs[i] != input)
        //    {
        //        Console.WriteLine("Sorry, that name is not in the list above");
        //        Console.WriteLine(dogs[i] + " is at index " + i ); 
        //    }  
        //}


        //Console.ReadLine();


        //9.Create a List of strings that has at least two identical strings in the List.
        //Ask the user to select text to search for in the List. Create a loop that iterates through the loop
        //and then displays the indices of the array that contain matching text on the screen.

        //Console.WriteLine("Please enter the name of your gas station");
        //string name = Console.ReadLine();

        //List<string> stations = new List<string>() { "Shell", "Arco", "Exxon", "Texaco", "Arco", "Shell" };
        //List<string> matching = new List<string>();

        //foreach (string station in stations)
        //{
        //    if (station == name)
        //    {
        //        matching.Add(station);
        //        Console.WriteLine(station + " is located at index " + matching.Count);

        //    }

        //    //Console.WriteLine("You entered " + name + " which is at" + " index " + matching.Count);

        //    //else if
        //    //{
        //    //    Console.WriteLine("I do not have a listing for that name at index " + matching.Count );
        //    //    //break;
        //    //}
        //}

        //Console.ReadLine();

        //10.Add code to that above loop that tells a user if they put in text that isn’t in the List.

        //Console.WriteLine("Please enter the name of your gas station");
        //string name = Console.ReadLine();

        //List<string> stations = new List<string>() { "Shell", "Arco", "Exxon", "Texaco", "Arco", "Shell" };

        //foreach (string station in stations)
        //{
        //    if (name != station)
            
        //        {
        //            Console.WriteLine("You entered a name not in my list ");
        //        }   
        //}
        //Console.WriteLine("Press enter to exit");
        //Console.ReadLine();


        //11.Create a List of strings that has at least two identical strings in the List.
        //Create a foreach loop that evaluates each item in the list, and displays a message showing the string
        //and whether or not it has already appeared in the list.

        Console.WriteLine("Please enter the name of your gas station");
        string name = Console.ReadLine();

        List<string> stations = new List<string>() { "Shell", "Arco", "Exxon", "Texaco", "Arco", "Shell" };
        //List<string> matching = new List<string>();

        foreach (string station in stations)
        {
           if (stations.Contains(name))
            {
                Console.WriteLine("I found a match to " + name + " " + station.IndexOf(name));
                break;
            }
            if (name != station)
            {
                Console.WriteLine("That name not found");
                break;
            }

        }
        
        //Console.WriteLine(name + " is located at index " + matching.Count + " of my matching list and index " + stations.Count + " of my stations list");
        Console.WriteLine("Press enter to exit");
        Console.ReadLine();

    }
}
