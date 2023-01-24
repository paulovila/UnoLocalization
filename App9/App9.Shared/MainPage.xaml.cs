using System.Globalization;
using System.Resources;

namespace App9
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        public string S1
        {
            get
            {
                var lc = new LocalizationController();
                return lc.Get("Label_EmailAddress", new CultureInfo("ja"));
            }
        }
    }
    public class LocalizationController
    {
        public static ResourceManager _resourceManager;
        static LocalizationController()
        {
            _resourceManager = new ResourceManager("localization.Resources.Strings", typeof(localization.Resources.Strings).Assembly);
        }
        public LocalizationController()
        { }
        public string Get(string resource, CultureInfo cultureInfo)
        {
            var d = _resourceManager.BaseName;
            return _resourceManager.GetString(resource, cultureInfo);
        }
        public string Get(string resourceKey, string cultureCode)
        {
            var culture = new CultureInfo(cultureCode);
            return _resourceManager.GetString(resourceKey, culture);
        }
    }
}