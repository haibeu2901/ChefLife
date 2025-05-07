using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChefLife.Models;

namespace ChefLife.Data
{
    internal class Ingredients
    {
        public static List<Ingredient> GetAllIngredients()
        {
            List<Ingredient> ingredients = new List<Ingredient>
            {
                // Basic ingredients
                new Ingredient("Flour", "A basic baking ingredient", 2.50m),
                new Ingredient("Sugar", "Sweetener for desserts and more", 1.75m),
                new Ingredient("Salt", "Enhances flavor in most dishes", 1.00m),
                new Ingredient("Butter", "Rich fat used in cooking and baking", 3.50m),
                new Ingredient("Eggs", "Versatile ingredient for many dishes", 2.00m),
                new Ingredient("Baking Powder", "Leavening agent for baking", 1.25m),
                new Ingredient("Baking Soda", "Used in baking and cleaning", 1.10m),
                new Ingredient("Vinegar", "Acidic liquid for seasoning or pickling", 1.50m),
                new Ingredient("Yeast", "Used for fermenting and baking", 2.25m),
                new Ingredient("Oil", "Used in frying and cooking", 3.00m),
                new Ingredient("Cornstarch", "Thickening agent", 1.40m),
                new Ingredient("Honey", "Natural sweetener from bees", 3.75m),
                new Ingredient("Vanilla Extract", "Flavoring for desserts", 2.95m),
                new Ingredient("Lard", "Fat from pork used in baking", 2.25m),
                new Ingredient("Gelatin", "Used in jellies and desserts", 2.80m),

                // Vegetables
                new Ingredient("Tomato", "Red, juicy fruit used as vegetable", 1.25m),
                new Ingredient("Onion", "Aromatic vegetable for flavor base", 0.75m),
                new Ingredient("Garlic", "Strong aromatic ingredient", 1.00m),
                new Ingredient("Lettuce", "Leafy green for salads", 1.50m),
                new Ingredient("Carrot", "Sweet root vegetable", 0.80m),
                new Ingredient("Potato", "Starchy tuber vegetable", 0.90m),
                new Ingredient("Bell Pepper", "Sweet, crunchy vegetable", 1.75m),
                new Ingredient("Cucumber", "Cool, crunchy vegetable", 1.10m),
                new Ingredient("Spinach", "Leafy green high in iron", 1.40m),
                new Ingredient("Zucchini", "Soft green squash", 1.30m),
                new Ingredient("Celery", "Crunchy vegetable for soups and salads", 1.20m),
                new Ingredient("Broccoli", "Green cruciferous vegetable", 1.65m),
                new Ingredient("Cauliflower", "White cruciferous vegetable", 1.70m),
                new Ingredient("Green Beans", "Tender pods used in many dishes", 1.50m),
                new Ingredient("Eggplant", "Purple vegetable with soft texture", 1.80m),

                // Fruits
                new Ingredient("Apple", "Sweet, crisp fruit", 1.25m),
                new Ingredient("Lemon", "Sour citrus fruit", 0.90m),
                new Ingredient("Berries", "Assorted small fruits", 3.50m),

                // Proteins
                new Ingredient("Chicken", "Versatile poultry meat", 5.00m),
                new Ingredient("Beef", "Red meat from cattle", 7.50m),
                new Ingredient("Pork", "Meat from pigs", 6.00m),
                new Ingredient("Fish", "Fresh seafood", 8.00m),
                new Ingredient("Tofu", "Soy-based protein", 3.00m),

                // Dairy
                new Ingredient("Milk", "Dairy liquid", 2.25m),
                new Ingredient("Cheese", "Fermented dairy product", 4.50m),
                new Ingredient("Cream", "High-fat dairy product", 3.75m),

                // Grains & Pasta
                new Ingredient("Rice", "Versatile grain", 2.00m),
                new Ingredient("Pasta", "Wheat-based noodles", 2.25m),
                new Ingredient("Bread", "Baked dough staple", 2.75m),

                // Herbs & Spices
                new Ingredient("Basil", "Aromatic herb", 1.50m),
                new Ingredient("Oregano", "Mediterranean herb", 1.25m),
                new Ingredient("Black Pepper", "Spicy seasoning", 1.75m),
                new Ingredient("Cinnamon", "Sweet spice", 2.00m),

                // Special ingredients
                new Ingredient("Truffle", "Rare, aromatic fungus", 25.00m, true),
                new Ingredient("Saffron", "Expensive, aromatic spice", 30.00m, true),
                new Ingredient("Wagyu Beef", "Premium Japanese beef", 50.00m, true)
            };

            return ingredients;
        }
    }
}
