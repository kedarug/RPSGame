# RPSGame

Unit Testing : 
 
1. Use proper object oriented principles and name the classes based on the business requirements. 
2. Start with the design by naming classes and visualising class diagrams. 

GameManager ( Run, ShowResults)
    Player
        HumanPlayer, ComputerPlayer  (SubmitChoice)
    RulesManager

namespace RockPaperScissors
{
    public interface IPlayer
    {
        public string Name { get; }
        public Move Move { get; }
        public int Score { get; set; }

        public void MakeMove();
    }
}

 Use Enumerations to limit the inputs, and scenarios.  

3. SOLID Principles

Single Responsibillity
Open closed principle.
Liskov's Principle 
Interface seggregation 
Dependency Injection


Code covereage
Test only the code we write it. We dont have to test C# library code . Example - Computer making choice. We used Random. 
seperate the infrastructure code & the actual logic. Example - Human player making a choice. 
There is always scope of improvement, keep refactoring. 
You write the code not for yourself, but for the people who work on it after a year. Maintainable code. 

The purpose of this exercise is to create a program that will allow a user to play against the 
computer the game of rock paper scissors.
Game rules:
- Rock beats Scissors
- Scissors beats Paper
- Paper beats Rock
Application features:
- User submits their choice via the command line
- Computer picks random selection
- Display result on screen and allow to restart game without exiting


