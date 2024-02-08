namespace TASK3_RPS.Interface
{
    internal interface IGenerateSHA256
    {
        /// <summary>
        /// Creates a HMAC with the SHA256 algorithm
        /// </summary>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        string GenerateHMAC(string key, string message);
        /// <summary>
        /// Creates a random key
        /// </summary>
        /// <returns></returns>
        string GenerateKey();
    }
}