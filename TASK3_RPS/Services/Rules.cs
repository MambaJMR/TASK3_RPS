using TASK3_RPS.Interface;

namespace TASK3_RPS.Classes
{
    internal class Rules : IRules
    {

        //n = количество ходов
        //p = n-1 половина от количества ходов
        //a = игрок 1
        //b = ход компьютера
        // (a - b + p + n) % n - p;
        //Console.WriteLine(Math.Sign((2 - 2 + 1 + 3) % 3 - 1));

        public int WinnerIdentification(int moves, int computerMove, int playerMove)
        {
            decimal halfMoves = (moves - 1) / 2;
            var result = Math.Sign((playerMove - computerMove + moves + halfMoves) % moves - halfMoves);
            return result;
        }

        public string GameResult(int result)
        {
            //TODO поменять название переменной;
            string res = string.Empty;
            switch (result)
            {
                case 1:
                    res = "Win";
                    break;
                case 0:
                    res = "Draw";
                    break;
                case -1:
                    res = "Lose";
                    break;
            }
            return res;
        }
    }
}
