using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneRules  //basic helper methods located here
    {
        //Collection of name/value pairs that will never change
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {
            //Dictionary entries - 1 for each face. Can't use enum 
            //because different faces (10, J, Q, K) all have the same value
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] =10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1 //Will add logic later that will add 10 to this value
        };
        //Since ace can be 1 or 11, this method calculates and returns, into an array, all possible hand values
        private static int[] GetAllPossibleHandValues(List<Card> Hand)  //private because we will only use it within this method
        {
            //Find out how many aces there are since these determine overall value.
            //returns a count in the form of aceCount
            int aceCount = Hand.Count(x => x.Face == Face.Ace); //Lambda expression asking if each card is equivalent to an ace.
            
            //This identifies number of aces + 1. (1|1 11|1, and 11|11). These are all the possible values of aces.
            int[] result = new int[aceCount + 1]; //Passes in the value of all the aces in the hand to "result" array
            
            //Lambda expression which looks up the values in our "_cardvalues" dictionary and sums them up
            int value = Hand.Sum(x => _cardValues[x.Face]);

            //Take the first value in our int array and assign int "value" to it
            result[0] = value;

            //If there are no aces (result = 1) there is only one possible value, so we check
            if (result.Length == 1) return result; //Don't need {} since only 1 line

            //Iterate through all possible values of Ace. Already have i at 0 above (result[0] = value).
            for (int i = 1; i < result.Length; i++) //result.Length is how many results there are
            {
                //value is the lowest possible value with all the aces equaling 1. Adding 10 to it makes 11
                //- the other ace value. If there were 2 aces, then formula would be 2 + (20).
                value += (i * 10); //value += is the same as value = value +
                result[i] = value;
            }
            return result; //Returns the result to the int[] result array.
        }

        //pass into the CheckForBlackJack method a list of cards called "Hand" 
        public static bool CheckForBlackJack(List<Card> Hand)
        {
            //Create an integer array of all possible values and pass in the hand that we are working with
            int[] possibleValues = GetAllPossibleHandValues(Hand);

            //Get the largest value. Only checking for BlackJack after 2 cards have been passed.
            int value = possibleValues.Max(); //Lambda expression getting the maximum possible value
            if (value == 21) return true; //Has BlackJack
            else return false; //No BlackJack
        }

        public static bool IsBusted(List<Card> Hand)
        {
            int value = GetAllPossibleHandValues(Hand).Min(); //If better is over the minimum then he is busted
            if (value > 21) return true;
            else return false;
        }

        public static bool ShouldDealerStay(List<Card> Hand)
        {
            int[] possibleHandValues = GetAllPossibleHandValues(Hand);
            foreach (int value in possibleHandValues)
            {
                if (value > 16 && value < 22) //If in this range dealer must stay
                {
                    return true;
                }                 
            }
            return false; //If it makes it down here, dealer shouldn't stay
        }
        
        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerCard)
        {
            //Get int array of all possible players by passing in the player's hand. Do the same for dealer.
            int[] playerResults = GetAllPossibleHandValues(PlayerHand);
            int[] dealerResults = GetAllPossibleHandValues(DealerHand);

            //Give me the player results where the items are less than 22 (highest possible score w/o busting).
            int playerScore = playerResults.Where(x => x < 22).Max();

            //Give me the dealer results where the items are less than 22 (highest possible score w/o busting).
            int dealerScore = dealerResults.Where(x => x < 22).Max();

            //CompareHands the two scores
            if (playerScore > dealerScore) return true; //Player beats the dealer
            else if (playerScore < dealerScore) return false; //Dealer beats the player
            else return null; //Equal score
        }
    }
}
