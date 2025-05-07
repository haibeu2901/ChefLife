using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChefLife.Data;
using ChefLife.Models;

namespace ChefLife.Core
{
    internal class Game
    {
        private Chef player;
        private GameState gameState;
        private UserInterface ui;
        private List<Ingredient> availableIngredients;
        private List<Recipe> availableRecipes;
        private List<Customer> todayCustomers;
        private Random random;
        private int dayNumber;

        // Initialize game data (ingredients and recipes)
        private void InitializeGameData()
        {
            // Load ingredients from data
            availableIngredients = Ingredients.GetAllIngredients();
            // Load recipes from data
            availableRecipes = Recipes.GetAllRecipes();
            // Initialize empty customer list for the day
            todayCustomers = new List<Customer>();
        }

        // Constructor
        public Game()
        {
            gameState = new GameState();
            ui = new UserInterface();
            random = new Random();
            dayNumber = 1;
            // Initialize game data
            InitializeGameData();
        }

        private void CreatePlayerCharacter()
        {
            ui.DisplayTitle("Welcome to Chef's RPG Life!");
            ui.DisplayMessage("Before we begin, tell us about yourself...");
            string name = ui.GetUserInput("What is your chef's name?");
            player = new Chef(name);

            // Give the player some starter recipes
            List<Recipe> starterRecipes = Recipes.GetStarterRecipes();
            foreach (var recipe in starterRecipes)
            {
                player.LearnRecipe(recipe);
            }

            ui.DisplayMessage($"Welcome, Chef {name}! Your culinary adventure begins now!");
            ui.PressAnyKeyToContinue();
        }

        // Run the day's activities
        private void RunDay()
        {
            bool dayEnded = false;

            while (!dayEnded)
            {
                // Display main menu
                ui.DisplayTitle("\"What would you like to do?\"");
                List<string> options = new List<string>
                {
                    "Go to Market",
                    "View Recipes",
                    "View Inventory",
                    "Cook Something",
                    "Serve Customers",
                    "End Day"
                };
                int choice = ui.DisplayMenu(options);
                switch (choice)
                {
                    
                }
            }
        }

        private void GoToMarket()
        {
            bool exitMarket = false;

            while (!exitMarket)
            {
                ui.DisplayTitle("Market");
                ui.DisplayMessage($"Your money: ${player.Money}");

                // Display available ingredients to buy
                List<string> marketOptions = new List<string>();
                foreach (Ingredient ingredient in availableIngredients)
                {
                    marketOptions.Add($"{ingredient.Name} - ${ingredient.Price} each");
                }
                marketOptions.Add("Exit Market");

                int choice = ui.DisplayMenu(marketOptions);

                if (choice == marketOptions.Count - 1)
                {
                    exitMarket = true;
                } else
                {
                    // Buy the selected ingredient
                    Ingredient selectedIngredients = availableIngredients[choice];
                    int quantity = ui.GetIntegerInput($"How many {selectedIngredients.Name} would you like to buy?", 0, 100);
                    if (quantity > 0)
                    {

                    }
                }
            }
        }
    }
}
