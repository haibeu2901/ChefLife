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
    }
}
