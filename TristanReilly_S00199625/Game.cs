using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TristanReilly_S00199625
{
    public class Game
    {
        // Properities for Game class
        public string Name { get; set; }
        public decimal MetacriticScore { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Game_Image { get; set; }

        public void DecreasePrice(int value) // Decrease the price of a game by inputted amount 
        {
            Price -= value;
        }
    }       
}
