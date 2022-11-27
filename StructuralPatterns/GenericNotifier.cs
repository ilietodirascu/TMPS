using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns
{
    public abstract class GenericNotifier
    {
        public User User { get; set; }
        public abstract void Send(string message);
    }
}
