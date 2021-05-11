using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TristanReilly_S00199625
{
    class Game
    {
        // Properities for Game class
        public string Name { get; set; }
        public int MetacriticScore { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Game_Image { get; set; }

        public void DecreasePrice(int value) // Decrease the price of a game by inputted amount 
        {
            Price = Price - value;
        }
    }       
}
