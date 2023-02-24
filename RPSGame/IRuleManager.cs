using RPSGame.Models;

namespace RPSGame
{
    public interface IRuleManager
    {
        GameResult ExecuteRules(Selection humanSelection, Selection computerSelection);
    }
}