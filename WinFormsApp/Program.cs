using WinFormsApp.Views;

namespace WinFormsApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new StartForm());
        }
    }
}