using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TristanReilly_S00199625
{
    public class Game
    {
        // Properities for Game class
        public int GameID { get; set; }
        public string Name { get; set;}
        public decimal CriticScore { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string GameImage { get; set; }
        public string Platform { get; set; }

        //public List<Game> Games { get; set; }
        public virtual DbSet<GameData> Games { get; set; }

        public void DecreasePrice(int value) // Decrease the price of a game by inputted amount 
        {
            Price -= value;
        }
    }

    public class GameData:DbContext
    {
        public GameData() : base("MyGameData") { } // Name of DB

        public DbSet<Game> Games { get; set; } // Creates Games TBL

    }
}
