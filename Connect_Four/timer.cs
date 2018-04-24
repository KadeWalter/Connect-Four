using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect_Four
{
    public partial class timer : Form
    {
        public static int SetTheTime = 0;
        public timer()
        {
            InitializeComponent();
        }

        private void size_Load(object sender, EventArgs e)
        {

        }

        private void size_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void size_Load_1(object sender, EventArgs e)
        {

        }

        private void timerSub_button_Click(object sender, EventArgs e)
        {
            // reads the time and converts it to an int
            string time = timeDropDown.Text;
            if (time == "No Limit")
            {
                // infinite time limit
                SetTheTime = int.MaxValue;
            }
            else
            {
                // set the time limit to the requested time
                string[] timeSplit = time.Split(null);
                SetTheTime = Convert.ToInt32(timeSplit[0]);
            }
            this.Hide();
        }
    }
}
