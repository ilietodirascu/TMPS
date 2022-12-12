using CreationalPatterns.RestaurantCompany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Kitchen
{
    public class FruitSalad : IRestaurantProduct
    {
        public string Name { get; set; } = "Fruit Salad";
        public List<Ingredient> Ingredients = new()
        {
            new Ingredient("Pineapple", "Spain"),
            new Ingredient("Apple", "Italy"),
            new Ingredient("Whipped Cream", "Canada"),
            new Ingredient("Banana", "Spain"),
        };
    }
}
