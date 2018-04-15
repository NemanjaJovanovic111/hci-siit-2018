using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

using System.Windows;

namespace HCI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            ConsoleManager.Show();

            // Periodicno izvrsavati dovllacenje BERZE
            var timer1 = new System.Threading.Timer(_ => Console.WriteLine("Hello World"), null, 0, 2000);

        }
    }
}
