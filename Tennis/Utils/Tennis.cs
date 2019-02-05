using System;

namespace Tennis
{
    public class TennisGame
    {
        private string _firstPlayerName = "";
        private string _secondPlayerName = "";
        private int _firstPlayerScore = 0;
        private int _secondPlayerScore = 0;

        public TennisGame(string firstPlayerName, string secondPlayerName)
        {
            _firstPlayerName = firstPlayerName;
            _secondPlayerName = secondPlayerName;
        }

        public void Score()
        {
            string scoreString = TennisService.Score(_firstPlayerName, _secondPlayerName, _firstPlayerScore, _secondPlayerScore);
            Console.WriteLine(scoreString);
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScore++;
        }

        public void SecondPlayerScore()
        {
            _secondPlayerScore++;
        }

        public int GetFirstPlaterScore()
        {
            return _firstPlayerScore;
        }

        public int GetSecondPlaterScore()
        {
            return _secondPlayerScore;
        }
    }
}
