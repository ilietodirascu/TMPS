using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns
{
    public class SlackDecorator : Decorator
    {
        public Network Slack { get; set; }
        public SlackDecorator(GenericNotifier notifier, Network slack) : base(notifier)
        {
            User = _notifier.User;
            Slack = slack;
        }
        public override void Send(string message)
        {
            var slackUser = Slack.Users.Where(x => x.Id == User.Id).FirstOrDefault();
            slackUser.Messages.Add(message);
            base.Send(message);
        }
    }
}
