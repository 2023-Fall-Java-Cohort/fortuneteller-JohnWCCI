using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    public class ConsoleDisplay
    {
        private readonly string title;

        public ConsoleDisplay(string title)
        {
            this.title = title;
        }

        public void ClearScreen(string prompt ="")
        {
            Console.Clear();
            Console.WriteLine(title);
            Console.WriteLine();
            if (!string.IsNullOrEmpty(prompt))
            {
                Console.WriteLine(prompt);
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Prompts the input.
        /// </summary>
        /// <param name="display">The display.</param>
        /// <param name="isInteger">if set to <c>true</c> [is integer].</param>
        /// <param name="helpMessage">The help message.</param>
        /// <returns></returns>
        public string PromptInput(string display, bool isInteger = false, string helpMessage = "")
        {
            string retValue = string.Empty;
            Console.Write($"{display}? ");
            string lineInput = string.Empty;
            while (retValue.IsNull())
            {
                lineInput = Console.ReadLine();
                if (!lineInput.IsNull() && lineInput.ToUpper() == "HELP")
                {
                    lineInput = "";
                    if (!helpMessage.IsNull())
                    {
                        Console.WriteLine(helpMessage);
                    }
                } else if(!lineInput.IsNull() && lineInput.ToUpper() == "QUIT")
                {
                    Console.WriteLine();
                    Console.WriteLine("Nobody likes a quitter...");
                    Environment.Exit(0);
                }
                if(!lineInput.IsNull())
                {
                    retValue = lineInput;
                }
                else
                {
                    break;
                }
                if (isInteger)
                {
                    int intValue;
                    if(!int.TryParse(retValue,out intValue))
                    {
                        retValue = string.Empty;
                    }
                }
            }

            return retValue;
        }
    }
}
