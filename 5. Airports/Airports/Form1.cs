using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Airports
{
    public partial class Form1 : Form
    {
        public static List<Airport> airports = new List<Airport>();
        public Form1()
        {
            InitializeComponent();

            foreach (var line in File.ReadLines("lotniska.txt"))
            {
                Airport temp = new Airport();
                var tempLine = line.Split(';');
                temp.Nazwa = tempLine[0];
                temp.Miejscowosc = tempLine[1];
                temp.Wojewodztwo = tempLine[2];
                temp.Iata = tempLine[3];
                temp.Dlugosc = tempLine[4];
                temp.Ns = tempLine[5];
                temp.Ew = tempLine[6];
                airports.Add(temp);
            }

            foreach (Airport port in airports)
            {
                ListViewItem item = new ListViewItem();
                item.Text = port.Nazwa;
                listView1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
                Form2 form2 = new Form2(listView1.SelectedItems[0].Text, miejBox.Checked, wojBox.Checked, iataBox.Checked, dlugBox.Checked, nsBox.Checked, ewBox.Checked);
                form2.Show();
            }
            catch
            {
                MessageBox.Show("Prosze wybrac lotnisko!");
            }
        }


    }
}
