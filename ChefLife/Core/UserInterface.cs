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
            int choice = get
        }
    }
}
