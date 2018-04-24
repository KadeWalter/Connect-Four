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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        // play game is clicked on the main menu
        private void playGame_click(object sender, EventArgs e)
        {
            // run the settings dialog
            Settings s = new Settings();
            s.ShowDialog();
            // sets variables
            string AI_ONE = "", AI_TWO = "";
            int moveTime = s.TIME_LIMIT;
            int gameSize = s.GAME_SIZE;
            int playerOne = s.PLAYER_ONE_TYPE;
            if (playerOne == 2)
            {
                AI_ONE = s.AI_ONE_PATH;
            }
            int playerTwo = s.PLAYER_TWO_TYPE;
            if (playerTwo == 2)
            {
                AI_TWO = s.AI_TWO_PATH;
            }
            int rows = getRows(gameSize);
            int cols = getCols(gameSize);
            if (gameSize != -1 && moveTime != -1 && playerOne != -1 && playerTwo != -1)
            {
                //create the gameboard
                GameBoard game = new GameBoard(playerOne, playerTwo, AI_ONE, AI_TWO, rows, cols, moveTime);
                if (gameSize == 1)
                    game.Size = new Size(600, 450);
                else if (gameSize == 3)
                    game.Size = new Size(1200, 900);
                game.Show();
                this.Hide();
            }
        }

        // gives an amount of rows based on the board size
        private int getRows(int gameSize)
        {
            if (gameSize == 1)
                return 3;
            else if (gameSize == 2)
                return 6;
            else
                return 9;
        }

        // gives an amount of cols based on the board size
        private int getCols(int gameSize)
        {
            if (gameSize == 1)
                return 4;
            else if (gameSize == 2)
                return 7;
            else
                return 10;
        }
        
        // exits the game
        private void Exit_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
