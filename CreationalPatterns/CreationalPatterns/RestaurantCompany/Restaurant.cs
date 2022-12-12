using CreationalPatterns.Kitchen;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.RestaurantCompany
{
    public static class Restaurant
    {
        public static List<Order> Orders { get; set; } = new();
        public static Supplies Supplies { get; set; }
        private static List<Dish> Menu { get; set; }
        public static List<IRestaurantProduct> Meals { get; set; } = new();
        private static List<Dish> _dishes;
        public static List<Dish> Dishes { get { return _dishes; } set { _dishes = value; Supplies = Supplies.GetSupplies(); } }
        static Restaurant()
        {
            GetOrders();
        }
        public static void GetOrders()
        {
            using StreamReader u = new(@"C:\Users\ilie.todirascu\OneDrive - Amdaris\Desktop\Uni\TMPS\CreationalPatterns\CreationalPatterns\menu.json");
            string foods = u.ReadToEnd();
            Menu = JsonConvert.DeserializeObject<List<Dish>>(foods);
            Console.Write("Please select the number of orders you want to make: ");
            var nrOfOrders = Convert.ToInt32(Console.ReadLine());
            var menu = "The menu:\n";
            Menu.ForEach(x => menu += $"Dish:{x.Name} Id:{x.Id}\n");
            Console.WriteLine(menu);
            for (int i = 0; i < nrOfOrders; i++)
            {
                Console.WriteLine($"Choose the dish ids for Order nr:{i + 1}");
                var items = Console.ReadLine();
                var dishes = new List<Dish>();
                var sweetDishes = new List<Dish>();
                var spicyDishes = new List<Dish>();
                items.ToList().ForEach(x =>
                {
                    bool isExtraSweet, isExtraSpicy;
                    isExtraSpicy = isExtraSweet = false;
                    if (x - '0' == 2)
                    {
                        Console.WriteLine("Excuse me, Sir, would you like that extra sweet?");
                        isExtraSweet = Console.ReadLine().ToLower().Equals("yes");
                    }
                    if (isExtraSweet)
                    {
                        sweetDishes.Add(Menu.First(y => y.Id == x - '0'));
                    };
                    if (x - '0' == 1)
                    {
                        Console.WriteLine("Excuse me, Sir, would you like that extra spicy?");
                        isExtraSpicy = Console.ReadLine().ToLower().Equals("yes");
                    };
                    if (isExtraSpicy)
                    {
                        spicyDishes.Add(Menu.First(y => y.Id == x - '0'));
                    }
                    if(!isExtraSpicy && !isExtraSweet) dishes.Add(Menu.First(y => y.Id == x - '0'));

                });
                Dishes = new();
                Dishes.AddRange(dishes);
                Dishes.AddRange(spicyDishes);
                Dishes.AddRange(sweetDishes);
                Orders.Add(new Order("Ilie", Dishes));
                Supplies.OrderIngredients();
                FactoryProducer factoryProducer = new();
                sweetDishes.ForEach(x =>
                {
                    var factory = factoryProducer.GetFactory(true);
                    Meals.Add(factory.GetMeal("Extra Sweet " + x.Name));
                });
                dishes.ForEach(x =>
                {
                    var factory = factoryProducer.GetFactory(false);
                    Meals.Add(factory.GetMeal(x.Name));
                });
                spicyDishes.ForEach(x =>
                {
                    var factory = factoryProducer.GetFactory(false);
                    Meals.Add(factory.GetMeal("Spicy " + x.Name));
                });
                Orders = new();
                //var isOkPizza = false;
                //if (dishes.Any(x => x.Id == 1))
                //{
                //    Console.WriteLine("Was the pizza .
                //    satisfactory, Sir?");
                //    isOkPizza = Console.ReadLine().ToLower().Equals("yes");
                //}
                //if (!isOkPizza)
                //{
                //    var ingredientToExclude = Console.ReadLine();
                //    var badPizza = Meals.Where(x => x.Name == "Pizza").FirstOrDefault();
                //    return (Meal)badPizza.
                //    //var pizza = Menu.First(y => y.Id == 1);
                //    //pizza.Components = pizza.Components.Where(x => !x.Name.Equals(ingredientToExclude)).ToList();
                //    //Orders.Add(new Order("Ilie", new List<Dish>() { pizza}));
                //    //Supplies.OrderIngredients();
                //    //var factory = factoryProducer.GetFactory(false);
                //}
            }
        }
        
    }
}
