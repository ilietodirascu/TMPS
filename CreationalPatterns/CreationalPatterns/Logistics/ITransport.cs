using CreationalPatterns.RestaurantCompany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Logistics
{
    public interface ITransport
    {
        public List<Ingredient> Deliver(List<Ingredient> ingredients);
    }
}
