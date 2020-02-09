using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace Histogram
{
    public partial class ChartForm : Form
    {
        public ChartForm(List<Record> records)
        {
            InitializeComponent();

            foreach (Record record in records)
            {
                chart1.Series["Quantity"].Points.AddXY(record.Name, record.Quantity);
            }
        }
    }
}
