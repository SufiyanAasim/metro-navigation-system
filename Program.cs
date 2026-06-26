using System;
using System.Windows.Forms;

namespace Metro_App
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Welcome());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Startup Crash", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.IO.File.WriteAllText("crash_log.txt", ex.ToString());
            }
        }
    }
}
