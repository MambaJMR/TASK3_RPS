namespace TASK3_RPS.Interface
{
    internal interface IRules
    {
        string GameResult(int result);
        int WinnerIdentification(int moves, int computerMove, int playerMove);
    }
}