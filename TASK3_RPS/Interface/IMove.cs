namespace TASK3_RPS.Interface
{
    internal interface IMove
    {
        /// <summary>
        /// Generates a random computer move
        /// </summary>
        /// <param name="moves"></param>
        /// <returns></returns>
        int MoveComputer(string[] moves);
        /// <summary>
        /// The method handles the player's move
        /// </summary>
        /// <param name="move"></param>
        /// <param name="inputMove"></param>
        /// <returns></returns>
        int MovePlayer(string[] move, string inputMove);
    }
}