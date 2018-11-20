using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casino.Interfaces;

namespace Casino.TwentyOne
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
            Dealer.Deck.Shuffle();
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
                        return;
                    }
                }
            }
            //Each player now get's asked hit or stay until they stay
            foreach (Player player in Players)
            {
                while (!player.Stay) //While player is not staying
                {
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.Write("{0} ", card.ToString());
                    }
                    Console.WriteLine("\n\nHit or Stay?"); //Gives us two lines for spacing

                    //Convert response to lowercase to make it easier to work with
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        break; //Ends the loop and "While" loop stops
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand); //Gives them a card (prints card to console)
                    }
                    bool busted = TwentyOneRules.IsBusted(player.Hand); //Returns true or false
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} Busted! You now lose your bet of {1}. Your balance is now {2}", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Do you want to play again?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "yeah")
                        {
                            player.isActivelyPlaying = true;
                            return; //End the void function
                        }
                        else
                        {
                            player.isActivelyPlaying = false;
                            return; //End the void function
                        }
                    }
                }
            }
            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);

            //If any of this "While" loop is true, then loop breaks
            while (!Dealer.Stay && !Dealer.isBusted)  //As long as dealer is not busted...
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand); // Deal dealer a card
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand); //Check again if dealer is busted
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying.");
            }
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer Busted!");
                foreach (KeyValuePair<Player, int> entry in Bets)
                {
                    //The person is in the key value pair and won this amount. Based on the Bets table.
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value);
                    //Loop through each key value pair where their name equals the name in the dictionary
                    //using a lambda expression. Where produces a list.
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    Dealer.Balance -= entry.Value; //Subtract bet amount from the dealer
                }
                return; //Just ends the round right here.
            }
            //Comparing a player's hand to the dealer's hand.
            foreach (Player player in Players)
            {
                //Turns playerone into a nullible boolean. Now has the value of null
                //If player lost it returns "false. If player wins it returns "true.
                //If it's a push it returns "null".

                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);
                if (playerWon == null)
                {
                    Console.WriteLine("Push! No one wins.");
                    player.Balance += Bets[player]; //Give his bet back
                }
                else if (playerWon == true)
                {
                    Console.WriteLine("{0} won {1}!", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2); //Player's bet times 2
                    Dealer.Balance -= Bets[player]; //Subtract winnings from the dealer's balance
                }
                else
                {
                    Console.WriteLine("Dealer wins {0}!", Bets[player]);
                    Dealer.Balance += Bets[player];
                }
                Console.WriteLine("Play again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "yeah")
                {
                    player.isActivelyPlaying = true;
                }
                else
                {
                    player.isActivelyPlaying = false;
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
