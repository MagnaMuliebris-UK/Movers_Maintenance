namespace Movers_Maintenance_Subsystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Ideally this would read in differently based on prior selections, but due to a lack of ability to select a user within this subsystem, this suffices. When added into the full system - base this off of the last thing the user selected.
            OverarchingSettings.QueryActionIsEnabled = true;
            OverarchingSettings.ReportActionIsEnabled = true;
            OverarchingSettings.HelpButtonsIsEnabled = true;


            ApplicationConfiguration.Initialize();
            Application.Run(new Main_Menu());
        }

        public static string ConnectionStringEstablish()
        {
            string DebugPath = Path.GetDirectoryName(Environment.CurrentDirectory);
            string dataDirectoryPath = Path.GetDirectoryName(DebugPath);
            AppDomain.CurrentDomain.SetData("DataDirectory", dataDirectoryPath);
            return dataDirectoryPath;
        }
    }
}