using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns
{
    public class UserCreationSubsystem
    {
        public List<User> InitializeUsers()
        {
            return new List<User>()
            {
                {new User("Ilie Todirascu",1, new List<string>()) },
                {new User("Rachel McAdams",2, new List<string>()) },
                {new User("Patrick Bateman",3, new List<string>()) }
            };
        }
    }
}
