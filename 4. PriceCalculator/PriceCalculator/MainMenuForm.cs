using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriceCalculator
{
    public partial class MainMenuForm : Form
    {
        
        public static int monitorPrice;
        public static int computerPrice;

        public MainMenuForm()
        {
            InitializeComponent();
            timer1.Interval = 10;
            timer1.Start();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void chooseComputerButton_Click(object sender, EventArgs e)
        {
            ChooseComputerForm chooseComputerForm = new ChooseComputerForm();
            chooseComputerForm.Show();
        }

        private void chooseMonitorButton_Click(object sender, EventArgs e)
        {
            ChooseMonitorForm chooseMonitorForm = new ChooseMonitorForm();
            chooseMonitorForm.Show();
        }

        private void editProcessorsButton_Click(object sender, EventArgs e)
        {
            EditProcessorsForm editProcessorsForm = new EditProcessorsForm();
            editProcessorsForm.Show();
        }

        private void editMonitorsButton_Click(object sender, EventArgs e)
        {
            EditMonitorsForm editMonitorsForm = new EditMonitorsForm();
            editMonitorsForm.Show();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            totalPriceTextBoxMain.Text = (computerPrice + monitorPrice).ToString()+"$";
            if((computerPrice == 0 && monitorPrice !=0) || (computerPrice!=0 && monitorPrice==0))
            {
                totalPriceTextBoxMain.BackColor = Color.Yellow;
            }
            if(computerPrice!= 0 && monitorPrice !=0)
            {
                totalPriceTextBoxMain.BackColor = Color.LimeGreen;
            }
        }
    }
}
