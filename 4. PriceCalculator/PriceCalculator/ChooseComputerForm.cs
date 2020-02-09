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
    public partial class ChooseComputerForm : Form
    {
        private int drivePrice;
        private int processorPrice;
        private List<Processor> processors = new List<Processor>();
        
        public ChooseComputerForm()
        {
            InitializeComponent();
            drivePrice = 200;
            drivePriceTextBox.Text = "200$";
            totalTextBox.Text = (drivePrice + processorPrice).ToString()+"$";

            XDocument xml = XDocument.Load("Processors.xml");

            processors = (
                from processor in xml.Root.Elements("processor")
                select new Processor(
                    Convert.ToInt32(processor.Element("price").Value),
                    processor.Element("brand").Value
                    )
                ).ToList<Processor>();
            processorsComboBox.DataSource = processors;
            processorsComboBox.DisplayMember = "Brand";
        }



        private void ChooseComputerForm_Load(object sender, EventArgs e)
        {

        }

        private void ssd240_CheckedChanged(object sender, EventArgs e)
        {
            drivePrice = 200;
            drivePriceTextBox.Text = drivePrice.ToString() + "$";
            totalTextBox.Text = (drivePrice + processorPrice).ToString() + "$";
        }

        private void sata500_CheckedChanged(object sender, EventArgs e)
        {
            drivePrice = 400;
            drivePriceTextBox.Text = drivePrice.ToString() + "$";
            totalTextBox.Text = (drivePrice + processorPrice).ToString() + "$";
        }

        private void sata1000_CheckedChanged(object sender, EventArgs e)
        {
            drivePrice = 600;
            drivePriceTextBox.Text = drivePrice.ToString() + "$";
            totalTextBox.Text = (drivePrice + processorPrice).ToString() + "$";
        }

        private void processorsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Processor processor = processorsComboBox.SelectedItem as Processor;
            processorPriceTextBox.Text = processor.Price.ToString() + "$";
            processorPrice = processor.Price;
            totalTextBox.Text = (drivePrice + processorPrice).ToString() + "$";
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            MainMenuForm.computerPrice = drivePrice + processorPrice;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
