using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKK_notif
{
    public class Notification
    {
        public string Time { get; private set; }
        public string Sender { get; private set; }
        public string Title { get; private set; }
        public string Desc { get; private set; }
        public bool StartExtended { get; private set; }
        public bool Resizable { get; private set; }
        public NotifAction[] Actions { get; private set; }

        public Notification(string sender, string title = null, string desc = "", NotifAction[] actions = null, bool startExtended = false)
        {
            Time = DateTime.Now.TimeOfDay.ToString().Split('.')[0];
            Sender = sender;
            Title = title != null ? title : sender;
            Desc = desc;
            Actions = actions;
            StartExtended = startExtended;
            Resizable = actions != null;
        }
    }

    public class NotifAction
    {
        public string Name { get; private set; }
        public NotifHandler Action { get; private set; }

        public NotifAction(string name, NotifHandler action)
        {
            Name = name;
            Action = action;
        }
    }
}
