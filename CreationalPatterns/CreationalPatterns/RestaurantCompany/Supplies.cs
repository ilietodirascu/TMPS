using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.RestaurantCompany
{
    public class Supplies
    {
        //singleton
        public List<Ingredient> Ingredients { get; set; }
        private static readonly Supplies _supplies = new();
        private Supplies()
        {
            Ingredients = new();
        }
        public static Supplies GetSupplies()
        {
            return _supplies;
        }
        public void OrderIngredients()
        {
            Ingredients.AddRange(Logistics.Logistics.HandleOrder(Restaurant.Dishes.SelectMany(x => x.Components).ToList()));
        }
    }
}
