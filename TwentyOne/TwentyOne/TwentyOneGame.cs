using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneGame : Game, IWalkAway
    {
        //Instantiate a Dealer. Dealer gets a hand also, which is not too common
        //so we are putting the property here instead of in the Dealer class.
        public TwentyOneDealer Dealer { get; set; }

        //This is an abstract method in the Game class. It plays one hand.
        public override void Play()
        {
            //Game has started, now we instantiate the dealer object as a new Twenty One game dealer
            Dealer = new TwentyOneDealer();

            //for each turn, the start of each round of playing where the dealer deals, we want to 
            //reset the players. We want their hand to be blank.
            foreach (Player player in Players) //Players is a property of the Game class
            {
                player.Hand = new List<Card>();
                player.Stay = false; //If it was true then it would carry over from the last hand and mess things up.
            }
            Dealer.Hand = new List<Card>(); //don't want old cards to stack up
            Dealer.Stay = false;
            //If we don't create a new deck each time we would end up with a partial deck each time.
            //this refreshes the deck each time.
            Dealer.Deck = new Deck();
            Console.WriteLine("Place your bet!");

            //In placing a bet, we want to loop through each player and them place a bet
            foreach (Player player in Players)
            {
                //Throw a section on the screen where the user will enter their bet
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successfullyBet = player.Bet(bet); //Pass the amount the user entered into the bet method
                if (!successfullyBet) //Same as "if successfullyBet == false"
                {
                    //Since we are in a void method and can't return anything, we are saying
                    //"end this method" and it goes back to the "While" method in Program, see that
                    //isActivelyPlaying is still there and balance is still greater than zero, so it
                    //will hit the Play method at the top of this class and say "Place your bet!" again.
                    return;
                }
                //if "successfullyBet" is true, it just bypasses the above "if" statement
                //Bets is the dictionary. "player" is the key. With this we add the player to the dictionary.
                Bets[player] = bet; //we now have the player's bet

            //We want to deal 2 cards, 1 at a time.
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players)
                {
                    Console.WriteLine("{0}: ", player.Name);
                    Dealer.Deal(player.Hand); //We pass in the player's hand and it's given a card
                    if (i == 1) //Check for BlackJack!
                    {
                        //Passing in the players hand to check it for BlackJack
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if (blackJack)
                        {
                            //Notify player is a winner and display his winning from the Bets table
                            Console.WriteLine("BlackJack! {0} wins {1}", player.Name, Bets[player]);

                            //Add the amount he won to the balance. Player wins his bet back plus 1.5x his bet as winnings
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5 + Bets[player]));

                            return; //Ends the round right here
                        }
                    }
                }
                //Deal the dealers hand
                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                if (i == 1) //Check for BlackJack
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has BlackJack! Everyone loses!");

                        //Give the dealer all the bets by iterating through the dictionary
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value; //Assign to the dealer the balance of everything
                        }
                    }
                }
            }
            //we are currently in a While loop (from the Program class), 
            //but don't know what stage we are at, so we want to reset all the players
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players:")
            base.ListPlayers();
        }
        public void WalkAway(Player player)
        {
            throw new NotFiniteNumberException...
        }
    }
}
