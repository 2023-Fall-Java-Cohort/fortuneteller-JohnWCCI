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
        public string PromptInput(string display, bool isInteger, string helpMessage)
        {
            string retValue = string.Empty;
            Console.Write($"{display}? ");
            string lineInput = string.Empty;
            while (string.IsNullOrEmpty(retValue))
            {

            }

        }
    }
}
