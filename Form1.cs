using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            
            //Timer updates info with current time.
            //lblHour = 24 hour time

            lblHour.Text = DateTime.Now.ToString("HH:mm");
            lblSecond.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("MMM dd yyyy");
            lblDay.Text = DateTime.Now.ToString("dddd");

            //changes lblSecond location
            lblSecond.Location = new Point (lblHour.Location.X + lblHour.Width - 5, lblSecond.Location.Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Timer Starts

            timer.Start();
        }
    }
}
