using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns
{
    public abstract class Decorator : GenericNotifier
    {
        protected GenericNotifier _notifier;
        public Decorator(GenericNotifier notifier)
        {
            _notifier = notifier;
        }
        public override void Send(string message)
        {
            if (_notifier != null)
            {
                _notifier.Send(message);
            }
        }
    }
}
