using ChefLife.Core;

namespace ChefLife
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set the Console Output Encoding to UTF-8
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Welcome to Chef's Life!");
            Console.WriteLine("Loading game...");

            // Create and start the game
            Game game = new Game();
            game.Start();

            Console.WriteLine("Thanks for playing Chef's Life!");
        }
    }
}
