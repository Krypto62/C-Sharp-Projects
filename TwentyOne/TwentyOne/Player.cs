using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Player
    {
        //Constructor that takes 2 parameters: A name and a beginning balance and it will assign some values
        public Player(string name, int beginningBalance)
        {
            Hand = new List<Card>(); //creat an empty list Card (Have to initialize lists or else can't add items to them)
            Balance = beginningBalance; //assigning the arguments (name and beginningbalance) and assigning them to properties of this object.
            Name = name;
        }
        public List <Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; } //this property could be specific to 21

        //Player is doing the betting so this logic is located in this Player class
        public bool Bet(int amount)
        {
            //If player bets more than he has...
            if (Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough to place a bet that size.");
                return false;
            }
            else
            {
                Balance -= amount; //Short form of Balance = Balance - amount;
                return true;
            }
        }

        public static Game operator +(Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
