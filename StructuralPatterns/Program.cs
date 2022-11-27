using System;

namespace StructuralPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade(new InitializeNotifiersSubsystem(), new UserCreationSubsystem());
            Client.ClientCode(facade);
        }
    }
}
