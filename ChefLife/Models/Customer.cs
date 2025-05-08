using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ChefLife.Models
{
    internal class Customer
    {
        public string Name { get; set; }
        public int Patience { get; set; }
        public int Generosity { get; set; }
        public List<string> PreferredDishes { get; set; }

        private static Random random = new Random();

        public Customer(string name, int patience, int generosity)
        {
            Name = name;
            Patience = Math.Clamp(patience, 1, 10);
            Generosity = Math.Clamp(generosity, 1, 10);
            PreferredDishes = new List<string>();
        }

        public static Customer CreateRandomCustomer()
        {
            string[] names = { "Alex", "Jamie", "Sam", "Taylor", "Morgan", "Casey", "Riley", "Jordan", "Quinn", "Avery" };
            string name = names[random.Next(names.Length)];
            int patience = random.Next(3, 11); //min is inclusive (the smallest number you can get).
            int generosity = random.Next(1, 11); // max is exclusive(you won’t get this number).

            return new Customer(name, patience, generosity);
        }

        // Method to place an order
        public Recipe PlaceOrder(List<Recipe> availableRecipes)
        {
            // If the menu is empty, return null
            if (availableRecipes.Count == 0)
                return null;

            // First try to order a preferred dish if it's available
            if (PreferredDishes.Count > 0)
            {
                foreach (string dishName in PreferredDishes)
                {
                    Recipe preferredRecipe = availableRecipes.Find(r => r.Name == dishName);
                    if (preferredRecipe != null)
                    {
                        // 70% chance to order a preferred dish
                        if (random.Next(1, 101) <= 70)
                        {
                            Console.WriteLine($"{Name} orders their favorite: {preferredRecipe.Name}!");
                            return preferredRecipe;
                        }
                    }
                }
            }

            // Otherwise, order a random dish
            Recipe randomRecipe = availableRecipes[random.Next(availableRecipes.Count)];
            Console.WriteLine($"{Name} orders: {randomRecipe.Name}");
            return randomRecipe;
        }

        // Method to rate the food and determine tip
        public (int rating, decimal tip) RateDishAndTip(Recipe recipe, bool perfectlyCrafted)
        {
            int baseRating = random.Next(3, 6); // Base rating between 3-5

            // Adjust rating based on if the dish was crafted perfectly
            if (perfectlyCrafted)
            {
                baseRating += 2;
            }
            else
            {
                baseRating -= 1;
            }

            // Preferred dish bonus
            if (PreferredDishes.Contains(recipe.Name))
            {
                baseRating += 1;
            }

            // Clamp final rating between 1-10
            int finalRating = Math.Clamp(baseRating, 1, 10);

            // Calculate tip based on the rating and customer's generosity
            decimal tipPercentage = (finalRating / 10.0m) * (Generosity / 10.0m);
            decimal tipAmount = recipe.BasePrice * tipPercentage;

            // Round tip to nearest 0.25
            tipAmount = Math.Round(tipAmount * 4) / 4;

            return (finalRating, tipAmount);
        }

        // Method to add a preferred dish
        public void AddPreferredDish(string dishName)
        {
            if (!PreferredDishes.Contains(dishName))
            {
                PreferredDishes.Add(dishName);
            }
        }
    }
}
