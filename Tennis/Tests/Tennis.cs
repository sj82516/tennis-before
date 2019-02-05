using NUnit.Framework;
using Tennis;

namespace Tennis.Unit.Tests
{
    public class Tests
    {
        // test FirstPlayerScore
        [Test]
        public void TestFirstPlayerScore()
        {
            TennisGame game = new TennisGame("player1", "player2");
            game.FirstPlayerScore();
            int score = game.GetFirstPlaterScore();
            Assert.AreEqual(score, 1);
            game.FirstPlayerScore();
            score = game.GetFirstPlaterScore();
            Assert.AreEqual(score, 2);
        }

        // test SecondPlayerScore
        [Test]
        public void TestSecondPlayerScore()
        {
            TennisGame game = new TennisGame("player1", "player2");
            game.SecondPlayerScore();
            int score = game.GetSecondPlaterScore();
            Assert.AreEqual(score, 1);
            game.SecondPlayerScore();
            score = game.GetSecondPlaterScore();
            Assert.AreEqual(score, 2);
        }
    }
}