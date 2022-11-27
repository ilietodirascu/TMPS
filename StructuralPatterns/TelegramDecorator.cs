using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns
{
    public class TelegramDecorator : Decorator
    {
        public Network Telegram { get; set; }
        public TelegramDecorator(GenericNotifier notifier, Network telegram) : base(notifier)
        {
            User = _notifier.User;
            Telegram = telegram;
        }
        public override void Send(string message)
        {
            var telegramUser = Telegram.Users.Where(x => x.Id == User.Id).FirstOrDefault();
            telegramUser.Messages.Add(message);
            base.Send(message);
        }
    }
}
