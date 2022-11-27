using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns
{
    public class InitializeNotifiersSubsystem
    {
        public void InitializeNotifiers(List<Network> networks)
        {
            var notifiers = new List<Notifier>();
            var user1Notifier = InitializeNotifierForSpecificUser(1, Console.ReadLine(), networks);
            var user2Notifier = InitializeNotifierForSpecificUser(2, Console.ReadLine(), networks);
            var user3Notifier = InitializeNotifierForSpecificUser(3, Console.ReadLine(), networks);
            networks.ForEach(x => x.Users.ForEach(y =>
            {
                switch (y.Id)
                {
                    case 1:
                        y.Notifier = user1Notifier;
                        break;
                    case 2:
                        y.Notifier = user2Notifier;
                        break;
                    case 3:
                        y.Notifier = user3Notifier;
                        break;
                }
            }));
        }
        public GenericNotifier InitializeNotifierForSpecificUser(int id,string type, List<Network> networks)
        {
            var facebook = networks.Where(x => x.Name.Equals("Facebook")).FirstOrDefault();
            var slack = networks.Where(x => x.Name.Equals("Slack")).FirstOrDefault();
            var telegram = networks.Where(x => x.Name.Equals("Telegram")).FirstOrDefault();
            return type switch
            {
                "facebook" => new Notifier(facebook.Users.Where(x => x.Id == id).FirstOrDefault()),
                "slackFacebook" => new SlackDecorator(new Notifier(facebook.Users.Where(x => x.Id == id).FirstOrDefault()), slack),
                "all" => new TelegramDecorator(new SlackDecorator(new Notifier(facebook.Users.Where(x => x.Id == id).FirstOrDefault()), slack), telegram),
                _ => null,
            };
        }
    }
}
