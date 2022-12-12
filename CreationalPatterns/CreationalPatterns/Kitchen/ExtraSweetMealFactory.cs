using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Kitchen
{
    public class ExtraSweetMealFactory : AbstractFactory
    {
        public override IRestaurantProduct GetMeal(string mealName)
        {
            return mealName switch
            {
                "Extra Sweet Fruit Salad" => new ExtraSweetFruitSalad(),
                _ => null
            };
        }
    }
}
