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
    public partial class Settings : Form
    {
        public int GAME_SIZE = -1;
        public int TIME_LIMIT = -1;
        public int PLAYER_ONE_TYPE = -1;
        public int PLAYER_TWO_TYPE = -1;
        public string AI_ONE_PATH = "";
        public string AI_TWO_PATH = "";
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void SettingSubBtn_Click(object sender, EventArgs e)
        {
            string msg = "";
            // FOR CHOOSING PLAYERS AND AI:
            if(PLAYER_ONE_TYPE == -1)
            {
                msg += "Player 1 not selected. ";
            }
            if(PLAYER_TWO_TYPE == -1)
            {
                msg += "Player 2 not selected. ";
            }
            if(PLAYER_ONE_TYPE == 2 && AI_ONE_PATH == "")
            {
                msg += "Invalid AI path. ";
            }
            if (PLAYER_TWO_TYPE == 2 && AI_TWO_PATH == "" )
            {
                msg += "Invalid AI path. ";
            }

            // FOR GAME SIZE:
            // reads the time and converts it to an int
            string size = sizeDropDown.Text;
            if (size == "Small")
            {
                GAME_SIZE = 1;
            }
            else if(size == "Standard")
            {
                GAME_SIZE = 2;
            }
            else if(size == "Large")
            {
                GAME_SIZE = 3;
            }
            else
            {
                msg += "No size provided. ";
            }

            // FOR TIME LIMIT:
            // reads the time and converts it to an int
            string time = timeDropDown.Text;
            if (time == "No Limit")
            {
                // infinite time limit
                TIME_LIMIT = int.MaxValue;
            }
            else if(time == "")
            {
                msg += "No time limit provided. ";
            }
            else
            {
                // set the time limit to the requested time
                string[] timeSplit = time.Split(null);
                TIME_LIMIT = Convert.ToInt32(timeSplit[0]);
            }

            // returns good settings or displayes error message:
            if(msg == "")
            {
                this.Hide();
            }
            else
            {
                MessageBox.Show(msg);
            }
        }

        private void p1Human_Click(object sender, EventArgs e)
        {
            PLAYER_ONE_TYPE = 1;
            ai_one_name.Text = "Human";
        }

        private void p1Comp_Click(object sender, EventArgs e)
        {
            PLAYER_ONE_TYPE = 2;
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // returns the safe file name to be displayed on the settings menu
                ai_one_name.Text = ofd.SafeFileName;
                // sets the AI file path to the program
                AI_ONE_PATH = ofd.FileName;
            }
        }

        private void p2Human_Click(object sender, EventArgs e)
        {
            PLAYER_TWO_TYPE = 1;
            ai_two_name.Text = "Human";
        }

        private void p2Comp_Click(object sender, EventArgs e)
        {
            PLAYER_TWO_TYPE = 2;
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // returns the safe file name to be displayed on the settings menu
                ai_two_name.Text = ofd.SafeFileName;
                // sets the AI file path to the program
                AI_TWO_PATH = ofd.FileName;
            }
        }
    }
}
