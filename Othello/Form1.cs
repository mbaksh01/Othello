using GUIImageArray;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Othello
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Player turn, used to switch between each player;
        /// </summary>
        public int CurrentPlayer { get; set; }

        int[,] cardArray = new int[8,8];

        /// <summary>
        /// Grid that gets displayed.
        /// </summary>
        GImageArray imageArray { get; set; }

        /// <summary>
        /// Column number of the most recent grid click.
        /// </summary>
        public int Column { get; set; }

        /// <summary>
        /// Row number of the most recent grid click.
        /// </summary>
        public int Row { get; set; }

        public bool GameStarted { get; set; }

        public Form1()
        {
            InitializeComponent();
            CurrentPlayer = 0;
        }

        /// <summary>
        /// Event for when the counters are clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Which_Element_Clicked(object sender, EventArgs e)
        {
            bool madeValidMove = false;
            int tempRow = imageArray.Get_Row(sender);
            int tempColumn = imageArray.Get_Col(sender);

            // North
            Column = tempColumn;
            Row = tempRow;
            if (IsValidMove(-1, 0))
            {
                Column = tempColumn;
                Row = tempRow;
                FlipCounters(-1, 0);
                madeValidMove = true;
            }

            // South
            Column = tempColumn;
            Row = tempRow;
            if (IsValidMove(1, 0))
            {
                Column = tempColumn;
                Row = tempRow;
                FlipCounters(1, 0);
                madeValidMove = true;
            }

            // West
            Column = tempColumn;
            Row = tempRow;
            if (IsValidMove(0, -1))
            {
                Column = tempColumn;
                Row = tempRow;
                FlipCounters(0, -1);
                madeValidMove = true;
            }

            // East
            Column = tempColumn;
            Row = tempRow;
            if (IsValidMove(0, 1))
            {
                Column = tempColumn;
                Row = tempRow;
                FlipCounters(0, 1);
                madeValidMove = true;
            }

            // Northeast
            Column = tempColumn;
            Row = tempRow;
            if (IsValidMove(-1, 1))
            {
                Column = tempColumn;
                Row = tempRow;
                FlipCounters(-1, 1);
                madeValidMove = true;
            }

            // Southeast
            Column = tempColumn;
            Row = tempRow;
            if (IsValidMove(1, 1))
            {
                Column = tempColumn;
                Row = tempRow;
                FlipCounters(1, 1);
                madeValidMove = true;
            }

            // Northwest
            Column = tempColumn;
            Row = tempRow;
            if (IsValidMove(-1, -1))
            {
                Column = tempColumn;
                Row = tempRow;
                FlipCounters(-1, -1);
                madeValidMove = true;
            }

            // Southwest
            Column = tempColumn;
            Row = tempRow;
            if (IsValidMove(1, -1))
            {
                Column = tempColumn;
                Row = tempRow;
                FlipCounters(1, -1);
                madeValidMove = true;
            }

            if (madeValidMove)
            {
                cardArray[tempRow, tempColumn] = CurrentPlayer;

                if (CurrentPlayer == 0)
                {
                    CurrentPlayer = 1;
                    playerTurn.Text = PlayerTwoTxt.Text + "'s turn.";
                }
                else
                {
                    CurrentPlayer = 0;
                    playerTurn.Text = PlayerOneTxt.Text + "'s turn.";
                }
            }

            imageArray.UpDateImages(cardArray);

        }

        /// <summary>
        /// Initilises the cardArray. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int Row = 0; Row < 8; Row++)
            {
                for (int Column = 0; Column < 8; Column++)
                {
                    cardArray[Row, Column] = 10;
                }
            }

            cardArray[3, 3] = 1;
            cardArray[4, 4] = 1;

            cardArray[4, 3] = 0;
            cardArray[3, 4] = 0;
        }

        /// <summary>
        /// Checks whether a move is valid.
        /// </summary>
        /// <param name="xDirection">X-Direction in which to move.</param>
        /// <param name="yDirection">Y-Direction in which to move.</param>
        private bool IsValidMove(int xDirection, int yDirection)
        {
            int x = 0;

            while (Column + yDirection >= 0 && Column + yDirection < 8 && Row + xDirection >= 0 && Row + xDirection < 8)
            {
                Row += xDirection;
                Column += yDirection;
                x += 1;

                if (cardArray[Row, Column] == 10)
                {
                    return false;
                }

                if (cardArray[Row, Column] == CurrentPlayer && x == 1)
                {
                    return false;
                }

                if (cardArray[Row, Column] == CurrentPlayer)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Changes the opponents pieces to current players pieces.
        /// </summary>
        /// <param name="xDirection">X-Direction in which to move.</param>
        /// <param name="yDirection">Y-Direction in which to move.</param>
        private void FlipCounters(int xDirection, int yDirection)
        {
            while (Column + yDirection >= 0 && Column + yDirection < 8 && Row + xDirection >= 0 && Row + xDirection < 8)
            {
                Row += xDirection;
                Column += yDirection;

                if (cardArray[Row, Column] == CurrentPlayer)
                {
                    break;
                }
                else
                {
                    cardArray[Row, Column] = CurrentPlayer;
                }
            }
        }

        /// <summary>
        /// Button to start the game and load the board.
        /// </summary>
        /// <param name="sender">The button clicked.</param>
        /// <param name="e">Event</param>
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageArray != null)
            {
                if (MessageBox.Show("Would you like to save current game?", "Save Game", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (SaveGame())
                    {
                        MessageBox.Show("Game saved successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Game failed to save.");
                    }
                }
            }

            if (string.IsNullOrEmpty(PlayerOneTxt.Text) || string.IsNullOrEmpty(PlayerTwoTxt.Text))
            {
                MessageBox.Show("Names can not be empty.");
                return;
            }

            imageArray = new GImageArray(this, cardArray, 50, 50, 200, 50, 5, "Images\\");
            imageArray.Which_Element_Clicked += new GImageArray.ImageClickedEventHandler(Which_Element_Clicked);
            playerTurn.Text = PlayerOneTxt.Text + "'s turn.";
        }

        private bool SaveGame()
        {
            return true;
        }

        private bool LoadGame()
        {
            return true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageArray != null)
            {
                if (MessageBox.Show("Do you want to save the game?", "Save Game", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    SaveGame();
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }
    }
}
