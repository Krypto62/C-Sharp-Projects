using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game
    {
        //This class is just a list of players. Capable of handling multiple players.
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get; set; }

        public abstract void Play();

        public virtual void ListPlayers()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
