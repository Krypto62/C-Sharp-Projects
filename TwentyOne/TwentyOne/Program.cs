using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using Casino;
using Casino.TwentyOne;

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
            if (playerName.ToLower() == "admin")
            {
                //Reads all exceptions from the Db and assigns it this list here
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions) //Loop through them once we have them
                {
                    Console.WriteLine(exception.Id + " | ");
                    Console.WriteLine(exception.ExceptionType + " | ");
                    Console.WriteLine(exception.ExceptionMessage + " | ");
                    Console.WriteLine(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.Read();
                return;
            }
            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only.");
            }

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
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return; //Ends the program since this is in a void method and can' return anything.
                    }

                    catch (Exception ex) //Catches all exceptions with this generic exception
                    {
                        Console.WriteLine("An error occured. Please contact your System Administrator.");
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return; //Ends the program since this is in a void method and can' return anything.
                    }
                }
                game -= player; //When user exits the "While" loop we remove him from the game
                Console.WriteLine("Thank you for playing!");
            }
            //when the player exits, he gets this message...
            //if the player answers "no" to the above, he also gets this message.
            Console.WriteLine("Feel free to look around the casino. Bye for now");
            Console.Read();
        }

        private static void UpdateDbWithException(Exception ex)
        {
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = TwentyOneGame;
                                        Integrated Security = True; Connect Timeout = 30; Encrypt = False;
                                        TrustServerCertificate = False; ApplicationIntent = ReadWrite;
                                        MultiSubnetFailover = False";

            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                                    (@ExceptionType, @ExceptionMessage, @TimeStamp)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                //Send to the database
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = TwentyOneGame;
                                        Integrated Security = True; Connect Timeout = 30; Encrypt = False;
                                        TrustServerCertificate = False; ApplicationIntent = ReadWrite;
                                        MultiSubnetFailover = False";

            //Basically asking for everything w/o a "where" clause
            string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp From Exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>(); //Empty list that will return.

            //Open up the connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection); //Pass in our connection string
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read()) //while reader is open for each object...
                {
                    ExceptionEntity exception = new ExceptionEntity(); //map what we are getting back to our object
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);
                }
                connection.Close();
            }

            return Exceptions; //Returns a list of Exception entities.
        }
    }
}
