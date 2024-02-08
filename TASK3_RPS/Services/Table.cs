
using ConsoleTables;
using System.Collections.Generic;
using System.Data;
using TASK3_RPS.Interface;

namespace TASK3_RPS.Classes
{
    internal class Table : ITable
    {
        Rules rules = new();
        public void TableMenu(string[] moves)
        {          
            List<string> tableRows = new List<string>();
            List<string> tableNames = ["Name", .. moves];
            string[] result = tableNames.ToArray();
            var table = new ConsoleTable(result);

            for (int i = 0; i < moves.Length; i++)
            {
                tableRows.Add(moves[i].ToString());
                for (int j = 0; j < moves.Length; j++)
                {
                    tableRows.Add(rules.GameResult(rules.WinnerIdentification(moves.Length, i, j)).ToString());
                }
                string[] rowsTable = tableRows.ToArray();
                table.Rows.Add(rowsTable);
                tableRows.Clear();
            }
            table.Write();
        }
    }
}
