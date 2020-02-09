using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Linq;
namespace PriceCalculator
{
    public partial class EditMonitorsForm : Form
    {
        private List<Monitor> monitors = new List<Monitor>();

        public EditMonitorsForm()
        {
            InitializeComponent();

            XDocument xml = XDocument.Load("Monitors.xml");

            monitors = (
                from monitor in xml.Root.Elements("monitor")
                select new Monitor(
                    Convert.ToInt32(monitor.Element("price").Value),
                    Convert.ToInt32(monitor.Element("diameter").Value),
                    monitor.Element("brand").Value
                    )
                ).ToList<Monitor>();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            bool formNotFilled = false;
            if (brandTextBox.Text.Equals(""))
            {
                brandTextBox.BackColor = Color.Red;
                formNotFilled = true;
            }
            if (priceTextBox.Text.Equals(""))
            {
                priceTextBox.BackColor = Color.Red;
                formNotFilled = true;
            }
            if(diameterTextBox.Text.Equals(""))
            {
                diameterTextBox.BackColor = Color.Red;
            }
            if (formNotFilled)
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            int tempPrice = 0;
            try
            {
                tempPrice = System.Convert.ToInt32(priceTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Only add numbers to the price field");
                priceTextBox.BackColor = Color.Red;
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("OverflowException");
                return;
            }

            int tempDiameter = 0;
            try
            {
                tempDiameter = System.Convert.ToInt32(diameterTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Only add numbers to the diameter field");
                diameterTextBox.BackColor = Color.Red;
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("OverflowException");
                return;
            }
            if (System.Convert.ToInt32(diameterTextBox.Text) <= 0)
            {
                MessageBox.Show("Add a valid diameter");
                diameterTextBox.BackColor = Color.Red;
                return;
            }
            if (System.Convert.ToInt32(priceTextBox.Text) <= 0)
            {
                MessageBox.Show("Add a valid price");
                priceTextBox.BackColor = Color.Red;
                return;
            }
            Monitor tempMonitor = new Monitor(tempPrice, tempDiameter, brandTextBox.Text);
            monitors.Add(tempMonitor);

            save(monitors);
            MessageBox.Show("Added monitor");
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {
            priceTextBox.BackColor = Color.White;
        }

        private void diameterTextBox_TextChanged(object sender, EventArgs e)
        {
            diameterTextBox.BackColor = Color.White;
        }

        private void brandTextBox_TextChanged(object sender, EventArgs e)
        {
            brandTextBox.BackColor = Color.White;
        }
        private void save(List<Monitor> monitors)
        {
            XDocument xml = new XDocument(
            new XDeclaration("1.0", "utf-8", "yes"),
            new XElement("monitors",
                from monitor in monitors
                select new XElement("monitor",
                    new XElement("price", monitor.Price),
                    new XElement("diameter", monitor.Diameter),
                    new XElement("brand", monitor.Brand)
                    )
                )
            );
            xml.Save("Monitors.xml");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int tempPrice = 0;
            try
            {
                tempPrice = System.Convert.ToInt32(priceTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Only add numbers to the price field");
                priceTextBox.BackColor = Color.Red;
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("OverflowException");
                return;
            }

            int tempDiameter = 0;
            try
            {
                tempDiameter = System.Convert.ToInt32(diameterTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Only add numbers to the diameter field");
                diameterTextBox.BackColor = Color.Red;
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("OverflowException");
                return;
            }


            foreach (Monitor mon in monitors)
            {
                if (mon.Price.Equals(tempPrice) && mon.Brand.Equals(brandTextBox.Text) && mon.Diameter.Equals(tempDiameter))
                {
                    monitors.Remove(mon);
                    MessageBox.Show("Removed monitor");
                    break;
                }
            }
            save(monitors);
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
