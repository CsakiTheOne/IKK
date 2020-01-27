using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKK_notif
{
    [Serializable]
    public class Error
    {
        public string Sender { get; private set; } = "";
        public string Message { get; private set; } = "";
        public int Line { get; set; } = -1;

        public Error() { }
        public Error(string sender, string message)
        {
            Sender = sender;
            Message = message;
        }
    }
}
