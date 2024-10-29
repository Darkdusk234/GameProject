using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class GameConsole
    {
        public Processor processor;
        public GraphicsCard graphicsCard;

        public List<Game> games;
        

        public GameConsole()
        {
            processor = new Processor();
            graphicsCard = new GraphicsCard();
            games = new List<Game>();
        }
    }
}
