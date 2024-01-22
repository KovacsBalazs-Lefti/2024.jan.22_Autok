using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace _2024.jan._22_Autok
{
    public partial class Form_Nyito : Form
    {
        public Form_Nyito()
        {
            InitializeComponent();
        }

        private void Form_Nyito_Load(object sender, EventArgs e)
        {
            foreach (string gyarto in Program.autoklista.Select(a => a.Marka) .Distinct())
            {
                CheckBox cb = new CheckBox();
                cb.Text = gyarto;
                cb.Checked = true;
                cb.Location = new Point(10, panel_AutoGyartok.Controls.Count * 20);
                //feldolgozo esemény megadása
                cb.CheckedChanged += new EventHandler(gyarto_valtozott);
                panel_AutoGyartok.Controls.Add(cb);
            }
            updateAutokLista();
        }

        private void gyarto_valtozott(object sender, EventArgs e)
        {
            updateAutokLista();
        }

        private void updateAutokLista()
        {
            
            listBox_Autok.Items.Clear();
            //-- a kiválasztot autógyártók hozzáadása
            List<string> kivalasztottak = new List<string>();
            foreach (CheckBox item in panel_AutoGyartok.Controls)
            {
                if (item.Checked) { kivalasztottak.Add(item.Text); };

            }
            foreach (Autok item in Program.autoklista)
            {
                listBox_Autok.Items.Add(item);
            }
        }

        private void újToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Autok form_Autok = new Form_Autok("add");
            form_Autok.ShowDialog();
        }

        private void módosítToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox_Autok.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztott elem!");
                return;//nincs kiválasztott elem
            }
            Form_Autok form_Autok = new Form_Autok("edit");
            form_Autok.ShowDialog();
        }

        private void törölToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox_Autok.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztott elem!");
                return;//nincs kiválasztott elem
            }
            Form_Autok form_Autok = new Form_Autok("delete");
            form_Autok.ShowDialog();
        }
    }
}
