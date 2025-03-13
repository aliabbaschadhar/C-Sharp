using System;
using System.Collections.Generic;

namespace CSharpAdvance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Player player1 = new Player("Chad");
            // Player player2 = new Player("Steve");
            // Player player3 = new Player("Karen");

            List<Player> players = new List<Player>();

            players.Add(new Player("Chad"));
            players.Add(new Player("Steve"));
            players.Add(new Player("Karen"));

            foreach (Player player in players)
            {
                Console.WriteLine(player.name);
            }
        }
    }

    class Player
    {
        public string name;
        public Player(string name)
        {
            this.name = name;
        }
    }
}