using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AutoSuspend
{
    public partial class Form1 : Form
    {
        private static int time;


        public Form1(string timeToLive)
        {
            InitializeComponent();
            time = int.Parse(timeToLive);
            labelTimer.Location = new Point((panel1.Width / 2) - (labelTimer.Width / 2), (panel1.Height / 2) - (labelTimer.Height / 2));
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTimer.Text = "Time Remaining: " + time.ToString();
            labelTimer.Location = new Point((panel1.Width / 2) - (labelTimer.Width / 2), (panel1.Height / 2) - (labelTimer.Height / 2));
            if (time == 0)
            {
                timer1.Stop();
                //MessageBox.Show("Suspend!");
                Application.SetSuspendState(PowerState.Suspend, true, true);
                Application.Exit();
            }
            time--;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Application.Exit();
        }

        private void buttonNow_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Application.SetSuspendState(PowerState.Suspend, true, true);
            Application.Exit();
        }
    }
}
