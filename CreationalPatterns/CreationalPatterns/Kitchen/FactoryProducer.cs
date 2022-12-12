using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Kitchen
{
    public class FactoryProducer
    {
        public  AbstractFactory GetFactory(bool sweet)
        {
            if (sweet)
            {
                return new ExtraSweetMealFactory();
            }
            return new MealFactory();
        }
    }
}
