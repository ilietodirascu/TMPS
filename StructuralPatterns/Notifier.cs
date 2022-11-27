using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns
{
    public class Notifier : GenericNotifier
    {
        public Notifier(User user)
        {
            User = user;
        }
        public void Update()
        {

        }
        public override void Send(string message)
        {
            User.Messages.Add(message);
        }
    }
}
