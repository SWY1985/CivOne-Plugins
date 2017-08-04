using System.Runtime.InteropServices;

namespace CivOne.UserInterface
{
    public class ChangeOrdersMenu : MenuModification
    {
        public override (string MenuText, string ShortcutText) ChangeMenuItemText(string menuText, string shortcutText)
        {
            if (menuText == "GoTo")
            {
                return (menuText, "g");
            }
            return base.ChangeMenuItemText(menuText, shortcutText);
        }

        public ChangeOrdersMenu() : base("MenuBarOrders")
        {
        }
    }
}