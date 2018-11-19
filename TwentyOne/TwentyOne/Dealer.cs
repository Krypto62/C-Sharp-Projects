using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            //Write to Console what card was passed in. Then adds a new line
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);

            //Create a new StreamWriter object. "true" here means "append".
            //By design, the "using" statement cleans itself up after file is written.
            using (StreamWriter file = new StreamWriter(@"C:\Users\scfow\logs\log.txt", true))
            {
                file.WriteLine(card); //Write (append) card to the file
            }
            Deck.Cards.RemoveAt(0);
        }
    }
}
