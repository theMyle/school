using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagementSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Start the login form
            Form1 login_form = new Form1();
            DialogResult result = login_form.ShowDialog();

            // Check if login successfull
            if (result == DialogResult.OK)
            {
                Application.Run(new EventManager());
            }

            //Application.Run(new EventManager());
        }
    }
}
