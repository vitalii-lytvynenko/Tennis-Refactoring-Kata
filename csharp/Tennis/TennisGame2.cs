using Microsoft.VisualBasic;

namespace Tennis
{
    public class TennisGame2 : ITennisGame
    {
        private int player1points;
        private int player2points;

        private string score = "";

        private string player1result = "";
        private string player2result = "";
        private string _player1Name;
        private string _player2Name;

        public TennisGame2(string player1Name, string player2Name)
        {
            _player1Name = player1Name;
            _player2Name = player2Name;
        }

        public string GetScore()
        {
            if (player1points == player2points && player1points < 3)
            {
                if (player1points == 0)
                    score = "Love";
                if (player1points == 1)
                    score = "Fifteen";
                if (player1points == 2)
                    score = "Thirty";
                score += "-All";
            }
            if (player1points == player2points && player1points > 2)
                score = "Deuce";

            if (player1points > 0 && player2points == 0)
            {
                if (player1points == 1)
                    player1result = "Fifteen";
                if (player1points == 2)
                    player1result = "Thirty";
                if (player1points == 3)
                    player1result = "Forty";

                player2result = "Love";
                score = player1result + "-" + player2result;
            }
            if (player2points > 0 && player1points == 0)
            {
                if (player2points == 1)
                    player2result = "Fifteen";
                if (player2points == 2)
                    player2result = "Thirty";
                if (player2points == 3)
                    player2result = "Forty";

                player1result = "Love";
                score = player1result + "-" + player2result;
            }

            if (player1points > player2points && player1points < 4)
            {
                if (player1points == 2)
                    player1result = "Thirty";
                if (player1points == 3)
                    player1result = "Forty";
                if (player2points == 1)
                    player2result = "Fifteen";
                if (player2points == 2)
                    player2result = "Thirty";
                score = player1result + "-" + player2result;
            }
            if (player2points > player1points && player2points < 4)
            {
                if (player2points == 2)
                    player2result = "Thirty";
                if (player2points == 3)
                    player2result = "Forty";
                if (player1points == 1)
                    player1result = "Fifteen";
                if (player1points == 2)
                    player1result = "Thirty";
                score = player1result + "-" + player2result;
            }

            if (player1points > player2points && player2points >= 3)
            {
                score = "Advantage player1";
            }

            if (player2points > player1points && player1points >= 3)
            {
                score = "Advantage player2";
            }

            if (player1points >= 4 && player2points >= 0 && (player1points - player2points) >= 2)
            {
                score = "Win for player1";
            }
            if (player2points >= 4 && player1points >= 0 && (player2points - player1points) >= 2)
            {
                score = "Win for player2";
            }
            return score;
        }

        private void P1Score()
        {
            player1points++;
        }

        private void P2Score()
        {
            player2points++;
        }

        public void WonPoint(string player)
        {
            if (player == "player1")
                P1Score();
            else
                P2Score();
        }

    }
}

