using System;
using System.Text.RegularExpressions;

namespace Tennis
{
    public class TennisService
    {
        // score to term
        private static string[] ScoreToTerm = { "Love", "Fifteen", "Thirty", "Forty" };
        // special string
        private const string ZeroToZero = "Love All";
        private const string Drew = "Deuce";
        private const string Advantage = "Advantage";
        private const string Win = "{name} Win";

        public static string Score(string firstPlayerName, string secondPlayerName, int firstPlayerScore, int secondPlayerScore)
        {
            if (firstPlayerScore < 4 && secondPlayerScore < 4)
            {
                if (firstPlayerScore == 0 && secondPlayerScore == 0)
                {
                    return ZeroToZero;
                }

                if (firstPlayerScore == 3 && secondPlayerScore == 3)
                {
                    return Drew;
                }

                return ScoreToTerm[firstPlayerScore] + " " + ScoreToTerm[secondPlayerScore];
            }

            if (Math.Abs(firstPlayerScore - secondPlayerScore) == 0)
            {
                return Drew;
            }

            if (Math.Abs(firstPlayerScore - secondPlayerScore) == 1)
            {
                return Advantage;
            }

            if (Math.Abs(firstPlayerScore - secondPlayerScore) == 2)
            {
                string winnerName = (firstPlayerScore > secondPlayerScore ? firstPlayerName : secondPlayerName);
                return Regex.Replace(Win, @"\{name\}", winnerName);
            }

            return "";
        }
    }
}
