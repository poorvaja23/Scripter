using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Scripter.ViewModel;
using Scripter.Views;

namespace Scripter
{
    public static class ApplicationModel
    {
        private static MainWindow mainWindow;

        public static void ShowMainWindow()
        {
            var mainViewModel = new MainViewModel()
            {
                View = new MainView()
            };
            mainViewModel.Initialize();
            mainWindow = new MainWindow { Content = (UIElement)mainViewModel.View };
            mainViewModel.Load();
            mainWindow.Show();
        }
    }
}
