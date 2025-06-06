﻿using System;
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
                    new Dictionary<string, int>
                    {
                        {"Eggs", 2},
                        {"Butter", 1},
                        {"Salt", 1}
                    },
                    1,
                    12.75m
                ),
                
                //new Recipe(
                //    "Garden Salad",
                //    "Fresh vegetables tossed together.",
                //    new Dictionary<string, int>
                //    {
                //        {"Lettuce", 2},
                //        {"Tomato", 1},
                //        {"Carrot", 1},
                //        {"Bell Pepper", 1}
                //    },
                //    1,
                //    7.00m
                //),
                
                //new Recipe(
                //    "Toast with Butter",
                //    "Simple toasted bread with butter.",
                //    new Dictionary<string, int>
                //    {
                //        {"Bread", 1},
                //        {"Butter", 1}
                //    },
                //    1,
                //    3.50m
                //),
                
                //new Recipe(
                //    "Boiled Eggs",
                //    "Classic hard-boiled eggs.",
                //    new Dictionary<string, int>
                //    {
                //        {"Eggs", 2},
                //        {"Salt", 1}
                //    },
                //    1,
                //    4.00m
                //),
                
                new Recipe(
                    "Fruit Salad",
                    "A mix of fresh fruits.",
                    new Dictionary<string, int>
                    {
                        {"Apple", 1},
                        {"Berries", 1},
                        {"Lemon", 1}
                    },
                    1,
                    8.00m
                ),
                
                new Recipe(
                    "Grilled Cheese Sandwich",
                    "Toasted bread with melted cheese.",
                    new Dictionary<string, int>
                    {
                        {"Bread", 2},
                        {"Cheese", 2},
                        {"Butter", 1}
                    },
                    1,
                    20.50m
                ),
                
                //new Recipe(
                //    "Vegetable Soup",
                //    "Light soup with assorted vegetables.",
                //    new Dictionary<string, int>
                //    {
                //        {"Carrot", 1},
                //        {"Potato", 1},
                //        {"Onion", 1},
                //        {"Salt", 1},
                //        {"Water", 2}
                //    },
                //    1,
                //    6.50m
                //),
                
                //new Recipe(
                //    "Egg Salad",
                //    "Chopped eggs mixed with seasoning.",
                //    new Dictionary<string, int>
                //    {
                //        {"Eggs", 2},
                //        {"Salt", 1},
                //        {"Black Pepper", 1}
                //    },
                //    1,
                //    5.75m
                //),
                
                //new Recipe(
                //    "Lemonade",
                //    "Refreshing lemon drink.",
                //    new Dictionary<string, int>
                //    {
                //        {"Lemon", 2},
                //        {"Sugar", 2},
                //        {"Water", 1}
                //    },
                //    1,
                //    3.00m
                //),
                
                //new Recipe(
                //    "Garlic Bread",
                //    "Bread infused with garlic and butter.",
                //    new Dictionary<string, int>
                //    {
                //        {"Bread", 1},
                //        {"Garlic", 1},
                //        {"Butter", 1}
                //    },
                //    1,
                //    4.50m
                //),
                
                //new Recipe(
                //    "Bacon and Eggs Breakfast",
                //    "Classic morning meal with crispy bacon.",
                //    new Dictionary<string, int>
                //    {
                //        {"Eggs", 2},
                //        {"Bacon", 2},
                //        {"Butter", 1},
                //        {"Salt", 1},
                //        {"Black Pepper", 1}
                //    },
                //    1,
                //    9.00m
                //),
                
                //new Recipe(
                //    "Avocado Toast",
                //    "Simple and nutritious breakfast with creamy avocado.",
                //    new Dictionary<string, int>
                //    {
                //        {"Bread", 1},
                //        {"Avocado", 1},
                //        {"Lemon", 1},
                //        {"Salt", 1},
                //        {"Black Pepper", 1}
                //    },
                //    1,
                //    7.00m
                //),
                
                //new Recipe(
                //    "Peanut Butter and Banana Sandwich",
                //    "Simple, satisfying sandwich with a sweet and savory filling.",
                //    new Dictionary<string, int>
                //    {
                //        {"Bread", 2},
                //        {"Peanut Butter", 1},
                //        {"Banana", 1},
                //        {"Honey", 1}
                //    },
                //    1,
                //    6.50m
                //),

                // Medium recipes (Difficulty 2-3)
                new Recipe(
                    "Tomato Pasta",
                    "A classic pasta dish with tomato sauce.",
                    new Dictionary<string, int>
                    {
                        {"Pasta", 2},
                        {"Tomato", 3},
                        {"Garlic", 1},
                        {"Basil", 1},
                        {"Salt", 1},
                        {"Olive Oil", 1}
                    },
                    2,
                    22.00m
                ),
                
                //new Recipe(
                //    "Grilled Chicken",
                //    "Juicy chicken breast with herbs.",
                //    new Dictionary<string, int>
                //    {
                //        {"Chicken", 2},
                //        {"Oregano", 1},
                //        {"Lemon", 1},
                //        {"Salt", 1},
                //        {"Black Pepper", 1},
                //        {"Olive Oil", 1}
                //    },
                //    2,
                //    15.00m
                //),
                
                //new Recipe(
                //    "Mashed Potatoes",
                //    "Creamy mashed potatoes with butter.",
                //    new Dictionary<string, int>
                //    {
                //        {"Potato", 3},
                //        {"Butter", 2},
                //        {"Milk", 1},
                //        {"Salt", 1}
                //    },
                //    2,
                //    9.00m
                //),
                
                //new Recipe(
                //    "Stir-Fried Vegetables",
                //    "Colorful vegetables stir-fried to perfection.",
                //    new Dictionary<string, int>
                //    {
                //        {"Bell Pepper", 2},
                //        {"Carrot", 2},
                //        {"Onion", 1},
                //        {"Garlic", 1},
                //        {"Salt", 1},
                //        {"Olive Oil", 1}
                //    },
                //    2,
                //    10.00m
                //),
                
                new Recipe(
                    "Chicken Fried Rice",
                    "Stir-fried rice with chicken and vegetables.",
                    new Dictionary<string, int>
                    {
                        {"Rice", 2},
                        {"Chicken", 1},
                        {"Carrot", 1},
                        {"Onion", 1},
                        {"Eggs", 1},
                        {"Salt", 1},
                        //{"Soy Sauce", 1},
                        {"Olive Oil", 1}
                    },
                    2,
                    27.00m
                ),
                
                //new Recipe(
                //    "Vegetable Curry",
                //    "Spicy curry with mixed vegetables.",
                //    new Dictionary<string, int>
                //    {
                //        {"Potato", 1},
                //        {"Carrot", 1},
                //        {"Onion", 1},
                //        {"Tomato", 2},
                //        {"Garlic", 1},
                //        {"Salt", 1},
                //        {"Turmeric", 1},
                //        {"Coconut Milk", 1}
                //    },
                //    2,
                //    11.50m
                //),
                
                //new Recipe(
                //    "Chocolate Chip Cookies",
                //    "Sweet, chewy cookies with chocolate chunks.",
                //    new Dictionary<string, int>
                //    {
                //        {"Flour", 2},
                //        {"Sugar", 2},
                //        {"Butter", 2},
                //        {"Eggs", 1},
                //        {"Chocolate", 2},
                //        {"Baking Soda", 1},
                //        {"Salt", 1},
                //        {"Vanilla Extract", 1}
                //    },
                //    2,
                //    8.50m
                //),
                
                //new Recipe(
                //    "Maple Banana Pancakes",
                //    "Fluffy pancakes with sweet banana and maple syrup.",
                //    new Dictionary<string, int>
                //    {
                //        {"Flour", 2},
                //        {"Eggs", 2},
                //        {"Milk", 1},
                //        {"Banana", 2},
                //        {"Butter", 1},
                //        {"Maple Syrup", 2},
                //        {"Baking Powder", 1}
                //    },
                //    2,
                //    10.50m
                //),
                
                //new Recipe(
                //    "Stir-Fried Beef with Vegetables",
                //    "Quick and flavorful Asian-inspired beef dish.",
                //    new Dictionary<string, int>
                //    {
                //        {"Beef", 2},
                //        {"Bell Pepper", 1},
                //        {"Carrot", 1},
                //        {"Onion", 1},
                //        {"Garlic", 1},
                //        {"Soy Sauce", 2},
                //        {"Rice", 1},
                //        {"Oil", 1}
                //    },
                //    2,
                //    16.00m
                //),
                
                //new Recipe(
                //    "Creamy Mushroom Pasta",
                //    "Rich pasta dish with sautéed mushrooms.",
                //    new Dictionary<string, int>
                //    {
                //        {"Pasta", 2},
                //        {"Mushrooms", 2},
                //        {"Cream", 1},
                //        {"Garlic", 1},
                //        {"Butter", 1},
                //        {"Parmesan", 1},
                //        {"Black Pepper", 1},
                //        {"Salt", 1}
                //    },
                //    2,
                //    14.50m
                //),
                
                //new Recipe(
                //    "Beef Stir-Fry",
                //    "Quick stir-fried beef with vegetables.",
                //    new Dictionary<string, int>
                //    {
                //        {"Beef", 2},
                //        {"Bell Pepper", 1},
                //        {"Onion", 1},
                //        {"Garlic", 1},
                //        {"Soy Sauce", 1},
                //        {"Oil", 1}
                //    },
                //    3,
                //    14.00m
                //),
                
                //new Recipe(
                //    "Spaghetti Carbonara",
                //    "Pasta with a creamy egg-based sauce.",
                //    new Dictionary<string, int>
                //    {
                //        {"Pasta", 2},
                //        {"Eggs", 2},
                //        {"Cheese", 2},
                //        {"Garlic", 1},
                //        {"Salt", 1},
                //        {"Black Pepper", 1},
                //        {"Bacon", 2}
                //    },
                //    3,
                //    15.00m
                //),
                
                //new Recipe(
                //    "Chicken Tacos",
                //    "Soft tacos filled with grilled chicken and toppings.",
                //    new Dictionary<string, int>
                //    {
                //        {"Chicken", 2},
                //        {"Taco Shells", 4},
                //        {"Lettuce", 1},
                //        {"Tomato", 1},
                //        {"Cheese", 2},
                //        {"Black Pepper", 1},
                //        {"Avocado", 1}
                //    },
                //    2,
                //    12.00m
                //),
                
                //new Recipe(
                //    "Beef Bolognese",
                //    "Classic Italian pasta dish with rich beef sauce.",
                //    new Dictionary<string, int>
                //    {
                //        {"Beef", 2},
                //        {"Pasta", 2},
                //        {"Onion", 1},
                //        {"Tomato", 2},
                //        {"Garlic", 1},
                //        {"Salt", 1},
                //        {"Olive Oil", 1}
                //    },
                //    3,
                //    18.00m
                //),
                
                //new Recipe(
                //    "Eggplant Parmesan",
                //    "Fried eggplant topped with marinara and cheese.",
                //    new Dictionary<string, int>
                //    {
                //        {"Eggplant", 2},
                //        {"Tomato", 2},
                //        {"Cheese", 2},
                //        {"Breadcrumbs", 1},
                //        {"Garlic", 1},
                //        {"Olive Oil", 1}
                //    },
                //    2,
                //    16.00m
                //),
                
                //new Recipe(
                //    "Spinach and Feta Omelette",
                //    "Fluffy eggs filled with spinach and cheese.",
                //    new Dictionary<string, int>
                //    {
                //        {"Eggs", 3},
                //        {"Spinach", 1},
                //        {"Cheese", 1},
                //        {"Butter", 1},
                //        {"Salt", 1},
                //        {"Black Pepper", 1}
                //    },
                //    2,
                //    8.50m
                //),
                
                //new Recipe(
                //    "Thai Coconut Curry",
                //    "Spicy and creamy vegetable curry.",
                //    new Dictionary<string, int>
                //    {
                //        {"Coconut Milk", 2},
                //        {"Chicken", 2},
                //        {"Bell Pepper", 1},
                //        {"Onion", 1},
                //        {"Garlic", 1},
                //        {"Rice", 1},
                //        {"Turmeric", 1},
                //        {"Salt", 1}
                //    },
                //    3,
                //    18.00m
                //),
                
                //new Recipe(
                //    "Mushroom Risotto",
                //    "Creamy Italian rice dish with earthy mushrooms.",
                //    new Dictionary<string, int>
                //    {
                //        {"Rice", 2},
                //        {"Mushrooms", 2},
                //        {"Onion", 1},
                //        {"Garlic", 1},
                //        {"Butter", 1},
                //        {"Parmesan", 1},
                //        {"Black Pepper", 1},
                //        {"Salt", 1}
                //    },
                //    3,
                //    15.00m
                //),
                
                //new Recipe(
                //    "Lamb Chops with Mint",
                //    "Tender lamb with fresh mint garnish.",
                //    new Dictionary<string, int>
                //    {
                //        {"Ground Lamb", 3},
                //        {"Mint", 2},
                //        {"Garlic", 1},
                //        {"Rosemary", 1},
                //        {"Salt", 1},
                //        {"Black Pepper", 1},
                //        {"Olive Oil", 1}
                //    },
                //    3,
                //    28.50m
                //),
                
                //new Recipe(
                //    "Coconut Lime Shrimp",
                //    "Tropical flavored seafood dish.",
                //    new Dictionary<string, int>
                //    {
                //        {"Shrimp", 3},
                //        {"Coconut Milk", 2},
                //        {"Lime", 2},
                //        {"Rice", 1},
                //        {"Garlic", 1},
                //        {"Salt", 1},
                //        {"Black Pepper", 1}
                //    },
                //    3,
                //    22.00m
                //),
                new Recipe (
                    "Vegetable Stir-Fry",
                    "A quick stir-fry with carrots, onions, and parsley.",
                    new Dictionary<string, int>
                    {
                        {"Carrot", 1},
                        {"Onion", 1},
                        {"Salt", 1},
                        {"Parsley", 1}
                    },
                    3,
                    9.00m
                ),

                new Recipe (
                    "Cheesy Rice Bowl",
                    "Warm rice topped with melted cheese.",
                    new Dictionary<string, int>
                    {
                        {"Rice", 2},
                        {"Cheese", 1},
                        {"Olive Oil", 1}
                    },
                    2,
                    18.50m
                ),

                // Advanced recipes (Difficulty 4)
                new Recipe(
                    "Chicken Alfredo",
                    "Creamy pasta with grilled chicken and herbs.",
                    new Dictionary<string, int>
                    {
                        {"Chicken", 2},
                        {"Pasta", 2},
                        {"Cream", 1},
                        {"Parsley", 1}
                    },
                    4,
                    30.00m
                ),

                //new Recipe(
                //    "Beef Bourguignon",
                //    "A classic French beef stew.",
                //    new Dictionary<string, int>
                //    {
                //        {"Beef", 3},
                //        {"Onion", 2},
                //        {"Carrot", 2},
                //        {"Garlic", 2},
                //        {"Tomato", 1},
                //        {"Black Pepper", 1},
                //        {"Salt", 1},
                //        {"Red Wine", 2},
                //        {"Bacon", 1},
                //        {"Mushrooms", 1}
                //    },
                //    4,
                //    25.00m
                //),
                
                //new Recipe(
                //    "Apple Pie",
                //    "Sweet apple filling in a flaky crust.",
                //    new Dictionary<string, int>
                //    {
                //        {"Flour", 3},
                //        {"Butter", 3},
                //        {"Sugar", 2},
                //        {"Apple", 4},
                //        {"Cinnamon", 1}
                //    },
                //    4,
                //    18.00m
                //),
                
                //new Recipe(
                //    "Risotto",
                //    "Creamy Italian rice dish.",
                //    new Dictionary<string, int>
                //    {
                //        {"Rice", 2},
                //        {"Onion", 1},
                //        {"Butter", 2},
                //        {"Cheese", 2},
                //        {"Salt", 1},
                //        {"Black Pepper", 1}
                //    },
                //    4,
                //    20.00m
                //),
                
                //new Recipe(
                //    "Duck à l'Orange",
                //    "Roast duck served with a tangy orange sauce.",
                //    new Dictionary<string, int>
                //    {
                //        {"Duck", 1},
                //        {"Orange", 2},
                //        {"Garlic", 1},
                //        {"Sugar", 1},
                //        {"Salt", 1},
                //        {"Black Pepper", 1}
                //    },
                //    4,
                //    35.00m
                //),
                
                //new Recipe(
                //    "Lobster Bisque",
                //    "Rich and creamy seafood soup.",
                //    new Dictionary<string, int>
                //    {
                //        {"Lobster", 2},
                //        {"Cream", 2},
                //        {"Garlic", 1},
                //        {"Tomato", 1},
                //        {"Onion", 1},
                //        {"Salt", 1}
                //    },
                //    4,
                //    30.00m
                //),
                
                //new Recipe(
                //    "Paella",
                //    "Spanish rice dish with seafood and sausage.",
                //    new Dictionary<string, int>
                //    {
                //        {"Rice", 2},
                //        {"Chicken", 1},
                //        {"Fish", 1},
                //        {"Tomato", 2},
                //        {"Garlic", 1},
                //        {"Saffron", 1},
                //        {"Shrimp", 2},
                //        {"Bell Pepper", 1},
                //        {"Olive Oil", 1}
                //    },
                //    4,
                //    40.00m
                //),
                
                //new Recipe(
                //    "Moussaka",
                //    "Layered Greek casserole with eggplant and lamb.",
                //    new Dictionary<string, int>
                //    {
                //        {"Eggplant", 3},
                //        {"Ground Lamb", 2},
                //        {"Tomato", 2},
                //        {"Garlic", 1},
                //        {"Cheese", 2},
                //        {"Salt", 1},
                //        {"Onion", 1},
                //        {"Olive Oil", 1}
                //    },
                //    4,
                //    28.00m
                //),
                
                //new Recipe(
                //    "Coq au Vin",
                //    "French chicken braised in red wine.",
                //    new Dictionary<string, int>
                //    {
                //        {"Chicken", 2},
                //        {"Red Wine", 2},
                //        {"Onion", 1},
                //        {"Carrot", 1},
                //        {"Garlic", 1},
                //        {"Bacon", 1},
                //        {"Mushrooms", 1}
                //    },
                //    4,
                //    32.00m
                //),
                
                //new Recipe(
                //    "Ratatouille",
                //    "A medley of roasted vegetables in a tomato sauce.",
                //    new Dictionary<string, int>
                //    {
                //        {"Zucchini", 2},
                //        {"Eggplant", 2},
                //        {"Tomato", 2},
                //        {"Onion", 1},
                //        {"Garlic", 1},
                //        {"Olive Oil", 1},
                //        {"Bell Pepper", 1},
                //        {"Basil", 1}
                //    },
                //    4,
                //    18.00m
                //),
                
                //new Recipe(
                //    "Beef Wellington",
                //    "Tender beef wrapped in puff pastry with mushroom duxelles.",
                //    new Dictionary<string, int>
                //    {
                //        {"Beef", 3},
                //        {"Mushrooms", 2},
                //        {"Butter", 2},
                //        {"Puff Pastry", 1},
                //        {"Salt", 1},
                //        {"Black Pepper", 1}
                //    },
                //    4,
                //    50.00m
                //),
                
                //new Recipe(
                //    "Chocolate Truffle Cake",
                //    "Decadent chocolate dessert with rich ganache.",
                //    new Dictionary<string, int>
                //    {
                //        {"Chocolate", 3},
                //        {"Flour", 2},
                //        {"Sugar", 2},
                //        {"Eggs", 3},
                //        {"Butter", 2},
                //        {"Cream", 1},
                //        {"Vanilla Extract", 1}
                //    },
                //    4,
                //    22.00m
                //),
                
                //new Recipe(
                //    "Avocado and Crab Salad",
                //    "Light and luxurious seafood salad.",
                //    new Dictionary<string, int>
                //    {
                //        {"Crab", 2},
                //        {"Avocado", 2},
                //        {"Lettuce", 1},
                //        {"Lemon", 1},
                //        {"Olive Oil", 1},
                //        {"Salt", 1},
                //        {"Black Pepper", 1}
                //    },
                //    4,
                //    26.00m
                //),
                
                //new Recipe(
                //    "Duck Breast with Orange Sauce",
                //    "Succulent duck with tangy citrus sauce.",
                //    new Dictionary<string, int>
                //    {
                //        {"Duck", 2},
                //        {"Orange", 2},
                //        {"Sugar", 1},
                //        {"Butter", 1},
                //        {"Salt", 1},
                //        {"Black Pepper", 1}
                //    },
                //    4,
                //    32.00m
                //),

                new Recipe(
                    "Lemon Fish Fillet",
                    "Pan-seared fish with lemon and herbs.",
                    new Dictionary<string, int>
                    {
                        {"Fish", 2},
                        {"Lemon", 1},
                        {"Basil", 1},
                        {"Salt", 1}
                    },
                    4,
                    29.00m
                ),

                new Recipe(
                    "Creamy Veggie Soup",
                    "A thick soup made with milk, onion, carrot, and garlic.",
                    new Dictionary<string, int>
                    {
                        {"Milk", 1},
                        {"Onion", 1},
                        {"Carrot", 1},
                        {"Garlic", 1}
                    },
                    4,
                    10.00m
                ),

                // Expert recipes (Difficulty 5)
                new Recipe(
                    "Morel Mushroom Risotto",
                    "A luxurious risotto made with rare morel mushroom and rich butter.",
                    new Dictionary<string, int>
                    {
                        {"Rice", 2},
                        {"Morel Mushrooms", 1},
                        {"Butter", 2},
                        {"Cheese", 2},
                        {"Black Pepper", 1}
                    },
                    5,
                    78.00m
                ),

                //new Recipe(
                //    "Truffle Butter Risotto",
                //    "A luxurious risotto made with rare truffles and rich butter.",
                //    new Dictionary<string, int>
                //    {
                //        {"Rice", 2},
                //        {"Truffle", 1},
                //        {"Butter", 2},
                //        {"Parmesan", 1},
                //        {"Black Pepper", 1}
                //    },
                //    5,
                //    60.00m
                //),
                
                //new Recipe(
                //    "Foie Gras on Toast",
                //    "A rich foie gras delicacy served on a crispy slice of bread, garnished with rosemary.",
                //    new Dictionary<string, int>
                //    {
                //        {"Foie Gras", 1},
                //        {"Bread", 1},
                //        {"Butter", 1},
                //        {"Rosemary", 1}
                //    },
                //    5,
                //    80.00m
                //),
                
                //new Recipe(
                //    "Caviar on Crackers",
                //    "An exquisite serving of luxurious caviar on crispy crackers, garnished with parsley.",
                //    new Dictionary<string, int>
                //    {
                //        {"Caviar", 1},
                //        {"Bread", 1},
                //        {"Parsley", 1}
                //    },
                //    5,
                //    100.00m
                //),
                
                //new Recipe(
                //    "Wagyu Beef Steak",
                //    "A premium Wagyu beef steak cooked to perfection, seasoned with rosemary and black pepper.",
                //    new Dictionary<string, int>
                //    {
                //        {"Wagyu Beef", 2},
                //        {"Rosemary", 1},
                //        {"Black Pepper", 1},
                //        {"Butter", 1}
                //    },
                //    5,
                //    120.00m
                //),
                
                //new Recipe(
                //    "Kobe Beef Tartare",
                //    "Finely chopped Kobe beef mixed with fresh lemon, parsley, and a touch of black pepper.",
                //    new Dictionary<string, int>
                //    {
                //        {"Kobe Beef", 2},
                //        {"Lemon", 1},
                //        {"Parsley", 1},
                //        {"Black Pepper", 1}
                //    },
                //    5,
                //    150.00m
                //),
                
                //new Recipe(
                //    "Iberico Ham and Melon",
                //    "A refreshing pairing of sweet melon and savory Iberico ham.",
                //    new Dictionary<string, int>
                //    {
                //        {"Iberico Ham", 1},
                //        {"Melon", 1},
                //        {"Mint", 1}
                //    },
                //    5,
                //    75.00m
                //),
                
                //new Recipe(
                //    "Morel Mushroom Risotto",
                //    "An earthy and creamy risotto made with wild morel mushrooms.",
                //    new Dictionary<string, int>
                //    {
                //        {"Rice", 2},
                //        {"Morel Mushrooms", 1},
                //        {"Butter", 2},
                //        {"Parmesan", 2},
                //        {"Garlic", 1}
                //    },
                //    5,
                //    65.00m
                //),
                
                //new Recipe(
                //    "Matsutake Mushroom Soup",
                //    "A delicate Japanese-inspired soup featuring the rare Matsutake mushrooms.",
                //    new Dictionary<string, int>
                //    {
                //        {"Matsutake Mushroom", 1},
                //        {"Chicken", 2},
                //        {"Garlic", 1},
                //        {"Rosemary", 1}
                //    },
                //    5,
                //    70.00m
                //),
                
                //new Recipe(
                //    "Black Garlic Chicken",
                //    "Tender chicken cooked with sweet and savory black garlic, served with steamed vegetables.",
                //    new Dictionary<string, int>
                //    {
                //        {"Chicken", 2},
                //        {"Black Garlic", 1},
                //        {"Rosemary", 1},
                //        {"Olive Oil", 1},
                //        {"Salt", 1}
                //    },
                //    5,
                //    50.00m
                //),
                
                //new Recipe(
                //    "Sea Urchin (Uni) Sushi",
                //    "Delicate sea urchin (uni) served on a bed of sushi rice, garnished with lemon.",
                //    new Dictionary<string, int>
                //    {
                //        {"Sea Urchin (Uni)", 1},
                //        {"Rice", 1},
                //        {"Lemon", 1},
                //        {"Black Pepper", 1}
                //    },
                //    5,
                //    95.00m
                //),
                
                //new Recipe(
                //    "Beef Wellington with Truffle",
                //    "Tender beef fillet with mushrooms and truffle, wrapped in puff pastry.",
                //    new Dictionary<string, int>
                //    {
                //        {"Beef", 2},
                //        {"Truffle", 1},
                //        {"Mushrooms", 2},
                //        {"Puff Pastry", 1},
                //        {"Butter", 1},
                //        {"Salt", 1},
                //        {"Black Pepper", 1}
                //    },
                //    5,
                //    65.00m
                //),
                
                //new Recipe(
                //    "Lobster Thermidor",
                //    "Luxurious lobster dish with a rich, creamy sauce.",
                //    new Dictionary<string, int>
                //    {
                //        {"Lobster", 2},
                //        {"Butter", 2},
                //        {"Cream", 1},
                //        {"Cheese", 1},
                //        {"Garlic", 1},
                //        {"Black Pepper", 1},
                //        {"Salt", 1},
                //        {"Parsley", 1}
                //    },
                //    5,
                //    45.00m
                //),
                
                //new Recipe(
                //    "Gold Leaf Chocolate Truffles",
                //    "Exquisite chocolate confections with edible gold.",
                //    new Dictionary<string, int>
                //    {
                //        {"Chocolate", 2},
                //        {"Cream", 1},
                //        {"Butter", 1},
                //        {"Gold Leaf", 1},
                //        {"Vanilla Extract", 1}
                //    },
                //    5,
                //    55.00m
                //),
                
                //new Recipe(
                //    "Saffron Risotto with Seafood",
                //    "Golden Italian rice dish with premium seafood.",
                //    new Dictionary<string, int>
                //    {
                //        {"Rice", 2},
                //        {"Saffron", 1},
                //        {"Shrimp", 2},
                //        {"Fish", 1},
                //        {"Butter", 1},
                //        {"Onion", 1},
                //        {"Garlic", 1},
                //        {"Parmesan", 1},
                //        {"Salt", 1}
                //    },
                //    5,
                //    38.00m
                //)

                new Recipe(
                    "Wagyu Beef Steak",
                    "A premium Wagyu beef steak cooked to perfection, seasoned with herbs.",
                    new Dictionary<string, int>
                    {
                        {"Wagyu Beef", 2},
                        {"Butter", 1},
                        {"Rosemary", 1},
                        {"Black Pepper", 1}
                    },
                    5,
                    140.00m
                ),

                new Recipe(
                    "Bluefin Tuna Sashimi Plate",
                    "Fresh slices of Bluefin Tuna served with a light lemon garnish and herbs.",
                    new Dictionary<string, int>
                    {
                        {"Bluefin Tuna", 2},
                        {"Lemon", 1},
                        {"Parsley", 1}
                    },
                    5,
                    130.00m
                )
            };
            
            return recipes;
        }

        public static List<Recipe> GetStarterRecipes()
        {
            List<Recipe> allRecipes = GetAllRecipes();
            List<Recipe> starterRecipes = new List<Recipe>();

            // Add only the most basic recipes for the starter set
            starterRecipes.Add(allRecipes.Find(r => r.Name == "Scrambled Eggs"));
            //starterRecipes.Add(allRecipes.Find(r => r.Name == "Garden Salad"));
            //starterRecipes.Add(allRecipes.Find(r => r.Name == "Toast with Butter"));
            //starterRecipes.Add(allRecipes.Find(r => r.Name == "Boiled Eggs"));
            starterRecipes.Add(allRecipes.Find(r => r.Name == "Fruit Salad"));
            starterRecipes.Add(allRecipes.Find(r => r.Name == "Grilled Cheese Sandwich"));
            //starterRecipes.Add(allRecipes.Find(r => r.Name == "Vegetable Soup"));
            //starterRecipes.Add(allRecipes.Find(r => r.Name == "Egg Salad"));
            //starterRecipes.Add(allRecipes.Find(r => r.Name == "Lemonade"));
            //starterRecipes.Add(allRecipes.Find(r => r.Name == "Garlic Bread"));
            //starterRecipes.Add(allRecipes.Find(r => r.Name == "Bacon and Eggs Breakfast"));
            //starterRecipes.Add(allRecipes.Find(r => r.Name == "Avocado Toast"));
            //starterRecipes.Add(allRecipes.Find(r => r.Name == "Peanut Butter and Banana Sandwich")); 

            return starterRecipes;
        }
    }
}
