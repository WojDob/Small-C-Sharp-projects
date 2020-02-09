using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Histogram
{
    public partial class MainForm : Form
    {
        public static List<Record> records = new List<Record>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void chooseFileButton_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
            }
            textBox1.Text = filePath;

            foreach (var line in File.ReadLines(filePath))
            {
                var tempLine = line.Split(';');
                Record temp = new Record(tempLine[0],tempLine[1],tempLine[2],tempLine[3]);
                records.Add(temp);
            }

        }

        private void showTableButton_Click(object sender, EventArgs e)
        {
            TableForm tableForm = new TableForm(records);
            tableForm.Show();
        }

        private void makeBarChartButton_Click(object sender, EventArgs e)
        {
            ChartForm chartForm = new ChartForm(records);
            chartForm.Show();
        }
    }
}
