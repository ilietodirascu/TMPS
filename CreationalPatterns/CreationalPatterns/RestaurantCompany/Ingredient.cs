using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.RestaurantCompany
{
    public class Ingredient
    {
        public string Name { get; set; }
        public string CountryOfOrigin { get; set; }
        public Ingredient(string name, string country)
        {
            Name = name;
            CountryOfOrigin = country;
        }
    }
}
