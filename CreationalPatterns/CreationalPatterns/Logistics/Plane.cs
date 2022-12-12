using CreationalPatterns.RestaurantCompany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Logistics
{
    public class Plane : ITransport
    {
        public List<Ingredient> Deliver(List<Ingredient> ingredients)
        {
            Console.WriteLine($"Delivery of [{string.Join(", ", ingredients.Select(x => x.Name).ToArray())}] done by {GetType().Name}.");
            return ingredients;
        }
    }
}
