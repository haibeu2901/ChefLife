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
        public int CoolingLevel { get; set; }
        public decimal Money { get; set; }
        public int Reputation {  get; set; }
        public Dictionary<string, int> Inventory { get; set; }
        public List<Recipe> KnownRecipes { get; set; }

        public Chef(string name)
        {
            Name = name;
            CoolingLevel = 1;
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
    }
}
