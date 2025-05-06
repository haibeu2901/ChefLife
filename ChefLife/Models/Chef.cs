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
        
    }
}
