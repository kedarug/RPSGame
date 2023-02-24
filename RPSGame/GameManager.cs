using RPSGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSGame
{
    /// <summary>
    /// This is a flow object. 
    /// </summary>
    public class GameManager : IGameManager
    {
        public GameManager() { }
        public GameResult Run(IPlayer player1, IPlayer player2, IRuleManager ruleManager)
        {
            Selection selection1 = player1.SubmitChoice();
            Selection selection2 = player2.SubmitChoice();
            var result = ruleManager.ExecuteRules(selection1, selection2);
            return result;
        }
    }
}
