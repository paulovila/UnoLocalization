using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Collections;

namespace localization
{
    public class LocalizationController : ILocalizationController
    {
        protected static ResourceManager _resourceManager;

        static LocalizationController()
        {
            _resourceManager = new ResourceManager("kahua.localization.Resources.Strings", typeof(localization.Resources.Strings).Assembly);
        }

        public LocalizationController()
        {

        }

        public string Get(string resource, CultureInfo cultureInfo)
        {
            return _resourceManager.GetString(resource, cultureInfo);
        }

        public string Get(string resourceKey, string cultureCode)
        {
            var culture = new CultureInfo(cultureCode);
            return _resourceManager.GetString(resourceKey, culture);
        }
    }
}
