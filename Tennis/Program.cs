using System;

namespace Tennis
{
    class MainClass
    {
        public static void Main(string[] args)
        {
                TennisGame game = new TennisGame("GZ", "CNN");
                game.FirstPlayerScore();
                game.Score();
                game.SecondPlayerScore();
                game.Score();

                game.FirstPlayerScore();
                game.FirstPlayerScore();
                game.SecondPlayerScore();
                game.SecondPlayerScore();
                game.Score();

                game.SecondPlayerScore();
                game.Score();

                game.SecondPlayerScore();
                game.Score();
        }
    }
}
