using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns
{
    public class Facade
    {
        public IStatistics Statistics { get; set; }
        public InitializeNotifiersSubsystem InitializeNotifiersSystem { get; set; }
        public UserCreationSubsystem UserCreationSystem { get; set; }

        public Facade(InitializeNotifiersSubsystem initializeNotifiersSystem, UserCreationSubsystem userCreationSystem)
        {
            InitializeNotifiersSystem = initializeNotifiersSystem;
            UserCreationSystem = userCreationSystem;
        }
        public void LaunchProtocol()
        {
            var facebookUsers = UserCreationSystem.InitializeUsers();
            var telegramUsers = UserCreationSystem.InitializeUsers();
            var slackUsers = UserCreationSystem.InitializeUsers();
            var networks = new List<Network>();
            networks.Add(new Network("Facebook", facebookUsers));
            networks.Add(new Network("Telegram", telegramUsers));
            networks.Add(new Network("Slack", slackUsers));
            InitializeNotifiersSystem.InitializeNotifiers(networks);
            networks.ForEach(x => x.Users.ForEach(y => y.Notifier.Send("hello")));
            var statistics = new Statistics(networks);
            var statisticsAdapter = new StatsAdapter(statistics);
            statisticsAdapter.PrintInfo();
        }
    }
}
