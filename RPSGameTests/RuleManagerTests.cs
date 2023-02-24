using RPSGame;
using RPSGame.Models;

namespace RPSGameTests
{
    /// <summary>
    /// We need to test the flow here. 
    /// In this case, the flow looks simple. 
    /// But in certain scenarios, when loops are involved, we need to check if logic is implemented correctly. 
    /// </summary>
    public class GameManagerTests
    {

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Given_Player1SubmitChoice_CalledOnce()
        {
            //Arrange
            var mockHuman = new Mock<IPlayer>();
            // set up human to submit choice as Rock. 
            mockHuman.Setup(p => p.SubmitChoice()).Returns(Selection.Rock);

            var mockComputer = new Mock<IPlayer>();
            mockComputer.Setup(p => p.SubmitChoice()).Returns(Selection.Rock);

            var mockRuleManager = new Mock<IRuleManager>();
            mockRuleManager.Setup(r => r.ExecuteRules(It.IsAny<Selection>(), It.IsAny<Selection>())).Returns(GameResult.Win);

            //Act. 
            IGameManager game = new GameManager();
            game.Run(mockHuman.Object, mockComputer.Object, mockRuleManager.Object);
            //Assert. 
            // verify human submit choice is called once. 
            mockHuman.Verify(h => h.SubmitChoice(), Times.Once);
            mockComputer.Verify(c => c.SubmitChoice(), Times.Once);
            mockRuleManager.Verify(r => r.ExecuteRules(Selection.Rock, It.IsAny<Selection>()), Times.Once);
        }

        [Test]
        public void Given_ExecuteRule_CalledOnce()
        {
            //Arrange
            var mockHuman = new Mock<IPlayer>();
            // set up human to submit choice as Rock. 
            mockHuman.Setup(p => p.SubmitChoice()).Returns(Selection.Rock);

            var mockComputer = new Mock<IPlayer>();
            mockComputer.Setup(p => p.SubmitChoice()).Returns(Selection.Rock);

            Assert.Pass();
        }

        //[Test]
        //public void Given_Human_As_Rock_Computer_As_Rock()
        //{
        //    //Arrange
        //    var mockHuman = new Mock<HumanPlayer>();
        //    // set up human to submit choice as Rock. 
        //    mockHuman.SetupGet( p => p.SubmitChoice()).Returns(Selection.Rock);

        //    var mockComputer = new Mock<ComputerPlayer>();
        //    mockComputer.SetupGet(p => p.SubmitChoice()).Returns(Selection.Rock);

        //    Assert.Pass();
        //}
    }
}