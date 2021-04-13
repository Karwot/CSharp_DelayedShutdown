using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelayedShutdown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            secondsHolder.KeyPress += new KeyPressEventHandler(numeric_KeyPress);
            minutesHolder.KeyPress += new KeyPressEventHandler(numeric_KeyPress);
            hoursHolder.KeyPress += new KeyPressEventHandler(numeric_KeyPress);
        }
        private void numeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private int sumOfSecondsToSd()
        {
            int seconds = 0;
            int minutes = 0;
            int hours = 0;
            if(!string.IsNullOrWhiteSpace(secondsHolder.Text))
            {
                seconds = Int32.Parse(secondsHolder.Text);
            }
            if (!string.IsNullOrWhiteSpace(minutesHolder.Text))
            {
                minutes = Int32.Parse(minutesHolder.Text) * 60;
            }
            if (!string.IsNullOrWhiteSpace(hoursHolder.Text))
            {
                hours = Int32.Parse(hoursHolder.Text) * 3600;
            }
            return seconds + minutes + hours;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string time_argument = "-s -t " + sumOfSecondsToSd().ToString();
            System.Diagnostics.Process.Start("Shutdown", time_argument);
            MessageBox.Show("Computer will shut down in :"+sumOfSecondsToSd()+"seconds");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Shutdown", " -a");
            MessageBox.Show("Shutdown cancelled");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
