using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace threads
{
    public partial class Form1 : Form
    {
        string message;
        int minutes;

        public Form1()
        {
            InitializeComponent();
            button1.BackColor = Color.Green;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            message = messageTextBox.Text;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                minutes = Convert.ToInt32(minutesTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Prosze liczby do okienka minut");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            InThread intThread = new InThread(message,minutes);
            Thread thread = new Thread(new ThreadStart(intThread.run));
            thread.Start();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            
            button1.BackColor = Color.Red;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Green;
        }
    }
}
