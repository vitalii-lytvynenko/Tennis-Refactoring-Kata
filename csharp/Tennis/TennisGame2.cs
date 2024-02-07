using Microsoft.VisualBasic;

namespace Tennis
{
    public class TennisGame2 : ITennisGame
    {
        private int _player1points;
        private int _player2points;

        private string player1result = "";
        private string player2result = "";
        private readonly string _player1Name;
        private readonly string _player2Name;

        public TennisGame2(string player1Name, string player2Name)
        {
            _player1Name = player1Name;
            _player2Name = player2Name;
        }

        public string GetScore()
        {
            string score = "";

            if (_player1points == _player2points && _player1points < 3)
            {
                if (_player1points == 0)
                    score = "Love";
                if (_player1points == 1)
                    score = "Fifteen";
                if (_player1points == 2)
                    score = "Thirty";
                score += "-All";
            }
            if (_player1points == _player2points && _player1points > 2)
                score = "Deuce";

            if (_player1points > 0 && _player2points == 0)
            {
                if (_player1points == 1)
                    player1result = "Fifteen";
                if (_player1points == 2)
                    player1result = "Thirty";
                if (_player1points == 3)
                    player1result = "Forty";

                player2result = "Love";
                score = player1result + "-" + player2result;
            }
            if (_player2points > 0 && _player1points == 0)
            {
                if (_player2points == 1)
                    player2result = "Fifteen";
                if (_player2points == 2)
                    player2result = "Thirty";
                if (_player2points == 3)
                    player2result = "Forty";

                player1result = "Love";
                score = player1result + "-" + player2result;
            }

            if (_player1points > _player2points && _player1points < 4)
            {
                if (_player1points == 2)
                    player1result = "Thirty";
                if (_player1points == 3)
                    player1result = "Forty";
                if (_player2points == 1)
                    player2result = "Fifteen";
                if (_player2points == 2)
                    player2result = "Thirty";
                score = player1result + "-" + player2result;
            }
            if (_player2points > _player1points && _player2points < 4)
            {
                if (_player2points == 2)
                    player2result = "Thirty";
                if (_player2points == 3)
                    player2result = "Forty";
                if (_player1points == 1)
                    player1result = "Fifteen";
                if (_player1points == 2)
                    player1result = "Thirty";
                score = player1result + "-" + player2result;
            }

            if (_player1points > _player2points && _player2points >= 3)
            {
                score = $"Advantage {_player1Name}";
            }

            if (_player2points > _player1points && _player1points >= 3)
            {
                score = $"Advantage {_player2Name}";
            }

            if (_player1points >= 4 && _player2points >= 0 && (_player1points - _player2points) >= 2)
            {
                score = $"Win for {_player1Name}";
            }
            if (_player2points >= 4 && _player1points >= 0 && (_player2points - _player1points) >= 2)
            {
                score = $"Win for {_player2Name}";
            }
            return score;
        }

        public void WonPoint(string player)
        {
            if (player == _player1Name)
                _player1points++;
            else
                _player2points++;
        }
    }
}

