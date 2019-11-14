using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKK_notif
{
    public class Notification
    {
        public string ID { get; private set; }
        public string Sender { get; private set; }
        public DateTime Time { get; private set; }
        public string Title { get; private set; }
        public string[] Description { get; private set; }
        public bool StartExtended { get; private set; }
        public bool Resizable { get; private set; }

        public event NotifHandler Click;
        public event NotifHandler Dismiss;

        public Notification(string iD, string sender, DateTime time, string title, string[] description, bool startExtended, bool resizable)
        {
            ID = iD;
            Sender = sender;
            Time = time;
            Title = title;
            Description = description;
            StartExtended = startExtended;
            Resizable = resizable;
        }
    }
}
