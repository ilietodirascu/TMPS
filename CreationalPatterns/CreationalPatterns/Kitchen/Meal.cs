using CreationalPatterns.RestaurantCompany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Kitchen
{
    public class Meal : IRestaurantProduct 
    {
        public List<Ingredient> CookedIngredients = new();

        public string Name { get; set; }

        public void AddCookedIngredient(Ingredient ingredient)
        {
            CookedIngredients.Add(ingredient);
        }

        public string ShowIngredients()
        {
            return string.Join(" ", CookedIngredients.Select(x => x.Name));
        }
        public Meal ShallowCopy()
        {
            return (Meal)MemberwiseClone();
        }

        public Meal DeepCopy(string ingredientName)
        {
            Meal clone = (Meal)MemberwiseClone();
            clone.CookedIngredients = clone.CookedIngredients.Where(x => !x.Name.Equals(ingredientName)).ToList();
            return clone;
        }
    }
}
