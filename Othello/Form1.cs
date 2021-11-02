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
        /// White Square
        /// 0
        /// </summary>
        public string Player1Name { get; set; }

        /// <summary>
        /// Balck Square
        /// 1
        /// </summary>
        public string Player2Name { get; set; }

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

        public Form1()
        {
            InitializeComponent();
            CurrentPlayer = 0;
            playerTurn.Text = Player1Name + "'s turn.";
        }

        /// <summary>
        /// Event for when the counters are clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Which_Element_Clicked(object sender, EventArgs e)
        {
            // North
            Column = imageArray.Get_Col(sender);
            Row = imageArray.Get_Row(sender);
            if (IsValidMove(-1, 0))
            {
                Column = imageArray.Get_Col(sender);
                Row = imageArray.Get_Row(sender);
                FlipCounters(-1, 0);
                if (CurrentPlayer == 0)
                {
                    CurrentPlayer = 1;
                }
                else
                {
                    CurrentPlayer = 0;
                }
            }

            // South
            Column = imageArray.Get_Col(sender);
            Row = imageArray.Get_Row(sender);
            if (IsValidMove(1, 0))
            {
                Column = imageArray.Get_Col(sender);
                Row = imageArray.Get_Row(sender);
                FlipCounters(1, 0);
                if (CurrentPlayer == 0)
                {
                    CurrentPlayer = 1;
                }
                else
                {
                    CurrentPlayer = 0;
                }
            }

            // West
            Column = imageArray.Get_Col(sender);
            Row = imageArray.Get_Row(sender);
            if (IsValidMove(0, -1))
            {
                Column = imageArray.Get_Col(sender);
                Row = imageArray.Get_Row(sender);
                FlipCounters(0, -1);
                if (CurrentPlayer == 0)
                {
                    CurrentPlayer = 1;
                }
                else
                {
                    CurrentPlayer = 0;
                }
            }

            // East
            Column = imageArray.Get_Col(sender);
            Row = imageArray.Get_Row(sender);
            if (IsValidMove(0, 1))
            {
                Column = imageArray.Get_Col(sender);
                Row = imageArray.Get_Row(sender);
                FlipCounters(0, 1);
                if (CurrentPlayer == 0)
                {
                    CurrentPlayer = 1;
                }
                else
                {
                    CurrentPlayer = 0;
                }
            }

            // Northeast
            Column = imageArray.Get_Col(sender);
            Row = imageArray.Get_Row(sender);
            if (IsValidMove(-1, 1))
            {
                Column = imageArray.Get_Col(sender);
                Row = imageArray.Get_Row(sender);
                FlipCounters(-1, 1);
                if (CurrentPlayer == 0)
                {
                    CurrentPlayer = 1;
                }
                else
                {
                    CurrentPlayer = 0;
                }
            }

            // Southeast
            Column = imageArray.Get_Col(sender);
            Row = imageArray.Get_Row(sender);
            if (IsValidMove(1, 1))
            {
                Column = imageArray.Get_Col(sender);
                Row = imageArray.Get_Row(sender);
                FlipCounters(1, 1);
                if (CurrentPlayer == 0)
                {
                    CurrentPlayer = 1;
                }
                else
                {
                    CurrentPlayer = 0;
                }
            }

            // Northwest
            Column = imageArray.Get_Col(sender);
            Row = imageArray.Get_Row(sender);
            if (IsValidMove(-1, -1))
            {
                Column = imageArray.Get_Col(sender);
                Row = imageArray.Get_Row(sender);
                FlipCounters(-1, -1);
                if (CurrentPlayer == 0)
                {
                    CurrentPlayer = 1;
                }
                else
                {
                    CurrentPlayer = 0;
                }
            }

            // Northeast
            Column = imageArray.Get_Col(sender);
            Row = imageArray.Get_Row(sender);
            if (IsValidMove(-1, 1))
            {
                Column = imageArray.Get_Col(sender);
                Row = imageArray.Get_Row(sender);
                FlipCounters(-1, 1);
                if (CurrentPlayer == 0)
                {
                    CurrentPlayer = 1;
                }
                else
                {
                    CurrentPlayer = 0;
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
            //Debug.WriteLine(Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..\", "Images", "Green_Square.jpg")));

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
        /// Button to start the game and load the board.
        /// </summary>
        /// <param name="sender">The button clicked.</param>
        /// <param name="e">Event</param>
        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PlayerOneTxt.Text) || string.IsNullOrEmpty(PlayerTwoTxt.Text))
            {
                MessageBox.Show("Player names can not be empty.");
                return;
            }

            Player1Name = PlayerOneTxt.Text;
            Player2Name = PlayerTwoTxt.Text;

            imageArray = new GImageArray(this, cardArray, 50, 50, 200, 50, 0, "Images\\");
            imageArray.Which_Element_Clicked += new GImageArray.ImageClickedEventHandler(Which_Element_Clicked);
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
                if (cardArray[Row, Column] == CurrentPlayer)
                {
                    break;
                }
                else
                {
                    cardArray[Row, Column] = CurrentPlayer;
                }

                Row += xDirection;
                Column += yDirection;
            }
        }
    }
}
