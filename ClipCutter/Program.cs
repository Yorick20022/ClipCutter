using SQLite;
using ClipCutter.models;

namespace ClipCutter
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SQLiteConnection db = new("./clipcutter.db");
            db.CreateTable<models.Config>();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}