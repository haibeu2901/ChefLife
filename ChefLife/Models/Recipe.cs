using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefLife.Models
{
    internal class Recipe
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Dictionary<string, int> Ingredients { get; set; }
        public int Difficulty { get; set; }
        public decimal BasePrice { get; set; }

        public Recipe(string name, string description, Dictionary<string, int> ingredients, int difficulty, decimal basePrice)
        {
            Name = name;
            Description = description;
            Ingredients = ingredients;
            Difficulty = Math.Clamp(difficulty,1,5);
            BasePrice = basePrice;
        }

        public string GetDifficultyStars()
        {
             return new string('*', Difficulty);
            //return new string('★', Difficulty) + new string('☆', 5 - Difficulty);
        }

        public void DisplayRecipe()
        {
            Console.WriteLine($"===== {Name} =====");
            Console.WriteLine(Description);
            Console.WriteLine($"Difficulty: {GetDifficultyStars()}");
            Console.WriteLine($"Base Price: ${BasePrice}");
            Console.WriteLine("Ingredients:");
            foreach (var ingre in Ingredients)
            {
                Console.WriteLine($"{ingre.Key}: {ingre.Value}");
            }
            Console.WriteLine("================");
        }
    }
}
