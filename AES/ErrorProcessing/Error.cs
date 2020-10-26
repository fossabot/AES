using System;

namespace AES.ErrorProcessing
{
    /// <summary>
    /// Class for the error handling
    /// </summary>
    static class Error
    {
        /// <summary>
        /// Print error to the screen
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="stackTrace">Stack trace</param>
        /// <param name="source">Exception source</param>
        public static void print(string message, string stackTrace = null, string source = null)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("\n----- Error -----\n");

            Console.Write("What's happened: ");
            Console.WriteLine(message);

            if (source != null)
            {
                Console.WriteLine();

                Console.Write("Source: ");
                Console.WriteLine(source);

                Console.WriteLine();
            }

            if (stackTrace != null)
            {
                Console.Write("Stack trace:\n");
                Console.WriteLine(stackTrace);
            }

            Console.WriteLine("\n----- End of the error message -----\n");

            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
