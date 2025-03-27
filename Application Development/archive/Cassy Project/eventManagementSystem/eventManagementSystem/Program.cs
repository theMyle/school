using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eventManagementSystem
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

            Form3 login_form = new Form3();
            DialogResult result = login_form.ShowDialog();

            // Check if login successfull
            if (result == DialogResult.OK)
            {
                Application.Run(new Form1());
            }
        }
    }
}
