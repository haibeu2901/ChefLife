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
        public bool IsSpecial { get; set; }

        public Ingredient(string name, string description, decimal price, bool isSpecial = false)
        {
            Name = name;
            Description = description;
            Price = price;
            IsSpecial = isSpecial;
        }

        public void DisplayIngredient()
        {
            Console.WriteLine($"{Name} - ${Price} per unit");
            Console.WriteLine(Description);
            if (IsSpecial) Console.WriteLine("✨ Special ingredient ✨");
        }


    }
}
