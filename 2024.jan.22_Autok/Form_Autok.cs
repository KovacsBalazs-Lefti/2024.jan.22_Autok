using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024.jan._22_Autok
{
    public partial class Form_Autok : Form
    {
        public Form_Autok()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_GyartasiEv_ValueChanged(object sender, EventArgs e)
        {
            int selectedYear = dateTimePicker_GyartasiEv.Value.Year;
            MessageBox.Show($"Selected Year: {selectedYear}");
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
