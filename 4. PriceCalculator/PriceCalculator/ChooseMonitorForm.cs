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
    public partial class ChooseMonitorForm : Form
    {
        List<Monitor> monitors = new List<Monitor>();
        private int monitorPrice;
        public ChooseMonitorForm()
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

            foreach (Monitor obj in monitors)
            {
                ListViewItem item = new ListViewItem();
                item.Text = (obj.Brand + 
                    " " + obj.Diameter.ToString() + 
                    "\" " + obj.Price.ToString() +"$"); 
                item.Tag = obj;

                listView1.Items.Add(item);
                
            }
        }


        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            Monitor obj = (Monitor)e.Item.Tag;
            totalPriceTextBox.Text= obj.Price.ToString()+"$";
            monitorPrice = obj.Price;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            MainMenuForm.monitorPrice = monitorPrice;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
