using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKK_data
{
    [Serializable]
    class ToolLineCounter : Tool
    {
        public override string Name => "Sor számláló";
        public override string[] Description => new string[] { "Figyel, hogy hány sorosak a versszakjaid.", "Írj be egy számot! Hány soros egy versszak?" };
        public override string Category => "categoryLyre";

        public override void OnChange(string content)
        {
            int count;
            if (!int.TryParse(Settings, out count))
            {
                IKK_notif.NotifManager.Send(new IKK_notif.Notification("Sor számláló", "Sor számláló rosszul van beállítva", Settings));
                return;
            }
            string[] lines = content.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            string errors = "";
            for (int i = 0; i < lines.Length; i++)
            {
                if ((i + 1) % (count + 1) == 0)
                {
                    if (lines[i].Length > 0) errors += $"{i+1}. sor nem üres. ";
                }
                else
                {
                    if (lines[i].Length < 1) errors += $"{i + 1}. sor üres. ";
                }
            }

            if (errors.Length > 0) IKK_notif.NotifManager.Send(new IKK_notif.Notification("Sor számláló", "Nem jó sor számok", errors));
            else IKK_notif.NotifManager.Dismiss("Sor számláló");
        }
    }
}
