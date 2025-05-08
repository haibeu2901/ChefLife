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
                    case 0: // Go to Market
                        GoToMarket();
                        break;
                    case 1: // View Recipes
                        ViewRecipes();
                        break;
                    case 2: // View Inventory
                        ViewInventory();
                        break;
                    case 3: // Cook Something
                        CookSomething();
                        break;
                    case 4: // Serve Customers
                        ServeCustomers();
                        break;
                    case 5: // End Day
                        dayEnded = true;
                        break;
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
                        player.BuyIngredient(selectedIngredients.Name, quantity, selectedIngredients.Price);
                    }
                }
            }
        }

        // View recipes functionality
        private void ViewRecipes()
        {
            ui.DisplayTitle("Your Recipe Book");

            if (player.KnownRecipes.Count == 0)
            {
                ui.DisplayMessage("You don't know any recipes yet!");
            } else
            {
                foreach (Recipe recipe in player.KnownRecipes)
                {
                    recipe.DisplayRecipe();
                    ui.PressAnyKeyToContinue();
                }
            }
        }

        // View inventory functionality
        private void ViewInventory()
        {
            ui.DisplayTitle("Your Inventory");

            if (player.Inventory.Count == 0)
            {
                ui.DisplayMessage("Your inventory is empty!");
            } else
            {
                foreach (var item in player.Inventory)
                {
                    ui.DisplayMessage($"{item.Key}: {item.Value}");
                }
            }

            ui.PressAnyKeyToContinue();
        }

        // Cook something functionality
        private void CookSomething()
        {
            ui.DisplayTitle("Cook a Recipe");

            if (player.KnownRecipes.Count == 0)
            {
                ui.DisplayMessage("You don't know any recipes yet!");
                ui.PressAnyKeyToContinue();
                return;
            }

            // Display available recipes
            List<string> recipeOptions = new List<string>();
            foreach (Recipe recipe in player.KnownRecipes)      
            {
                recipeOptions.Add(recipe.Name);
            }
            recipeOptions.Add("Cancel");

            int choice = ui.DisplayMenu(recipeOptions);
            if (choice == recipeOptions.Count - 1)
            {
                return;
            }

            Recipe selectedRecipes = player.KnownRecipes[choice];
            selectedRecipes.DisplayRecipe();

            if (ui.ConfirmAction("Would you like to cook this recipe?"))
            {
                player.CookRecipe(selectedRecipes);
            }
        }

        // Serve customers functionality
        private void ServeCustomers()
        {
            ui.DisplayTitle("Serve Customers");

            if (todayCustomers.Count == 0)
            {
                ui.DisplayMessage("There are no customers today!");
                ui.PressAnyKeyToContinue();
                return;
            }

            // Get a random customer from today's list
            Customer customer = todayCustomers[random.Next(todayCustomers.Count)];
            todayCustomers.Remove(customer); // Remove this customer from the list

            ui.DisplayMessage($"{customer.Name} has entered your restaurant!");

            // Customer places an order
            Recipe orderedRecipe = customer.PlaceOrder(player.KnownRecipes);

            if (orderedRecipe == null)
            {
                ui.DisplayMessage("The customer couldn't find anything they wanted on the menu.");
                ui.PressAnyKeyToContinue();
                return;
            }

            // Ask player if they want to cook the order
            if (ui.ConfirmAction($"Will you cook {orderedRecipe.Name} for {customer.Name}?"))
            {
                // Try to cook the recipe
                bool success = player.CookRecipe(orderedRecipe);

                if (success)
                {
                    // Determine if it was cooked perfectly (80% chance of success for simplicity)
                    bool perfectCook = random.Next(1, 101) <= 80;

                    // Get customer's rating and tip
                    var (rating, tip) = customer.RateDishAndTip(orderedRecipe, perfectCook);

                    ui.DisplayMessage($"{customer.Name} rates your {orderedRecipe.Name} a {rating}/10!");

                    // Handle payment and tip
                    decimal payment = orderedRecipe.BasePrice + tip;
                    player.EarnMoney(payment);

                    if (tip > 0)
                    {
                        ui.DisplayMessage($"{customer.Name} left a tip of ${tip}!");
                    }

                    // Reputation gain based on rating
                    int reputationGain = rating - 5; // Can be negative for bad ratings
                    if (reputationGain != 0)
                    {
                        player.GainReputation(reputationGain);
                    }
                }
                else
                {
                    ui.DisplayMessage($"You couldn't cook {orderedRecipe.Name} for {customer.Name}.");
                    ui.DisplayMessage($"{customer.Name} leaves disappointed.");
                    player.GainReputation(-1); // Small reputation loss
                }
            }
            else
            {
                ui.DisplayMessage($"{customer.Name} leaves disappointed.");
                player.GainReputation(-1); // Small reputation loss
            }

            ui.PressAnyKeyToContinue();
        }
    }
}
