namespace TASK3_RPS.Interface
{
    internal interface IRules
    {
        /// <summary>
        /// The method works with the result of the game
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        string GameResult(int result);
        /// <summary>
        /// Determines the winner by algorithm
        /// </summary>
        /// <param name="moves"></param>
        /// <param name="computerMove"></param>
        /// <param name="playerMove"></param>
        /// <returns></returns>
        int WinnerIdentification(int moves, int computerMove, int playerMove);
    }
}