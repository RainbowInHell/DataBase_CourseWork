using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class LoadScreen : Form
    {
        public LoadScreen()
        {
            InitializeComponent();
            closeTimer.Interval = 5000;
            closeTimer.Tick += new EventHandler(closeTimer_Tick);
            closeTimer.Start();
        }

        private void closeTimer_Tick(object sender, EventArgs e)
        {
            closeTimer.Stop();
            this.Hide();
            //Login l = new Login();
            //l.Show();
        }
    }
}
