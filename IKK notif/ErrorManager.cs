using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKK_notif
{
    public static class ErrorManager
    {
        public static List<Error> Errors { get; private set; } = new List<Error>();

        public static event Action<List<Error>> ErrorsChanged;

        public static void Push(Error error)
        {
            if (Errors.Any(r => r.Message == error.Message)) return;
            Errors.Add(error);
            ErrorsChanged?.Invoke(Errors);
        }

        public static void Solve(Error error)
        {
            Errors.Remove(error);
            ErrorsChanged?.Invoke(Errors);
        }

        public static void Solve(string message)
        {
            Errors.RemoveAll(r => r.Message == message);
            ErrorsChanged?.Invoke(Errors);
        }

        public static void SolveTool(string sender)
        {
            Errors.RemoveAll(r => r.Sender == sender);
            ErrorsChanged?.Invoke(Errors);
        }
    }
}
