using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefLife.Models
{
    internal class Ingredient
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool isSpecial { get; set; }

        public Ingredient(string name, string description, decimal price, bool isSpecial)
        {
            Name = name;
            Description = description;
            Price = price;
            this.isSpecial = isSpecial;
        }

        public void DisplayIngredient()
        {
            Console.WriteLine($"{Name} - ${Price} per unit");
            Console.WriteLine(Description);
            if (isSpecial) Console.WriteLine("✨ Special ingredient ✨");
        }
    }
}
