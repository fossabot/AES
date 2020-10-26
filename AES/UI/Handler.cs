using System;

namespace AES.UI
{
    /// <summary>
    /// Command handler
    /// </summary>
    static class Handler
    {
        /// <summary>
        /// Execute the command
        /// </summary>
        /// <param name="command">Number of command in the list</param>
        public static void execute(int command)
        {
            switch (command) // FIXME
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    // ...
                    break;
                case 2:
                    // ...
                    break;
                default:
                    throw new Exception("Invalid number of the command!");
            }
        }

        /// <summary>
        /// Encrypt the open text
        /// </summary>
        /// <param name="openText">Open text</param>
        /// <returns>Encrypted text in base64</returns>
        private static string encryptText(string openText) // FIXME
        {
            // ...

            return null;
        }

        /// <summary>
        /// Decrypt the text
        /// </summary>
        /// <param name="cypherText">Cipher text in base64</param>
        /// <returns>Decrypted string</returns>
        private static string decryptText(string cypherText) // FIXME
        {
            // ...

            return null;
        }
    }
}
