using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Kitchen
{
    public class MealFactory : AbstractFactory
    {
        public override Meal GetMeal(string mealName)
        {
            var mealBuilder = new MealBuilder();
            return mealName switch
            {
                "Zeama" => mealBuilder.PrepareZeama(),
                "Pizza" => mealBuilder.PrepareRegularPizza(),
                "Spicy Pizza" => mealBuilder.PrepareSpicyPizza(),
                "Fruit Salad" => mealBuilder.PrepareFruitSalad(),
                _ => null
            };
        }
    }
}
