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






