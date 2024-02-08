
using System.Security.Cryptography;
using System.Text;
using TASK3_RPS.Interface;

namespace TASK3_RPS
{
    internal class GenerateSHA256 : IGenerateSHA256
    {
        public string GenerateKey()
        {
            var rng = RandomNumberGenerator.Create();
            byte[] byteKey = new byte[32];
            rng.GetBytes(byteKey);
            return BitConverter.ToString(byteKey).Replace("-", "");
        }

        public string GenerateHMAC(string key, string message)
        {
            var hmacsha256 = new HMACSHA256(Encoding.UTF8.GetBytes(key));
            var hash = hmacsha256.ComputeHash(Encoding.UTF8.GetBytes(message));
            return BitConverter.ToString(hash).Replace("-", "");
        }
    }
}
