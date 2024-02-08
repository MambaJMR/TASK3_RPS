using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK3_RPS.Interface;

namespace TASK3_RPS.Classes
{
    internal class Move : IMove
    {
        public int MovePlayer(string[] moves, string inputMove)
        {
            try
            {
                int moveNum = Convert.ToInt32(inputMove);
                Console.WriteLine($"Your move: {moves[moveNum - 1]}");
                return moveNum;
            }
            catch 
            {
                throw new Exception("ERROR: There is no such option");
            }
        }

        public int MoveComputer(string[] moves)
        {
            Random randomMoveComputer = new();
            int computerMove = randomMoveComputer.Next(1, moves.Length + 1);
            return computerMove;

        }
    }
}
