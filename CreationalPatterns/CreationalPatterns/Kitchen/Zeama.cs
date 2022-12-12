using CreationalPatterns.RestaurantCompany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Kitchen
{
    public class Zeama : IRestaurantProduct
    {
        public string Name { get; set; } = "Zeama";
        public List<Ingredient> Ingredients = new()
        {
            new Ingredient("Chicken", "Italy"),
            new Ingredient("Potato", "Spain"),
            new Ingredient("Parsley", "Italy"),
            new Ingredient("Broth", "Canada")
        };
    }
}
