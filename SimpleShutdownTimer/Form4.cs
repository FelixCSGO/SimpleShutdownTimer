using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleShutdownTimer
{
    public partial class customTimer_Form : Form
    {
        public customTimer_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is where you would but the Hour.");

        }

        private void custom_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void minute_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is where you would but the Minutes.");
        }

        private void second_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is where you would put the seconds.");
        }

        private void customTimer_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
