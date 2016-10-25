using System.Windows;
using System.Windows.Threading;
using Scripter;

namespace ScripterUI
{
    public partial class App
    {
        App()
        {
            DispatcherUnhandledException += onUnhandledException;
        }

        private void onUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            e.Handled = true;
            Shutdown();
        }

        private void startup(object sender, StartupEventArgs args)
        {
            ApplicationModel.ShowMainWindow();
        }
    }
}
