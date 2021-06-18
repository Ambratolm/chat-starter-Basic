using System;
using System.Windows.Forms;

namespace ChatStarterBasic
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Run two instances (For test only)
            //Form_Main form = new Form_Main();
            //form.WindowState = FormWindowState.Maximized;
            //form.Show();
            //new Form_Main().Show();

            Application.Run(new Form_Main());
        }
    }
}
