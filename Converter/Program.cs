using Manager;

namespace Converter
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


            ApplicationConfiguration.Initialize();
            Model model = new Model();
            Form1 winForm = new Form1();
            
            Presenter presenter = new Presenter(model, winForm);
            Application.Run(winForm);
        }
    }
}