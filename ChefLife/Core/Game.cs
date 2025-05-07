using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            
        }

        // Constructor
        public Game()
        {
            gameState = new GameState();
            ui = new UserInterface();
            random = new Random();
            dayNumber = 1;
            // Initialize game data

        }
    }
}
