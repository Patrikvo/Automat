namespace Automat
{
    using System;
    using System.Windows.Forms;

    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Controller.OverviewController overviewController = new Controller.OverviewController(null);
            Application.Run(overviewController.GetView());
        }
    }
}