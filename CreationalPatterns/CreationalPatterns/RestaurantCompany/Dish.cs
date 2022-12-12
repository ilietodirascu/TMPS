using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.RestaurantCompany
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Ingredient> Components { get; set; }
    }
}
