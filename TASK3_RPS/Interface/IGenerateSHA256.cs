namespace TASK3_RPS.Interface
{
    internal interface IGenerateSHA256
    {
        string GenerateHMAC(string key, string message);
        string GenerateKey();
    }
}