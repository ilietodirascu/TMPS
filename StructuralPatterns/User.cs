using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns
{
    public class User
    {
        public string FullName { get; set; }
        public int Id { get; set; }
        public List<string> Messages { get; set; }
        public GenericNotifier Notifier { get; set; }

        public User(string fullName, int id, List<string> messages)
        {
            FullName = fullName;
            Id = id;
            Messages = messages;
        }
    }
}
