using System;

namespace AES.UI
{
    /// <summary>
    /// This class allows the user to interact with the program
    /// </summary>
    class UserInterface
    {
        /// <summary>
        /// Initialization the dialog with the user
        /// </summary>
        public static void start()
        {
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("AES encryption by l1ghth4t");

            while (true)
                ask();
        }

        /// <summary>
        /// Prompts the user for a command
        /// </summary>
        public static void ask()
        {
            try
            {
                Console.WriteLine("\nActions:\n[0] Exit\n[1] Encrypt text\n[2] Decrypt text");
                Console.Write("Program is ready. Choose an action: ");

                try
                {
                    command_ = Convert.ToInt32(Console.ReadLine());
                }

                catch (Exception e) { ErrorProcessing.Error.print(e.Message, e.StackTrace, e.Source); }

                Handler.execute(command_);
            }

            catch (Exception e) { ErrorProcessing.Error.print(e.Message); }
        }

        /// <summary>
        /// Print a message about successful completion of the process
        /// </summary>
        /// <param name="message">Message</param>
        public static void printSuccess(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(message);

            Console.ForegroundColor = ConsoleColor.Gray;
        }

        /// <summary>
        /// Number of the command
        /// </summary>
        private static int command_;
    }
}
