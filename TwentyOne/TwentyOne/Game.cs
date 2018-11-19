using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game
    {
        //Make sure that our list Players is never null, that it is always at least an empty list. 
        //So we instantiate an empty list. Players now will always at least equal an empty list (not null).
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();

        //This class is just a list of players. Capable of handling multiple players.
        //Used to always have a private and a public list. get; set; abreviates that.
        public List<Player> Players { get { return _players; } set { _players = value; } } //Old way of get; set;
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }

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
