namespace Tennis
{
    public class TennisGame2 : ITennisGame
    {
        private int _player1points;
        private int _player2points;

        private readonly string _player1Name;
        private readonly string _player2Name;

        private static readonly string[] pointNames = { "Love", "Fifteen", "Thirty", "Forty" };

        public TennisGame2(string player1Name, string player2Name)
        {
            _player1Name = player1Name;
            _player2Name = player2Name;
        }

        public string GetScore()
        {
            var isDraw = _player1points == _player2points;

            var IsAdvantageOrWin = _player1points >= 4 || _player2points >= 4;

            if (isDraw)
            {
                return _player1points >= 3 ? "Deuce" : $"{GetPointName(_player1points)}-All";
            }
            else if (IsAdvantageOrWin)
            {
                return AdvantageOrWinResult();
            }
            else
            {
                return $"{GetPointName(_player1points)}-{GetPointName(_player2points)}";
            }
        }

        private string AdvantageOrWinResult()
        {
            var difference = _player1points - _player2points;
            if (difference == 1)
            {
                return $"Advantage {_player1Name}";
            }
            else if (difference == -1)
            {
                return $"Advantage {_player2Name}";
            }
            else
            {
                return difference >= 2 ? $"Win for {_player1Name}" : $"Win for {_player2Name}";
            }
        }

        private static string GetPointName(int point) => point >= 0 && point < pointNames.Length ? pointNames[point] : "";
        
        public void WonPoint(string player)
        {
            if (player == _player1Name)
                _player1points++;
            else
                _player2points++;
        }
    }
}

