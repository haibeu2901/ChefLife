using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefLife.Models
{
    internal class Chef
    {
        public string Name {  get; set; }
        public int CookingLevel { get; set; }
        public decimal Money { get; set; }
        public int Reputation {  get; set; }
        public Dictionary<string, int> Inventory { get; set; }
        public List<Recipe> KnownRecipes { get; set; }

        public Chef(string name)
        {
            Name = name;
            CookingLevel = 1;
            Money = 10000.00m;
            Reputation = 0;
            Inventory = new Dictionary<string, int>();
            KnownRecipes = new List<Recipe>();
        }

        public void LearnRecipe(Recipe recipe)
        {
            if (!KnownRecipes.Contains(recipe))
            {
                KnownRecipes.Add(recipe);
                Console.WriteLine($"Learned new recipe: {recipe.Name}!");
            } else
            {
                Console.WriteLine($"You already know the recipe for {recipe.Name}.");
            }
        }

        public bool BuyIngredient(string name, int quantity, decimal price)
        {
            decimal totalCost = price * quantity;

            if (Money < totalCost)
            {
                Console.WriteLine("Not enough money to buy this ingredient!");
                return false;
            }

            Money -= totalCost;

            if (Inventory.ContainsKey(name))
            {
                Inventory[name] += quantity;
            } else
            {
                Inventory.Add(name, quantity);
            }

            Console.WriteLine($"Purchased {quantity} {name} for ${totalCost}");
            return true;
        }

        public void GainExperience(int amount)
        {
            // Simple leveling system
            if (amount > 0)
            {
                if (amount >= 100)
                {
                    CookingLevel++;
                    Console.WriteLine($"Level up! You are now Cooking Level {CookingLevel}");
                }
            }
        }

        public bool CookRecipe(Recipe recipe)
        {
            // Check if we have all ingredients
            foreach (var ingredient in recipe.Ingredients)
            {
                if (!Inventory.ContainsKey(ingredient.Key) || Inventory[ingredient.Key] < ingredient.Value)
                {
                    Console.WriteLine($"Not enough {ingredient.Key} to cook {recipe.Name}!");
                    return false;
                }
            }

            // Use ingredients
            foreach (var ingredient in recipe.Ingredients)
            {
                Inventory[ingredient.Key] -= ingredient.Value;
            }

            // Gain experience
            GainExperience(recipe.Difficulty * 10);

            Console.WriteLine($"Successfully cooked {recipe.Name}!");
            return true;
        }

        public void GainReputation(int amount)
        {
            Reputation += amount;
            Console.WriteLine($"Gained {amount} reputation points. Current reputation: {Reputation}");
        }

        public void EarnMoney(decimal amount)
        {
            Money += amount;
            Console.WriteLine($"Earned ${amount}. Current balance: ${Money}");
        }
    }
}
