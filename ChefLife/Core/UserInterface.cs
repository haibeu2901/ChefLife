using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefLife.Core
{
    internal class UserInterface
    {
        // Method to display a title
        public void DisplayTitle(string title)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("==================================");
            Console.WriteLine($"      {title}");
            Console.WriteLine("==================================");
            Console.ResetColor();
            Console.WriteLine();
        }

        // Method to get user input
        public string GetUserInput(string prompt)
        {
            Console.WriteLine($"{prompt}");
            return Console.ReadLine().Trim();
        }

        // Method to get integer input within a range
        public int GetIntegerInput(string prompt, int min, int max)
        {
            while(true)
            {
                Console.Write($"{prompt}");
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    if (result >= min && result <=max)
                    {
                        return result;
                    }
                }
                Console.WriteLine($"Please enter a number between {min} and {max}.");
            }
        }

        // Method to display a message
        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        // Method to display a menu and get user choice
        public int DisplayMenu(List<string> options)
        {
            for (int i = 0; i < options.Count; i++)
            {
                Console.WriteLine($"{i+1}. {options[i]}");
            }

            Console.WriteLine() ;
            int choice = GetIntegerInput("Enter your choice: ", 1, options.Count);
            return choice - 1; // Return 0-based index
        }

        // Method to confirm an action
        public bool ConfirmAction(string prompt)
        {
            Console.Write($"{prompt} (Y/N): ");
            string input = Console.ReadLine().Trim().ToUpper();
            return input == "Y" || input == "YES";
        }

        // Method to pause until the user presses a key
        public void PressAnyKeyToContinue()
        {
            Console.WriteLine();
            Console.Write("Press any key to continue...");
            Console.ReadKey(true);
            Console.WriteLine();
        }
    }
}
