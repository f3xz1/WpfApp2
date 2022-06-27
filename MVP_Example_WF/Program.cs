using Examen;
namespace MVP_Example_WF
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
            Application.Run(new Form1());
            var view = new Form1();
            var model = new FakeGradeModel();
            var presenter = new GradePresenter(model, view);
        }
    }
}