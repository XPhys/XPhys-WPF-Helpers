namespace XPhys.Common.Helpers
{
    public class Base64
    {
        /// <summary>
        /// OBJECTIVE: Base64 encode
        /// </summary>
        /// <param name="plainText">Input plain text</param>
        /// <returns></returns>
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);

            return System.Convert.ToBase64String(plainTextBytes);
        }

        /// <summary>
        /// OBJECTIVE: Base65 decode
        /// </summary>
        /// <param name="base64EncodedData">Input based64 text</param>
        /// <returns></returns>
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}
