using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK3_RPS.Interface;

namespace TASK3_RPS.Classes
{
    internal class Game(string[] moves, IRules rules, IMove move, ITable table, IGenerateSHA256 generateSHA256)
    {
        private readonly string[] _moves = moves;
        private readonly IRules _rules = rules;
        private readonly IMove _move = move;
        private readonly ITable _table = table;
        private readonly IGenerateSHA256 _generateSHA256 = generateSHA256;

        private void DisplayMenu()
        {
            for (int i = 0; i < _moves.Length; i++)
            {
                Console.WriteLine($"{i+1} {_moves[i]}");
            }
            Console.WriteLine("? Help");
            Console.WriteLine("0 Exit");
            Console.WriteLine("Enter your move");
        }
        public void Play()
        {
            while (true)
            {
                var computerMove = _move.MoveComputer(_moves);
                var key = _generateSHA256.GenerateKey();
                Console.WriteLine("HMAC: " + _generateSHA256.GenerateHMAC(key, _moves[computerMove - 1]));
                DisplayMenu();
                
                string? inputMove = Console.ReadLine();

                if (inputMove == "?")
                {
                    _table.TableMenu(_moves);
                    break;
                }
                else if (inputMove == "0")
                {
                    Console.WriteLine("Bye Bye");
                    break;
                }
                else if (inputMove is null)
                {
                    break;
                }
                else
                {                   
                    var playerMove = _move.MovePlayer(_moves, inputMove);
                    Console.WriteLine($"Computer move: {_moves[computerMove - 1]}");
                    var winner = _rules.WinnerIdentification(_moves.Length, playerMove, computerMove);
                    Console.WriteLine($"Your: {_rules.GameResult(winner)}");
                    Console.WriteLine($"KEY: {key}\n");
                }

            }

            
        }
    }
}
