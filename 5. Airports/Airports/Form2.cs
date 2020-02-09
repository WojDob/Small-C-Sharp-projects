using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airports
{
    public partial class Form2 : Form
    {
        public Form2(string name,bool miej,bool woj, bool iata, bool dlug, bool ns,bool ew)
        {
            InitializeComponent();

            foreach(var port in Form1.airports)
            {
                if(port.Nazwa.Equals(name))
                {
                    textBox1.Text = port.Nazwa + " ";

                    if (miej && port.Miejscowosc!="-")
                        textBox1.Text = textBox1.Text + port.Miejscowosc + " ";
                    if (woj && port.Wojewodztwo != "-")
                        textBox1.Text = textBox1.Text + port.Wojewodztwo + " ";
                    if (iata && port.Iata != "-")
                        textBox1.Text = textBox1.Text + port.Iata + " ";
                    if (dlug && port.Dlugosc != "-")
                        textBox1.Text = textBox1.Text + port.Dlugosc + " ";
                    if (ns && port.Ns != "-")
                        textBox1.Text = textBox1.Text + port.Ns + " ";
                    if (ew && port.Ew != "-")
                        textBox1.Text = textBox1.Text + port.Ew + " ";

                }
            }
        }

        private void X_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
