using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Demo1
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("fr-CA"); ;
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("fr-CA");
            CultureInfo.DefaultThreadCurrentCulture.DateTimeFormat.AbbreviatedMonthNames = new string[] {"asd", "jAn", "fEv", "Mar", "Avr", "Mai", "Jui", "Jul", "Aou", "Sep", "Oct", "Nov", "Dec" };
            CultureInfo.DefaultThreadCurrentUICulture.DateTimeFormat.AbbreviatedMonthNames = new string[] { "asd", "jAn", "fEv", "Mar", "Avr", "Mai", "Jui", "Jul", "Aou", "Sep", "Oct", "Nov", "Dec" };
        }
    }
}
