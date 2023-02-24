using RPSGame.Models;

namespace RPSGame
{
    public interface IDisplay
    {
        void Process(GameResult result, IPlayer human, IPlayer computer);
    }
}