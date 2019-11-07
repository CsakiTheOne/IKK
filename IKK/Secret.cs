using System.Text;
using System.Security.Cryptography;

namespace IKK
{
    public static class Secret
    {
        public static string Encrypt(string text)
        {
            byte[] data = Encoding.ASCII.GetBytes(text);
            data = new SHA256Managed().ComputeHash(data);
            string hash = Encoding.ASCII.GetString(data);
            return hash;
        }
    }
}
