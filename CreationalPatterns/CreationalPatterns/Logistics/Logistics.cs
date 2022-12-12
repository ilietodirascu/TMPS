using CreationalPatterns.RestaurantCompany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Logistics
{
    public static class Logistics
    {
        //factory pattern
        public static ITransport ProvideTransport(string countryOfOrigin)
        {
            return countryOfOrigin switch
            {
                "Italy" => new Truck(),
                "Canada" => new Plane(),
                "Spain" => new Boat(),
                _ => null,
            };
        }
        public static List<Ingredient> HandleOrder(List<Ingredient> ingredients)
        {
            var deliveredIngredients = new List<Ingredient>();
            var ingredientDictionary = new Dictionary<string, List<string>>();
            ingredients.ForEach(x => AddToDictionary(new KeyValuePair<string, string>(x.CountryOfOrigin,x.Name),ref ingredientDictionary));
            ingredientDictionary.Keys.ToList().ForEach(x => deliveredIngredients.AddRange(ProvideTransport(x).Deliver(ingredients.Where(y => y.CountryOfOrigin == x).ToList())));
            return deliveredIngredients;
        }
        private static void AddToDictionary(KeyValuePair<string,string> kvp,ref Dictionary<string,List<string>> dict)
        {
            if (dict.ContainsKey(kvp.Key))
            {
                dict[kvp.Key].Add(kvp.Value);
            }
            else
            {
                dict.Add(kvp.Key, new List<string>() { kvp.Value });
            }
        }
    }
}
