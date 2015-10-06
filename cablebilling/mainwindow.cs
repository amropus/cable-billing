using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace cablebilling
{
    public partial class mainwindow : Form
    {
        public mainwindow()
        {
            InitializeComponent();
            Thread t = new Thread(new ThreadStart(splashstart));
            t.Start();
            Thread.Sleep(1000);
            t.Abort();
        }

        public void splashstart()
        {
            Application.Run(new begsplash2());

        }
    }
}
