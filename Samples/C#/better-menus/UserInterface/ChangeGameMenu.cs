using System.Runtime.InteropServices;

namespace CivOne.UserInterface
{
    public class ChangeGameMenu : MenuModification
    {
        private string OSName
        {
            get
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) return "Windows";
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux)) return "Linux";
                if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX)) return "macOS";
                return "DOS";
            }
        }

        public override (string MenuText, string ShortcutText) ChangeMenuItemText(string menuText, string shortcutText)
        {
            if (menuText == "QUIT to DOS")
            {
                return ($"QUIT to {OSName}", null);
            }
            return base.ChangeMenuItemText(menuText, shortcutText);
        }

        public ChangeGameMenu() : base("MenuBarGame")
        {
        }
    }
}