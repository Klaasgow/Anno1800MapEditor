using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using WPFLocalizeExtension.Engine;
using WPFLocalizeExtension.Providers;

namespace AnnoMapEditor
{
    public partial class App : Application
    {
        public readonly static string TitleShort = "Community Map Editor";
        public readonly static string Title = $"{TitleShort} for Anno 1800";

        public App() {
            ResxLocalizationProvider provider = ResxLocalizationProvider.Instance;

            provider.SearchCultures = new List<CultureInfo>()
            {
                CultureInfo.GetCultureInfo("en"),
                CultureInfo.GetCultureInfo("de"),
            };
            LocalizeDictionary.Instance.Culture = CultureInfo.GetCultureInfo("en");

            //int i = 0;
        }
    }
}
