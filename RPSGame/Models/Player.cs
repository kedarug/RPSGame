using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPSGame.Models
{
    public interface IPlayer
    {
        Selection selection { get; set; }
        Selection SubmitChoice();
    }

    public class HumanPlayer : IPlayer
    {
        public Selection selection { get; set; }
        public GameResult Result { get; set; }
       

        //User submits their choice via the command line
        public Selection SubmitChoice()
        {
            //TD : The code is implemented along with Infrastructure code. This can be seperated. 
            Console.WriteLine("Enter the options to choose : \n" +
                "0 - Rock \n" +
                "1 - Scissors \n" +
                "2 - Paper");
            Selection selectValue = new Selection();
            int value = int.Parse(Console.ReadLine());
            {
                selectValue = (Selection)value;
            }
            selection = selectValue;
            return selection;
        }
    }

    public class ComputerPlayer : IPlayer
    {
        public Selection selection { get; set; }
        public Selection SubmitChoice()
        {
            //Computer picks random selection
            Random random = new Random();
            selection = Enum.Parse<Selection>(random.Next(3).ToString());
            return selection;
        }
    }

    public enum GameResult
    {
        Win = 0,
        Loose = 1,
        Draw = 2
    }

    public enum Selection
    {
        Rock = 0,
        Scissors = 1,
        Paper = 2
    }
    public enum PlayerType
    {
        Human,
        Computer
    }
}
