
// To customize application configuration such as set high DPI settings or default font,
// see https://aka.ms/applicationconfiguration.
namespace AlberSoft
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Esto evita que Windows haga un escalado automático y permite que WinForms gestione DPI por monitor
            Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ApplicationConfiguration.Initialize();
            Application.Run(new fmRegistro());
        }
    }
}