using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.RestaurantCompany
{
    public class Order
    {
        public string Client { get; set; }
        public List<Dish> Dishes { get; set; }

        public Order(string client, List<Dish> dishes)
        {
            Client = client;
            Dishes = dishes;
        }
    }
}
