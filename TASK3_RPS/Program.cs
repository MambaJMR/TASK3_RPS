// See https://aka.ms/new-console-template for more information


using TASK3_RPS;
using TASK3_RPS.Classes;

if (ParametersValidation.Validate(args))
{
    Rules rules = new();
    Move move = new();
    Table table = new();
    GenerateSHA256 generateSHA256 = new();
    Game game = new (args, rules, move, table, generateSHA256);
    game.Play();
}


//using ConsoleTables;

//var table = new ConsoleTable("one", "two", "three");
//table.AddRow(1, 2, 3)
//     .AddRow("this line should be longer", "yes it is", "oh");

//table.Write();
//Console.WriteLine();


//Console.ReadKey();

//0 = камень
//1 = ножницы
//2 = бумага
// (a - b + p + n) % n - p
// p = n - 1 / 2

//Console.WriteLine(Math.Sign((0 - 3 + 3 + 7) % 7 - 3));
//Console.WriteLine(Math.Sign((2 - 2 + 1 + 3) % 3 - 1));
//Console.WriteLine(Math.Sign((2 - 1 + 1 + 3) % 3 - 1));
//Console.WriteLine();

//Console.WriteLine(Math.Sign((0 - 2 + 1 + 3) % 3 - 1));
//Console.WriteLine(Math.Sign((0 - 0 + 1 + 3) % 3 - 1));
//Console.WriteLine(Math.Sign((0 - 1 + 1 + 3) % 3 - 1));
//Console.WriteLine();





