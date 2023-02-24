// See https://aka.ms/new-console-template for more information
using Moq;
using RPSGame;
using RPSGame.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to rock paper scissor game");


        IPlayer humanPlayer = new HumanPlayer();
        IPlayer computer = new ComputerPlayer();
        IRuleManager ruleManager = new RuleManager();

        
        IGameManager gameManager = new GameManager();
        var result = gameManager.Run(humanPlayer, computer, ruleManager);

        IDisplay display = new Display();
        display.Process(result, humanPlayer, computer);
    }
}