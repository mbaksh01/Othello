using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUIImageArray;
using System.IO;
using System.Diagnostics;

namespace Othello
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// White Square
        /// </summary>
        public string Player1Name { get; set; }

        /// <summary>
        /// Balck Square
        /// </summary>
        public string Player2Name { get; set; }

        /// <summary>
        /// Player turn, used to switch between each player;
        /// </summary>
        public bool Player1Turn { get; set; }

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
            Player1Turn = true;            
        }

        private void Which_Element_Clicked(object sender, EventArgs e)
        {
            Column = imageArray.Get_Col(sender) + 1;
            Row = imageArray.Get_Row(sender) + 1;
            IsValidMove();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Debug.WriteLine(Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..\", "Images", "Green_Square.jpg")));

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

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PlayerOneTxt.Text) || string.IsNullOrEmpty(PlayerTwoTxt.Text))
            {
                MessageBox.Show("Player names can not be empty.");
                return;
            }

            Player1Name = PlayerOneTxt.Text;
            Player2Name = PlayerTwoTxt.Text;

            imageArray = new GImageArray(this, cardArray, 50, 50, 200, 50, 0, "C:\\Users\\MBaksh\\source\\repos\\Othello\\Othello\\Images\\Green_Square.jpg");
            imageArray.Which_Element_Clicked += new GImageArray.ImageClickedEventHandler(Which_Element_Clicked);
        }

        private bool IsValidMove()
        {
            // must connect to another pience of the same colour in a line.
            // must cross over a single piece of the other player.

            return true;
        }
    }
}
