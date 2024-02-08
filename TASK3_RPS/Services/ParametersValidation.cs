namespace TASK3_RPS.Classes
{
    internal static class ParametersValidation
    {
        public static bool Validate(string[] parameters)
        {
            if (parameters.Length == 0)
            {
                Console.WriteLine("ERROR: You have not entered the parameters");
                return false;
            }
            else if (parameters.Length == 1)
            {
                Console.WriteLine("ERROR: Parameters must be greater than 1");
                return false;
            }
            else if (parameters.Length % 2 == 0)
            {
                Console.WriteLine("ERROR: There must be an odd number of parameters");
                return false;
            }
            else if (!(parameters.Length == parameters.Distinct().Count()))
            {
                Console.WriteLine("ERROR: All parameters must be unique");
                return false;
            }
            return true;
        }
    }
}
