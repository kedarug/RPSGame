using RPSGame.Models;

namespace RPSGame
{
    public interface IGameManager
    {
        GameResult Run(IPlayer player1, IPlayer player2, IRuleManager ruleManager);
    }
}