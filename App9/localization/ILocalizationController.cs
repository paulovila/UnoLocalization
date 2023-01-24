using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace localization
{
    public interface ILocalizationController
    {
        string Get(string resourceKey, CultureInfo cultureInfo);
        string Get(string resourceKey, string cultureCode);
    }
}
