using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using RIS_lab5.View;
using RIS_lab5.ViewModel;

namespace RIS_lab5
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            var mw = new MainWindow()
            {
                DataContext = new MainViewModel()
            };
            mw.Show();
        }
    }
}
