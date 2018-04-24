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
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
        }

        // adds a move to the rich textbox
        public void addMove(string moveString)
        {
            logTextBox.AppendText(moveString);
        }

        public void clearLog()
        {
            logTextBox.Clear();
        }

        private void Log_Load(object sender, EventArgs e)
        {

        }

        private void logTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Log_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }
    }
}
