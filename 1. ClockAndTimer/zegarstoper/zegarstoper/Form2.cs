using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zegarstoper
{
    public partial class Form2 : Form
    {
        private int m, s;
        bool isActive;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isActive)
            {
                s++;
                if (s > 59)
                {
                    m++;
                    s = 0;
                }
                label1.Text = m.ToString() + ":" + s.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isActive == false)
            {
                isActive = true;
                button1.Text = "Stop";
            }
            else
            {
                isActive = false;
                button1.Text = "Start";
            }
        }

        public Form2()
        {
            InitializeComponent();
            isActive = false;
            m = s = 0;
            timer1.Start();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
