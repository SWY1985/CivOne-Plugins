namespace CivOne.UserInterface
{
    public abstract class BaseChangeMenuFunctionKeys : MenuModification
    {
        public override (string MenuText, string ShortcutText) ChangeMenuItemText(string menuText, string shortcutText)
        {
            if (menuText.Contains("(") && menuText.EndsWith(")"))
            {
                string newMenuText = menuText.Substring(0, menuText.LastIndexOf('(')).Trim();
                string newShortcut = menuText.Substring(menuText.LastIndexOf('(') + 1).TrimEnd(' ', ')');
                return (newMenuText, newShortcut);
            }
            return base.ChangeMenuItemText(menuText, shortcutText);
        }

        protected BaseChangeMenuFunctionKeys(string menuId) : base(menuId)
        {
        }
    }
}