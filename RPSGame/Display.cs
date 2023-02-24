using RPSGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSGame
{
    public class Display : IDisplay
    {


        public void Process(GameResult result, IPlayer human, IPlayer computer)
        {
            Console.WriteLine("You "+ Enum.GetName<GameResult>(result) + " the game!");
            Console.WriteLine("Computer chose :" + Enum.GetName<Selection>(computer.selection));
            Console.ReadKey();
        }
    }
}
