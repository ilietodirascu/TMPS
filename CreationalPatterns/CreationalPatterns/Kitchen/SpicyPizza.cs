using CreationalPatterns.RestaurantCompany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Kitchen
{
    public class SpicyPizza : IRestaurantProduct
    {
        public string Name { get; set; } = "Spicy Pizza";
        public List<Ingredient> Ingredients = new()
        {
            new Ingredient("Dough", "Canada"),
            new Ingredient("Tomato Sauce", "Italy"),
            new Ingredient("Chorizo", "Spain"),
            new Ingredient("Cheese", "Italy"),
        };
    }
}
