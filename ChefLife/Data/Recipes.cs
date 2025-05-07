using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChefLife.Models;

namespace ChefLife.Data
{
    internal class Recipes
    {
        // Method to get all available recipes in the game
        public static List<Recipe> GetAllRecipes()
        {
            List<Recipe> recipes = new List<Recipe>
            {
                // Simple recipes (Difficulty 1)
                new Recipe(
                    "Scrambled Eggs",
                    "A simple breakfast dish made with eggs and butter.",
                    new Dictionary<string, int>{ {"Eggs", 2}, {"Butter", 1}, {"Salt", 1} },
                    1,
                    5.00m
                    ),

                new Recipe(
                    "Garden Salad",
                    "Fresh vegetables tossed together.",
                    new Dictionary<string, int>{ {"Lettuce", 2}, {"Tomato", 1}, {"Carrot", 1}, {"Bell Pepper", 1} },
                    1,
                    7.00m
                ),

                new Recipe(
                    "Toast with Butter",
                    "Simple toasted bread with butter.",
                    new Dictionary<string, int>{ {"Bread", 1}, {"Butter", 1} },
                    1,
                    3.50m
                ),

                new Recipe(
                    "Boiled Eggs",
                    "Classic hard-boiled eggs.",
                    new Dictionary<string, int>{ {"Eggs", 2}, {"Salt", 1} },
                    1,
                    4.00m
                ),

                new Recipe(
                    "Fruit Salad",
                    "A mix of fresh fruits.",
                    new Dictionary<string, int>{ {"Apple", 1}, {"Berries", 1}, {"Lemon", 1} },
                    1,
                    6.00m
                ),

                new Recipe(
                    "Grilled Cheese Sandwich",
                    "Toasted bread with melted cheese.",
                    new Dictionary<string, int>{ {"Bread", 2}, {"Cheese", 2}, {"Butter", 1} },
                    1,
                    5.50m
                ),

                new Recipe(
                    "Vegetable Soup",
                    "Light soup with assorted vegetables.",
                    new Dictionary<string, int>{ {"Carrot", 1}, {"Potato", 1}, {"Onion", 1}, {"Salt", 1} },
                    1,
                    6.50m
                ),

                new Recipe(
                    "Egg Salad",
                    "Chopped eggs mixed with seasoning.",
                    new Dictionary<string, int>{ {"Eggs", 2}, {"Salt", 1}, {"Black Pepper", 1} },
                    1,
                    5.75m
                ),

                new Recipe(
                    "Lemonade",
                    "Refreshing lemon drink.",
                    new Dictionary<string, int>{ {"Lemon", 2}, {"Sugar", 2}, {"Water", 1} },
                    1,
                    3.00m
                ),

                new Recipe(
                    "Garlic Bread",
                    "Bread infused with garlic and butter.",
                    new Dictionary<string, int>{ {"Bread", 1}, {"Garlic", 1}, {"Butter", 1} },
                    1,
                    4.50m
                ),

                // Medium recipes (Difficulty 2-3)
                new Recipe(
                    "Tomato Pasta",
                    "A classic pasta dish with tomato sauce.",
                    new Dictionary<string, int>{ {"Pasta", 2}, {"Tomato", 3}, {"Garlic", 1}, {"Basil", 1}, {"Salt", 1} },
                    2,
                    12.00m
                ),

                new Recipe(
                    "Grilled Chicken",
                    "Juicy chicken breast with herbs.",
                    new Dictionary<string, int>{ {"Chicken", 2}, {"Oregano", 1}, {"Lemon", 1}, {"Salt", 1}, {"Black Pepper", 1} },
                    2,
                    15.00m
                ),

                new Recipe(
                    "Mashed Potatoes",
                    "Creamy mashed potatoes with butter.",
                    new Dictionary<string, int>{ {"Potato", 3}, {"Butter", 2}, {"Milk", 1}, {"Salt", 1} },
                    2,
                    9.00m
                ),

                new Recipe(
                    "Stir-Fried Vegetables",
                    "Colorful vegetables stir-fried to perfection.",
                    new Dictionary<string, int>{ {"Bell Pepper", 2}, {"Carrot", 2}, {"Onion", 1}, {"Garlic", 1}, {"Salt", 1} },
                    2,
                    10.00m
                ),

                new Recipe(
                    "Chicken Fried Rice",
                    "Stir-fried rice with chicken and vegetables.",
                    new Dictionary<string, int>{ {"Rice", 2}, {"Chicken", 1}, {"Carrot", 1}, {"Onion", 1}, {"Eggs", 1}, {"Salt", 1} },
                    2,
                    13.00m
                ),

                new Recipe(
                    "Vegetable Curry",
                    "Spicy curry with mixed vegetables.",
                    new Dictionary<string, int>{ {"Potato", 1}, {"Carrot", 1}, {"Onion", 1}, {"Tomato", 2}, {"Garlic", 1}, {"Salt", 1} },
                    2,
                    11.50m
                ),

                new Recipe(
                    "Beef Stir-Fry",
                    "Quick stir-fried beef with vegetables.",
                    new Dictionary<string, int>{ {"Beef", 2}, {"Bell Pepper", 1}, {"Onion", 1}, {"Garlic", 1}, {"Soy Sauce", 1} },
                    3,
                    14.00m
                ),

                new Recipe(
                    "Spaghetti Carbonara",
                    "Pasta with a creamy egg-based sauce.",
                    new Dictionary<string, int>{ {"Pasta", 2}, {"Eggs", 2}, {"Cheese", 2}, {"Garlic", 1}, {"Salt", 1}, {"Black Pepper", 1} },
                    3,
                    15.00m
                ),

                new Recipe(
                    "Chicken Tacos",
                    "Soft tacos filled with grilled chicken and toppings.",
                    new Dictionary<string, int>{ {"Chicken", 2}, {"Taco Shells", 4}, {"Lettuce", 1}, {"Tomato", 1}, {"Cheese", 2}, {"Black Pepper", 1} },
                    2,
                    12.00m
                ),

                new Recipe(
                    "Beef Bolognese",
                    "Classic Italian pasta dish with rich beef sauce.",
                    new Dictionary<string, int>{ {"Beef", 2}, {"Pasta", 2}, {"Onion", 1}, {"Tomato", 2}, {"Garlic", 1}, {"Salt", 1} },
                    3,
                    18.00m
                ),

                new Recipe(
                    "Eggplant Parmesan",
                    "Fried eggplant topped with marinara and cheese.",
                    new Dictionary<string, int>{ {"Eggplant", 2}, {"Tomato", 2}, {"Cheese", 2}, {"Breadcrumbs", 1}, {"Garlic", 1} },
                    2,
                    16.00m
                ),

                // Advanced recipes (Difficulty 4-5)
                new Recipe(
                    "Beef Bourguignon",
                    "A classic French beef stew.",
                    new Dictionary<string, int>{ {"Beef", 3}, {"Onion", 2}, {"Carrot", 2}, {"Garlic", 2}, {"Tomato", 1}, {"Black Pepper", 1}, {"Salt", 1} },
                    4,
                    25.00m
                ),

                new Recipe(
                    "Apple Pie",
                    "Sweet apple filling in a flaky crust.",
                    new Dictionary<string, int>{ {"Flour", 3}, {"Butter", 3}, {"Sugar", 2}, {"Apple", 4}, {"Cinnamon", 1} },
                    4,
                    18.00m
                ),

                new Recipe(
                    "Risotto",
                    "Creamy Italian rice dish.",
                    new Dictionary<string, int>{ {"Rice", 2}, {"Onion", 1}, {"Butter", 2}, {"Cheese", 2}, {"Salt", 1}, {"Black Pepper", 1} },
                    4,
                    20.00m
                ),

                // Expert recipes (Difficulty 5)
                new Recipe(
                    "Truffle Pasta",
                    "Luxurious pasta with truffle.",
                    new Dictionary<string, int>{ {"Pasta", 2}, {"Cream", 2}, {"Truffle", 1}, {"Butter", 1}, {"Salt", 1} },
                    5,
                    45.00m
                ),

                new Recipe(
                    "Saffron Risotto",
                    "Elegant risotto with saffron.",
                    new Dictionary<string, int>{ {"Rice", 2}, {"Onion", 1}, {"Butter", 2}, {"Saffron", 1}, {"Cheese", 1}, {"Salt", 1} },
                    5,
                    40.00m
                ),

                new Recipe(
                    "Wagyu Steak",
                    "Premium Japanese beef cooked to perfection.",
                    new Dictionary<string, int>{ {"Wagyu Beef", 2}, {"Salt", 1}, {"Black Pepper", 1}, {"Butter", 1} },
                    5,
                    80.00m
                )
            };
            
            return recipes;
        }
    }
}
