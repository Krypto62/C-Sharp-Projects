using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.TwentyOne
{
    public class TwentyOneDealer : Dealer  //TwentyOneDealer inherits from the Dealer class
    {
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } } //Dealer also gets a hand.
        public bool Stay { get; set; } // 17 or above, dealer has to "stay"
        public bool isBusted { get; set; } //16 or below, dealer has to "hit".
    }
}
