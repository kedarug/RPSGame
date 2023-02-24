using RPSGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSGame
{
    public class RuleManager : IRuleManager
    {
        public RuleManager() { }

        public GameResult ExecuteRules(Selection humanSelection, Selection computerSelection)
        {
            //Implement the algorithm. 
            // More tests covering all scenarios. 
            /*
             *  Rock beats Scissors
                - Scissors beats Paper
                - Paper beats Rock
             */
            GameResult humanPlayerResult = GameResult.Loose;
            if (
                (humanSelection == Selection.Rock && computerSelection == Selection.Scissors) ||
                (humanSelection == Selection.Scissors && computerSelection == Selection.Paper) ||
                (humanSelection == Selection.Paper && computerSelection == Selection.Rock)
                )
                humanPlayerResult = GameResult.Win;
            else if(humanSelection == computerSelection)
                humanPlayerResult = GameResult.Draw;
            return humanPlayerResult;
        }
    }
}
