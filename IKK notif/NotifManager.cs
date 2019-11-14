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

        public static void Notify(Notification notification)
        {
            Notifications.Add(notification);
            Notified(notification);
        }

        public static void Dismiss(Notification notification)
        {
            Notifications.Remove(notification);
            Dismissed(notification);
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
