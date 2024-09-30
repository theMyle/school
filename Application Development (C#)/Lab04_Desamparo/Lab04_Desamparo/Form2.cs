using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_Desamparo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Close the form, cancel the transcation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
