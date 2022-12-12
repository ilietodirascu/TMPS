using CreationalPatterns.RestaurantCompany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Kitchen
{
    public class MealBuilder
    {
        public Supplies Supplies = Supplies.GetSupplies();
        public Meal PrepareSpicyPizza()
        {
            Meal meal = new();
            new SpicyPizza().Ingredients.ForEach(x => 
            {
                var ingredientFromSupplies = Supplies.Ingredients.First(y => y.Name.Equals(x.Name) && y.CountryOfOrigin.Equals(x.CountryOfOrigin));
                Supplies.Ingredients.Remove(ingredientFromSupplies);
                meal.AddCookedIngredient(ingredientFromSupplies);
            });
            meal.AddCookedIngredient(new Ingredient("Spicy Sauce", "Moldova"));
            Console.WriteLine($"Here you go! Your {new SpicyPizza().Name}");
            Console.WriteLine($"The cooked ingredients are: {meal.ShowIngredients()}");
            return meal;
        }
        public Meal PrepareRegularPizza()
        {
            Meal meal = new();
            new Pizza().Ingredients.ForEach(x =>
            {
                var ingredientFromSupplies = Supplies.Ingredients.First(y => y.Name.Equals(x.Name) && y.CountryOfOrigin.Equals(x.CountryOfOrigin));
                Supplies.Ingredients.Remove(ingredientFromSupplies);
                meal.AddCookedIngredient(ingredientFromSupplies);
            });
            Console.WriteLine($"Here you go! Your {new Pizza().Name}");
            Console.WriteLine($"The cooked ingredients are: {meal.ShowIngredients()}");
            return meal;
        }
        public Meal PrepareZeama()
        {
            Meal meal = new();
            new Zeama().Ingredients.ForEach(x =>
            {
                var ingredientFromSupplies = Supplies.Ingredients.First(y => y.Name.Equals(x.Name) && y.CountryOfOrigin.Equals(x.CountryOfOrigin));
                Supplies.Ingredients.Remove(ingredientFromSupplies);
                meal.AddCookedIngredient(ingredientFromSupplies);
            });
            Console.WriteLine($"Here you go! Your {new Zeama().Name}");
            Console.WriteLine($"The cooked ingredients are: {meal.ShowIngredients()}");
            return meal;
        }
        public Meal PrepareFruitSalad()
        {
            Meal meal = new();
            new FruitSalad().Ingredients.ForEach(x =>
            {
                var ingredientFromSupplies = Supplies.Ingredients.First(y => y.Name.Equals(x.Name) && y.CountryOfOrigin.Equals(x.CountryOfOrigin));
                Supplies.Ingredients.Remove(ingredientFromSupplies);
                meal.AddCookedIngredient(ingredientFromSupplies);
            });
            Console.WriteLine($"Here you go! Your {new FruitSalad().Name}");
            Console.WriteLine($"The cooked ingredients are: {meal.ShowIngredients()}");
            return meal;
        }
        
    }
}
