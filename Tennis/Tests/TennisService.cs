using NUnit.Framework;
using Tennis;

namespace Tennis.Service.Unit.Tests
{
    public class Tests
    {
        //   _score unit test 
        [TestCase(0, 0, "Love All")]
        [TestCase(1, 0, "Fifteen Love")]
        [TestCase(2, 1, "Thirty Fifteen")]
        [TestCase(3, 2, "Forty Thirty")]
        [TestCase(3, 3, "Deuce")]
        [TestCase(4, 3, "Advantage")]
        [TestCase(4, 4, "Deuce")]
        [TestCase(5, 3, "PlayerA Win")]
        [TestCase(4, 2, "PlayerA Win")]
        [TestCase(2, 4, "PlayerB Win")]
        public void Test1(int firstPlayerScore, int secondPlayerScore, string expectAnswer)
        {
            string FirstPlayerName = "PlayerA";
            string SecondPlayerName = "PlayerB";
            string scoreString = TennisService.Score(FirstPlayerName, SecondPlayerName, firstPlayerScore, secondPlayerScore);
            Assert.AreEqual(expectAnswer, scoreString);
        }
    }
}