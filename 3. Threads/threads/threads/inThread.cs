using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace threads
{
    class InThread
    {
        string message;
        int minutes;

        public InThread(string message, int minutes)
        {
            this.message = message;
            this.minutes = minutes;
        }
        public void run()
        {
            Thread.Sleep(minutes * 1000 * 60);
            MessageBox.Show(message);
        }
    }
}
