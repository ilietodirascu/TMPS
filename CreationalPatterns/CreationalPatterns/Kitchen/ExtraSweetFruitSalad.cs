using CreationalPatterns.RestaurantCompany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Kitchen
{
    public class ExtraSweetFruitSalad : IRestaurantProduct
    {
        public string Name { get; set; } = "Extra Sweet Fruit Salad";
        public List<Ingredient> Ingredients = new()
        {
            new Ingredient("Pineapple", "Spain"),
            new Ingredient("Apple", "Italy"),
            new Ingredient("Whipped Cream", "Canada"),
            new Ingredient("Banana", "Spain"),
        };
        public ExtraSweetFruitSalad()
        {

            Ingredients.ForEach(x =>
            {
                var supplies = Supplies.GetSupplies();
                var ingredientFromSupplies = supplies.Ingredients.First(y => y.Name.Equals(x.Name) && y.CountryOfOrigin.Equals(x.CountryOfOrigin));
                supplies.Ingredients.Remove(ingredientFromSupplies);
            });
            Console.WriteLine($"Here you go! Your {Name}");
            Ingredients.Add(new Ingredient("Honey", "Moldova"));
            Console.WriteLine($"The cooked ingredients are: {string.Join(" ", Ingredients.Select(x => x.Name))}");
        }
    }
}
