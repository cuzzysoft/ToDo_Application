using ToDoApp.Services.Interface;
using ToDoApp.Services.Repository;

namespace ToDoApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            IServiceClass service_interface = new ServiceClass();
            ApplicationConfiguration.Initialize();
            Application.Run(new ToDoApp(service_interface));
        }
    }
}