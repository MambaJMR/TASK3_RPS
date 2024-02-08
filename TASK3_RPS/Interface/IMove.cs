namespace TASK3_RPS.Interface
{
    internal interface IMove
    {
        int MoveComputer(string[] moves);
        int MovePlayer(string[] move, string inputMove);
    }
}