using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;

namespace FolxikSpam
{
    public static class Config
    {
        private const string MenuName = "FolxikSpam";
        private static readonly Menu Menu;

        static Config()
        {
            Menu = MainMenu.AddMenu(MenuName, MenuName.ToLower());
            Menu.AddGroupLabel("ENG Version");
            Menu.AddLabel("Welcome in Addon FolxikSpam!");
            Menu.AddLabel("This Addon is in the beta version!");
            Menu.AddLabel("If you found some bug, report him in the subject on the forum EloBuddy.net!");
            Menu.AddGroupLabel("PL Version");
            Menu.AddLabel("Witaj w Addonie FolxikSpam!");
            Menu.AddLabel("Ten Addon jest w wersji beta!");
            Menu.AddLabel("Jeżeli znalazłeś jakiś bug, zgłoś go w temacie na forum EloBuddy.net");
        }
        public static void Initialize()
        {
        }
        public static class Modes
        {
            private static readonly Menu Menu;
            static Modes()
            {
                Menu = Config.Menu.AddSubMenu("Modes");
                Menu.AddSeparator();
            }
            public static void Initialize()
            {
            }
        }
    }
}
