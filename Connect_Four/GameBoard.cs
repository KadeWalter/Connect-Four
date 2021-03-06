﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Diagnostics;
using System.Timers;
using System.Runtime.InteropServices;

namespace Connect_Four
{
    public partial class GameBoard : Form
    {
        public static int ROWS;
        public static int COLS;
        int HEIGHT, WIDTH;
        string AIOne, AITwo;
        int humans = -1;
        int player_one, player_two; // if player == 1, its human.. if player == 2, its AI
        int winner = -1;      // if winner = 1, red won.. if winner = 2, yellow won.. if winner = 0, it was a draw
        bool winnerFound = false;
        private Rectangle[] columns;
        private int[,] board;
        private int turn;     // 1 is red, 2 is yellow
        private int turnCounter = 0;
        private bool InProgress = false;
        int timeLeft;
        int timePerMove;
        Log consoleLog = new Log();

        // Gameboard constructor. Takes in the number of humans, AI difficulties, the amount of rows and the amount of columns needed to play the game.
        // Initializes the components of the game, then assigns any values passed in to the corresponding private variables
        public GameBoard(int playerOne, int playerTwo, string AIOne_choice, string AITwo_choice, int rows, int cols, int timer)
        {
            InitializeComponent();
            HEIGHT = this.Height;
            WIDTH = this.Width;
            ROWS = rows;
            COLS = cols;
            this.columns = new Rectangle[cols];
            this.board = new int[rows, cols];
            AIOne = AIOne_choice;
            AITwo = AITwo_choice;
            timePerMove = timer;
            player_one = playerOne;
            player_two = playerTwo;
            //red starts
            this.turn = 1;
            
        }

