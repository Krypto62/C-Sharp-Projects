using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }
        
        public void Deal(List<Card> Hand) 
        {
            Hand.Add(Deck.Cards.First()); //Add the card to the hand that is passed in
            Console.WriteLine(Deck.Cards.First().ToString() + "\n"); //Write to Console what card was passed in. Then adds a new line
            Deck.Cards.RemoveAt(0);
        }
    }
}
