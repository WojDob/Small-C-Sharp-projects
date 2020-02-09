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
    public partial class EditProcessorsForm : Form
    {
        private List<Processor> processors = new List<Processor>();
        public EditProcessorsForm()
        {
            InitializeComponent();

            XDocument xml = XDocument.Load("Processors.xml");

            processors = (
                from processor in xml.Root.Elements("processor")
                select new Processor(
                    Convert.ToInt32(processor.Element("price").Value),
                    processor.Element("brand").Value
                    )
                ).ToList<Processor>();

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

            if(formNotFilled)
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
                // the FormatException is thrown when the string text does 
                // not represent a valid integer.
                MessageBox.Show("Only add numbers to the price field");
                priceTextBox.BackColor = Color.Red;
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("OverflowException");
                return;
            }

            if (System.Convert.ToInt32(priceTextBox.Text) <= 0)
            {
                MessageBox.Show("Add a valid price");
                priceTextBox.BackColor = Color.Red;
                return;
            }

            Processor tempProcessor = new Processor(tempPrice,brandTextBox.Text);
            processors.Add(tempProcessor);

            save(processors);
            MessageBox.Show("Added processor");
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
                // the FormatException is thrown when the string text does 
                // not represent a valid integer.
                MessageBox.Show("Only add numbers to the price field");
                priceTextBox.BackColor = Color.Red;
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("OverflowException");
                return;
            }

            foreach (Processor proc in processors)
            {
                if(proc.Price.Equals(tempPrice) && proc.Brand.Equals(brandTextBox.Text))
                {
                    processors.Remove(proc);
                    MessageBox.Show("Removed processor");
                    break;
                }
            }
            save(processors);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            brandTextBox.BackColor = Color.White;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            priceTextBox.BackColor = Color.White;
        }
        private void save(List<Processor> processors)
        {
            XDocument xml = new XDocument(
            new XDeclaration("1.0", "utf-8", "yes"),
            new XElement("monitors",
                from processor in processors
                select new XElement("processor",
                    new XElement("price", processor.Price),
                    new XElement("brand", processor.Brand)
                    )
                )
            );
            xml.Save("Processors.xml");
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
