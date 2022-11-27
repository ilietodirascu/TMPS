using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns
{
    public class Statistics
    {
        public List<Network> Networks { get; set; }

        public Statistics(List<Network> networks)
        {
            Networks = networks;
        }

        public string GetStatInfo()
        {
            var result = "Networks:\n";
            Networks.ForEach(x =>
            {
                result += x.Name + "\n\tUsers:\n";
                x.Users.ForEach(u =>
                {
                    result += $"\t{u.FullName}'s Messages:\n";
                    u.Messages.ForEach(m =>
                    {
                        result += "\t\t\t\t" + m + "\n";
                    });
                });
            });
            return result;
        }
    }
}
