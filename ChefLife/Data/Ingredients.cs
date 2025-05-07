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
                new Ingredient("Banana", "Soft, sweet fruit", 1.00m),
                new Ingredient("Orange", "Citrus fruit rich in vitamin C", 1.10m),
                new Ingredient("Grapes", "Small sweet or sour fruit", 2.25m),
                new Ingredient("Peach", "Juicy stone fruit", 1.50m),
                new Ingredient("Plum", "Small stone fruit with tart flavor", 1.45m),
                new Ingredient("Mango", "Tropical sweet fruit", 2.00m),
                new Ingredient("Pineapple", "Tropical spiky fruit", 2.50m),
                new Ingredient("Strawberry", "Sweet red fruit", 2.75m),
                new Ingredient("Blueberry", "Tiny purple-blue fruit", 3.00m),
                new Ingredient("Kiwi", "Fuzzy fruit with green inside", 1.35m),
                new Ingredient("Pomegranate", "Juicy seeds inside", 2.80m),
                new Ingredient("Melon", "Large, sweet fruit", 2.60m),

                // Proteins
                new Ingredient("Chicken", "Versatile poultry meat", 5.00m),
                new Ingredient("Beef", "Red meat from cattle", 7.50m),
                new Ingredient("Pork", "Meat from pigs", 6.00m),
                new Ingredient("Fish", "Fresh seafood", 8.00m),
                new Ingredient("Tofu", "Soy-based protein", 3.00m),
                new Ingredient("Shrimp", "Small shellfish, quick to cook", 9.00m),
                new Ingredient("Turkey", "Lean white poultry", 5.75m),
                new Ingredient("Lamb", "Tender red meat", 8.50m),
                new Ingredient("Duck", "Rich and fatty bird meat", 7.25m),
                new Ingredient("Crab", "Shellfish with sweet meat", 10.00m),
                new Ingredient("Salmon", "Popular fatty fish", 9.50m),
                new Ingredient("Tuna", "Lean and flavorful fish", 8.25m),
                new Ingredient("Tempeh", "Fermented soy product", 3.50m),
                new Ingredient("Eggs", "Protein-rich, versatile", 2.00m),
                new Ingredient("Sausage", "Ground meat in casing", 4.75m),

                // Dairy
                new Ingredient("Milk", "Dairy liquid", 2.25m),
                new Ingredient("Cheese", "Fermented dairy product", 4.50m),
                new Ingredient("Cream", "High-fat dairy product", 3.75m),
                new Ingredient("Yogurt", "Fermented milk product", 2.50m),
                new Ingredient("Butter", "Used in cooking and baking", 3.50m),
                new Ingredient("Sour Cream", "Tangy dairy topping", 2.60m),
                new Ingredient("Cottage Cheese", "Lumpy dairy cheese", 2.80m),
                new Ingredient("Whipped Cream", "Light and fluffy topping", 2.90m),
                new Ingredient("Goat Cheese", "Cheese from goat milk", 4.25m),
                new Ingredient("Mozzarella", "Soft Italian cheese", 3.75m),
                new Ingredient("Parmesan", "Hard aged cheese", 5.00m),
                new Ingredient("Blue Cheese", "Sharp, veined cheese", 4.75m),
                new Ingredient("Ricotta", "Soft cheese used in baking", 3.25m),
                new Ingredient("Milk Powder", "Dehydrated milk", 2.40m),
                new Ingredient("Ghee", "Clarified butter", 3.95m),

                // Grains & Pasta
                new Ingredient("Rice", "Versatile grain", 2.00m),
                new Ingredient("Pasta", "Wheat-based noodles", 2.25m),
                new Ingredient("Bread", "Baked dough staple", 2.75m),
                new Ingredient("Quinoa", "Protein-rich grain", 3.00m),
                new Ingredient("Oats", "Used in breakfast and baking", 1.90m),
                new Ingredient("Barley", "Grain used in soups and stews", 2.10m),
                new Ingredient("Cornmeal", "Ground dried corn", 1.85m),
                new Ingredient("Couscous", "Small steamed balls of wheat", 2.35m),
                new Ingredient("Rye Bread", "Bread made from rye flour", 2.95m),
                new Ingredient("Whole Wheat Pasta", "Healthier pasta option", 2.60m),
                new Ingredient("Tortilla", "Thin flatbread", 2.20m),
                new Ingredient("Bagel", "Round, chewy bread", 2.80m),
                new Ingredient("Soba Noodles", "Buckwheat Japanese noodles", 3.10m),
                new Ingredient("Rice Noodles", "Asian-style noodles", 2.40m),
                new Ingredient("Bulgur", "Cracked wheat grain", 2.00m),

                // Herbs & Spices
                new Ingredient("Basil", "Aromatic herb", 1.50m),
                new Ingredient("Oregano", "Mediterranean herb", 1.25m),
                new Ingredient("Black Pepper", "Spicy seasoning", 1.75m),
                new Ingredient("Cinnamon", "Sweet spice", 2.00m),
                new Ingredient("Parsley", "Fresh green garnish", 1.10m),
                new Ingredient("Thyme", "Earthy green herb", 1.20m),
                new Ingredient("Rosemary", "Fragrant needle-like herb", 1.35m),
                new Ingredient("Paprika", "Red spice from peppers", 1.50m),
                new Ingredient("Cumin", "Warm, earthy spice", 1.60m),
                new Ingredient("Turmeric", "Bright yellow spice", 1.70m),
                new Ingredient("Chili Flakes", "Spicy red pepper bits", 1.80m),
                new Ingredient("Dill", "Feathery herb used in pickling", 1.25m),
                new Ingredient("Mint", "Cool, fresh herb", 1.45m),
                new Ingredient("Clove", "Intensely aromatic spice", 1.90m),
                new Ingredient("Nutmeg", "Sweet and spicy seasoning", 2.10m),

                // Special ingredients
                new Ingredient("Truffle", "Rare, aromatic fungus", 25.00m, true),
                new Ingredient("Saffron", "Expensive, aromatic spice", 30.00m, true),
                new Ingredient("Wagyu Beef", "Premium Japanese beef", 50.00m, true),
                new Ingredient("Caviar", "Luxury fish eggs", 40.00m, true),
                new Ingredient("Foie Gras", "Delicacy made from duck liver", 35.00m, true),
                new Ingredient("Gold Leaf", "Edible gold flakes", 45.00m, true),
                new Ingredient("Kobe Beef", "High-grade Japanese beef", 55.00m, true),
                new Ingredient("Iberico Ham", "Cured Spanish ham", 42.00m, true),
                new Ingredient("Matsutake Mushroom", "Rare Japanese mushroom", 38.00m, true),
                new Ingredient("Black Garlic", "Fermented garlic with sweet flavor", 12.00m, true),
                new Ingredient("Bluefin Tuna", "High-quality sashimi tuna", 48.00m, true),
                new Ingredient("Vanilla Beans", "Whole aromatic vanilla pods", 20.00m, true),
                new Ingredient("Morel Mushrooms", "Wild, meaty mushrooms", 32.00m, true),
                new Ingredient("Sea Urchin (Uni)", "Delicacy from the sea", 37.00m, true),
                new Ingredient("Fiddlehead Ferns", "Seasonal wild greens", 15.00m, true),

                // Additional ingredients
                new Ingredient("Bacon", "Smoked and cured pork belly", 4.50m),
                new Ingredient("Chocolate", "Sweet treat made from cocoa", 3.25m),
                new Ingredient("Mushrooms", "Edible fungi with earthy flavor", 2.90m),
                new Ingredient("Avocado", "Creamy green fruit", 2.15m),
                new Ingredient("Coconut Milk", "Creamy liquid from coconuts", 2.75m),
                new Ingredient("Lime", "Tangy citrus fruit", 0.85m),
                new Ingredient("Peanut Butter", "Spread made from ground peanuts", 3.20m),
                new Ingredient("Maple Syrup", "Sweet syrup from maple trees", 4.95m),
                new Ingredient("Soy Sauce", "Salty fermented condiment", 2.35m),
                new Ingredient("Red Wine", "Alcoholic grape beverage", 12.00m),
                new Ingredient("Lobster", "Premium shellfish", 15.00m),
                new Ingredient("Taco Shells", "Crispy corn shells for tacos", 2.50m),
                new Ingredient("Ground Lamb", "Minced meat from lamb", 7.00m),
                new Ingredient("Puff Pastry", "Flaky, layered dough", 3.60m),
                new Ingredient("Breadcrumbs", "Dried, ground bread", 1.80m),
                new Ingredient("Water", "Clear liquid essential for cooking", 0.10m),
                new Ingredient("Olive Oil", "Premium cooking oil", 4.25m)
            };

            return ingredients;
        }
    }
}
