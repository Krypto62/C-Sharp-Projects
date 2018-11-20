using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Grand Hotel and Casino";
            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name", casinoName);
            Guid identifier = Guid.NewGuid();

            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to play a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                //Player object with 2 values: playerName and bank. "We created a player"
                Player player = new Player(playerName, bank); //if user wants to play, we initialize him with playerName and bank, which is the beginning balance.

                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\scfow\logs\log.txt", true))
                {
                    file.WriteLine(player.Id); //Write the player's Guid to file 
                }

                //We created a player, now we create a game.
                Game game = new TwentyOneGame(); //polymorphism happening here. exposes those operators we overloaded earlier

                game += player; //We are adding player to the game
                player.isActivelyPlaying = true; //used in "while" loop... While player is actively playing, play the game
                
                //Checks if player is wanting to still play and also has enough money to play.
                //As long as these two conditions are met, this loop will continue.
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player; //When user exits the "While" loop we remove him from the game
                Console.WriteLine("Thank you for playing!");
            }
            //when the player exits, he gets this message...
            //if the player answers "no" to the above, he also gets this message.
            Console.WriteLine("Feel free to look around the casino. Bye for now");
            Console.Read();
        }   
    }
}
