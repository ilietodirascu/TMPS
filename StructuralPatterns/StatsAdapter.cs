using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns
{
    public class StatsAdapter : IStatistics
    {
        private readonly Statistics _statistics;

        public StatsAdapter(Statistics statistics)
        {
            _statistics = statistics;
        }

        public void PrintInfo()
        {
            Console.WriteLine(_statistics.GetStatInfo());
        }
    }
}
