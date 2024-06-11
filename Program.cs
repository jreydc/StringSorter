using StringSorter.Scripts;

namespace StringSorter
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            SortModel sortModel = new SortModel();
            frmMain sortView = new frmMain();
            SortController sortController = new SortController(sortModel, sortView);

            Application.Run(sortView);
        }
    }
}