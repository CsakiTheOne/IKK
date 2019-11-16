using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKK_notif
{
    public delegate void NotifHandler(Notification sender);

    public static class NotifManager
    {
        public static List<Notification> Notifications { get; private set; } = new List<Notification>();

        public static event NotifHandler Notified;
        public static event NotifHandler Dismissed;

        public static void Send(Notification notification)
        {
            if (Notifications.Count(r => r.Title == notification.Title) > 0) Dismiss(notification.Title);

            Notifications.Add(notification);
            Notified(notification);
        }

        public static bool Dismiss(Notification notification)
        {
            try
            {
                Notifications.Remove(notification);
                Dismissed(notification);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Dismiss(string senderOrTitle)
        {
            try
            {
                Notification temp = Notifications.First(r => r.Sender == senderOrTitle || r.Title == senderOrTitle);
                Notifications.Remove(temp);
                Dismissed(temp);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void Clear()
        {
            int count = Notifications.Count;
            for (int i = 0; i < count; i++)
            {
                Dismiss(Notifications[0]);
            }
        }
    }
}
