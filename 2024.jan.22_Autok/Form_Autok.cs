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
        string muvelet;
        public Form_Autok(string muvelet)
        {
            InitializeComponent();
            this.muvelet = muvelet;
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

        private void Form_Autok_Load(object sender, EventArgs e)
        {
            switch (muvelet) 
            {
                case "add":
                    this.Text = "Új laptop";
                    button1_Muvelet.Text = "Rögzítés";
                    button1_Muvelet.BackColor = Color.Green;
                    button1_Muvelet.Click += new EventHandler(insertAuto);
                    break;

                case "edit":
                    this.Text = "Módosítás";
                    button1_Muvelet.Text = "Módosítás";
                    button1_Muvelet.BackColor = Color.Blue;
                    button1_Muvelet.ForeColor = Color.White;
                    button1_Muvelet.Click += new EventHandler(updateAuto);
                    adatmezokFeltoltese();
                    break;
                    

                case "delete":

                    this.Text = "Törlés";
                    button1_Muvelet.Text = "Törlés";
                    button1_Muvelet.BackColor = Color.Red;
                    button1_Muvelet.ForeColor = Color.White;
                    button1_Muvelet.Click += new EventHandler(deleteAuto);
                    adatmezokFeltoltese();
                    break;
            }
        }

        private void adatmezokFeltoltese()
        {
            Autok autok = (Autok)Program.form_Nyito.listBox_Autok.SelectedItem;
            textBox_Rendszam.Text = autok.Rendszam.ToString();
            textBox_Marka.Text = autok.Marka.ToString();
            textBox_Modell.Text = autok.Modell.ToString();
            dateTimePicker_GyartasiEv.Value = autok.Gyartasiev;
            dateTimePicker_ForgalmiErvenyesseeg.Value = autok.ForgalmiErvenyesseg;
            numericUpDown_VetelarFt.Value = (decimal)autok.Vetelar;
            numericUpDown_hengerurtartalom.Value = (decimal)autok.Hengerűrtartalom;
            numericUpDown_Tomgeg.Value = (decimal) autok.Tomeg;
            numericUpDown_Teljesitmeny.Value = (decimal)autok.Teljesitmeny;
            
                        
        }

        private void deleteAuto(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void updateAuto(object sender, EventArgs e)
        {
            Autok autok = new Autok();
            autok.Rendszam = int.Parse(textBox_Rendszam.Text);
            autok.Marka=textBox_Marka.Text;
            autok.Modell=textBox_Modell.Text;
            Program.db.updateAuto(autok);
        }

        private void insertAuto(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