        // makes the connect 4 game board picture on screen (the start picture)
        private void GameBoard_Paint(object sender, PaintEventArgs e)
        {
            int drawWidth = 0, drawHeight = 0;
            if (ROWS == 3)
            {
                drawWidth = 340;
                drawHeight = 240;
            }
            else if (ROWS == 6)
            {
                drawWidth = 575;
                drawHeight = 425;
            }
            else if (ROWS == 9)
            {
                drawWidth = 815;
                drawHeight = 615;
            }
            e.Graphics.FillRectangle(Brushes.DodgerBlue, 100, 70, drawWidth, drawHeight);
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLS; j++)
                {
                    if (i == 0)
                    {
                        this.columns[j] = new Rectangle(118 + 78 * j, 100, 70, drawHeight);
                    }
                    e.Graphics.FillEllipse(Brushes.LightGray, 118 + 78 * j, 88 + 65 * i, 60, 60);
                }
            }
        }

        // starts the game. 
        private void startGame_click(object sender, EventArgs e)
        {
            // the comments above the ifs indicate what kind of game structure is being played
            // note the first player listed is the one who goes first
            // ie: human v comp, human goes first
            this.InProgress = true;
            // comp v comp game
            if (player_one == 2 && player_two == 2)
            {
                humans = 0;
                timeLeft = timePerMove;
                timer1.Start();
                compVcomp();
            }
            // comp v human game
            else if (player_one == 2)
            {
                timeLeft = timePerMove;
                timer1.Start();
                AITurn(AIOne);
            }
            // human v comp game
            else if (player_one == 1 && player_two == 2)
            {
                timeLeft = timePerMove;
                timer1.Start();
            }
            // human v human game
            else
            {
                timeLeft = timePerMove;
                timer1.Start();
            }
        }

        // user chooses location to place the piece
        // this function signifies a round or a turn
        //      If it is Human v Comp, then the user is first, and when they click the piece is placed. Then the AI goes and places its piece before the method is called again.
        //      However, if it is Human v Human, then this signifies a turn
        private void GameBoard_MouseClick(object sender, MouseEventArgs e)
        {
            if (humans == 0 || InProgress == false)
            {
                return;
            }

            int column = this.verifyColumn(e.Location);
            // verifies click was in board before trying to find the free row
            if (column != -1)
            {
                int row = findRow(column);
                // verifies that the row was in the board space
                if (row != -1)
                {
                    // human plays
                    if (winner == -1)
                    {
                        HumanTurn(row, column);
                    }
                    if (winner == -1)
                    {
                        // if its not human v human, its the AI's turn
                        if (AIOne != "")
                        {
                            AITurn(AIOne);
                        }
                        else if (AITwo != "")
                        {
                            AITurn(AITwo);
                        }
                    }
                }
            }
        }

        // a round for AI v AI play
        private void compVcomp()
        {
            while (winner == -1)
            {
                // AI NUmber 1 turn if there isnt a winner
                AITurn(AIOne);
                // AI Number 2 turn if there isnt a winner
                if (winner == -1)
                {
                    AITurn(AITwo);
                }
            }
        }

        // Human makes their turn
        private void HumanTurn(int row, int column)
        {

            // places the piece on the board array
            this.board[row, column] = this.turn;
            // write it to the log file
            addToLog(row, column);
            // paints the color
            fillColor(this.turn, row, column);
            timer1.Stop();
            timer1.Dispose();

            // did the player win?
            winner = this.gameOver(this.turn);
            if (winner != -1)
            {
                winnerFound = winnerMsg();
            }
            // update the active player
            turnCounter++;
            changeTurn();
            // draw check
            if (winner == -1)
                winnerFound = drawCheck(turnCounter);
            // if the game is over, return to the main menu
            if (winnerFound == true)
                backToMainMenu();
            timeLeft = timePerMove;
            timer1.Start();
        }

        // AI makes its move
        private void AITurn(string AIfile)
        {

            // Print the current game board
            StreamWriter outFile = new StreamWriter("board.txt", false);
            outFile.WriteLine(turn);
            outFile.WriteLine(ROWS);
            outFile.WriteLine(COLS);
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLS; j++)
                {
                    outFile.WriteLine(board[i, j]);
                }
            }
            outFile.Close();

            // Call the AI program and have it execute
            // All programs must have a gameComm.cs file
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = AIfile;
            startInfo.Arguments = "gameComm.cs";
            var p = Process.Start(startInfo);
            p.WaitForExit();            

            // get the move from the file produced by AI Program
            StreamReader inFile = new StreamReader("move.txt");
            string rowString = inFile.ReadLine();
            string colString = inFile.ReadLine();
            inFile.Close();

            int aiRow = Convert.ToInt32(rowString);
            int aiCol = Convert.ToInt32(colString);

            // place the move
            this.board[aiRow, aiCol] = this.turn;
            // add to the log file
            addToLog(aiRow, aiCol);
            // paints the color
            fillColor(this.turn, aiRow, aiCol);

            timer1.Dispose();
            timer1.Stop();

            // did the AI win?
            winner = this.gameOver(this.turn);
            if (winner != -1)
                winnerFound = winnerMsg();
            // update the turn
            turnCounter++;
            changeTurn();
            // draw check, game over, no places to play
            if (winner == -1)
                winnerFound = drawCheck(turnCounter);
            // once the game is over, go back to the main menu
            if (winnerFound == true)
                backToMainMenu();
            timeLeft = timePerMove;
            timer1.Start();

        }

        // checks for a winner of the game
        private bool winnerMsg()
        {
            if (winner != -1)
            {
                timer1.Stop();
                timer1.Dispose();
                string winnerColor = (winner == 1) ? "Red" : "Yellow";
                MessageBox.Show("Game over! " + winnerColor + " has won the game.");
                return true;
            }
            return false;
        }

        // Checks for a tie game
        private bool drawCheck(int turnCounter)
        {
            if (turnCounter >= (ROWS * COLS))
            {
                winner = 0;
                MessageBox.Show("Game over! Game is a draw.");
                return true;
            }
            return false;
        }

        // verifies that the column clicked is in the board space and able to take a piece
        private int verifyColumn(Point mouse)
        {
            // insures that the click was in the board space
            for (int i = 0; i < this.columns.Length; i++)
            {
                if ((mouse.X >= this.columns[i].X) && (mouse.Y >= this.columns[i].Y))
                {
                    if ((mouse.X <= this.columns[i].X + this.columns[i].Width) && (mouse.Y <= this.columns[i].Y + this.columns[i].Height))
                    {
                        // return the column number
                        return i;
                    }
                }
            }
            // user clicked outside of the board
            return -1;
        }

        // finds the correct row to place a piece on in the column that the user selects
        private int findRow(int col)
        {
            // starts at the bottom and checks up to find the first free space
            for (int i = ROWS - 1; i >= 0; i--)
            {
                if (this.board[i, col] == 0)
                    return i;
            }
            return -1;
        }

        // fills the color in the space
        private void fillColor(int player, int i, int j)
        {
            if (player == 1)
            {
                Graphics g = this.CreateGraphics();
                g.FillEllipse(Brushes.Red, 118 + 78 * j, 88 + 65 * i, 60, 60);
            }
            else if (player == 2)
            {
                Graphics g = this.CreateGraphics();
                g.FillEllipse(Brushes.Gold, 118 + 78 * j, 88 + 65 * i, 60, 60);
            }
        }

        // changes the turns
        private void changeTurn()
        {
            if (turn == 1)
                turn = 2;
            else
                turn = 1;
        }

        // is there a winner? returns the winning player
        private int gameOver(int player)
        {
            // check horizontal
            for (int i = 0; i < this.board.GetLength(0); i++)
            {
                for (int j = 0; j < this.board.GetLength(1) - 3; j++)
                {
                    // checks for a winner down the cols, if so it returns the player as the winner
                    if (this.checkNums(player, this.board[i, j], this.board[i, j + 1], this.board[i, j + 2], this.board[i, j + 3]))
                        return player;
                }
            }

            // check vertical 
            for (int i = 0; i < this.board.GetLength(0) - 3; i++)
            {
                for (int j = 0; j < this.board.GetLength(1); j++)
                {
                    // checks for a winner down the rows, if so it returns the player as the winner
                    if (this.checkNums(player, this.board[i, j], this.board[i + 1, j], this.board[i + 2, j], this.board[i + 3, j]))
                        return player;
                }
            }

            // check diagonal -> top left to bot right win
            for (int i = 0; i < this.board.GetLength(0) - 3; i++)
            {
                for (int j = 0; j < this.board.GetLength(1) - 3; j++)
                {
                    // checks for a winner down the cols, if so it returns the player as the winner
                    if (this.checkNums(player, this.board[i, j], this.board[i + 1, j + 1], this.board[i + 2, j + 2], this.board[i + 3, j + 3]))
                        return player;
                }
            }

            // check diagonal -> top right to bot left win
            for (int i = 0; i < this.board.GetLength(0) - 3; i++)
            {
                for (int j = 3; j < this.board.GetLength(1); j++)
                {
                    // checks for a winner down the cols, if so it returns the player as the winner
                    if (this.checkNums(player, this.board[i, j], this.board[i + 1, j - 1], this.board[i + 2, j - 2], this.board[i + 3, j - 3]))
                        return player;
                }
            }

            return -1;

        }

        // checks the pieces on the board
        private bool checkNums(int player, params int[] nums)
        {
            foreach (int n in nums)
            {
                if (n != player)
                    return false;
            }
            return true;
        }

        // writes the last turn to the console
        private void lastTurn(int col, int player)
        {
            string playerColor = (this.turn == 1) ? "Red" : "Yellow";
            string lastTurn = "Move for " + playerColor + ": Column " + col;
            Console.Write(lastTurn);
        }

        // adds a move to the log file
        private void addToLog(int row, int col)
        {
            string color;
            string moveMade;
            if (turn == 1)
                color = "red";
            else
                color = "yellow";
            moveMade = "Player " + color + " move: Column = " + col + ", Row = " + row + "\n";
            consoleLog.addMove(moveMade);
        }

        private void deleteLog()
        {
            consoleLog.clearLog();
        }

        // timer inforamation
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                // tick the time down 1
                timeLeft = timeLeft - 1;
            }
            else
            {
                string winner;
                // if time ran out, tell them
                timer1.Stop();
                //if the timer ran out, the color not playing right now wins
                if (turn == 1)
                    winner = "yellow";
                else
                    winner = "red";
                MessageBox.Show("Time up! Took too long, " + winner + " player wins.");
                new MainMenu().Show();
                this.Hide();
            }
        }

        // after the game is over, return to the main menu
        private void backToMainMenu()
        {
            timer1.Stop();
            timer1.Dispose();
            // delete logFile
            deleteLog();
            new MainMenu().Show();
            this.Hide();
        }
        
        // shows a log of the past moves
        private void showLogBtn_Click(object sender, EventArgs e)
        {
            consoleLog.Show();
        }

        private void GameBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            timer1.Dispose();
        }

        // closes the game form permanently 
        private void GameBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
                timer1.Stop();
                timer1.Dispose();
                // delete logFile
                deleteLog();
                Application.Exit();
        }

        private void GameBoard_Load(object sender, EventArgs e)
        {

        }

        // returns the user to the main menu
        private void toMainMenu_click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Dispose();
            // delete logFile
            deleteLog();
            new MainMenu().Show();
            this.Hide();
        }

    }
}
