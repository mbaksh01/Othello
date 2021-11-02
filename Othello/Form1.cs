﻿using GUIImageArray;
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
            Column = imageArray.Get_Col(sender);
            Row = imageArray.Get_Row(sender);

            PictureBox pictureBox = imageArray.Get_Element(sender);

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

            imageArray = new GImageArray(this, cardArray, 50, 50, 200, 50, 0, "C:\\Users\\MBaksh\\source\\repos\\Othello\\Othello\\Images");
            imageArray.Which_Element_Clicked += new GImageArray.ImageClickedEventHandler(Which_Element_Clicked);
        }

        private bool[] IsValidMove()
        {
            // All direction are validated and added to this array
            bool[] validDirections = new bool[8];

            if (Player1Turn)
            {
                if (cardArray[Row, Column] == 10)
                {
                    int rowCounter = Row;
                    int columnCounter = Column;

                    // Check North - 0
                    do
                    {
                        try
                        {
                            if (cardArray[rowCounter - 1, Column] != 1)
                            {
                                validDirections[0] = false;
                                break;
                            }
                            else
                            {
                                validDirections[0] = true;
                                rowCounter--;
                            }
                        }
                        catch (Exception)
                        {

                            validDirections[0] = false;
                        }

                    } while (cardArray[rowCounter, Column] != 0);

                    // Check South - 1
                    do
                    {
                        try
                        {
                            if (cardArray[rowCounter + 1, Column] != 1)
                            {
                                validDirections[1] = false;
                                break;
                            }
                            else
                            {
                                validDirections[1] = true;
                                rowCounter++;
                            }
                        }
                        catch (Exception)
                        {

                            validDirections[1] = false;
                        }

                    } while (cardArray[rowCounter, Column] != 0);

                    // Check East - 2
                    do
                    {
                        try
                        {
                            if (cardArray[Row, columnCounter + 1] != 1)
                            {
                                validDirections[2] = false;
                                break;
                            }
                            else
                            {
                                validDirections[2] = true;
                                columnCounter++;
                            }
                        }
                        catch (Exception)
                        {

                            validDirections[2] = false;
                        }

                    } while (cardArray[Row, columnCounter] != 0);

                    // Check West - 3
                    do
                    {
                        try
                        {
                            if (cardArray[Row, columnCounter - 1] != 1)
                            {
                                validDirections[3] = false;
                                break;
                            }
                            else
                            {
                                validDirections[3] = true;
                                columnCounter--;
                            }
                        }
                        catch (Exception)
                        {

                            validDirections[3] = false;
                        }

                    } while (cardArray[Row, columnCounter] != 0);

                    // Check Northwest - 4
                    do
                    {
                        try
                        {
                            if (cardArray[rowCounter - 1, columnCounter - 1] != 1)
                            {
                                validDirections[4] = false;
                                break;
                            }
                            else
                            {
                                validDirections[4] = true;
                                rowCounter--;
                                columnCounter--;
                            }
                        }
                        catch (Exception)
                        {

                            validDirections[4] = false;
                        }

                    } while (cardArray[rowCounter, columnCounter] != 0);

                    // Check NorthEast - 5
                    do
                    {
                        try
                        {
                            if (cardArray[rowCounter - 1, columnCounter + 1] != 1)
                            {
                                validDirections[5] = false;
                                break;
                            }
                            else
                            {
                                validDirections[5] = true;
                                rowCounter--;
                                columnCounter++;
                            }
                        }
                        catch (Exception)
                        {

                            validDirections[5] = false;
                        }

                    } while (cardArray[rowCounter, columnCounter] != 0);

                    // Check SouthEast - 6
                    do
                    {
                        try
                        {
                            if (cardArray[rowCounter + 1, columnCounter + 1] != 1)
                            {
                                validDirections[6] = false;
                                break;
                            }
                            else
                            {
                                validDirections[6] = true;
                                rowCounter++;
                                columnCounter++;
                            }
                        }
                        catch (Exception)
                        {

                            validDirections[6] = false;
                        }

                    } while (cardArray[rowCounter, columnCounter] != 0);

                    // Check SouthWest - 7
                    do
                    {
                        try
                        {
                            if (cardArray[rowCounter + 1, columnCounter - 1] != 1)
                            {
                                validDirections[7] = false;
                                break;
                            }
                            else
                            {
                                validDirections[7] = true;
                                rowCounter++;
                                columnCounter--;
                            }
                        }
                        catch (Exception)
                        {

                            validDirections[7] = false;
                        }

                    } while (cardArray[rowCounter, columnCounter] != 0);

                }
            }
            else
            {
                if (cardArray[Row, Column] == 10)
                {
                    int rowCounter = Row;
                    int columnCounter = Column;

                    // Check North - 0
                    do
                    {
                        try
                        {
                            if (cardArray[rowCounter - 1, Column] != 1)
                            {
                                validDirections[0] = false;
                                break;
                            }
                            else
                            {
                                validDirections[0] = true;
                                rowCounter--;
                            }
                        }
                        catch (Exception)
                        {

                            validDirections[0] = false;
                        }

                    } while (cardArray[rowCounter, Column] != 0);

                    // Check South - 1
                    do
                    {
                        try
                        {
                            if (cardArray[rowCounter + 1, Column] != 1)
                            {
                                validDirections[1] = false;
                                break;
                            }
                            else
                            {
                                validDirections[1] = true;
                                rowCounter++;
                            }
                        }
                        catch (Exception)
                        {

                            validDirections[1] = false;
                        }

                    } while (cardArray[rowCounter, Column] != 0);

                    // Check East - 2
                    do
                    {
                        try
                        {
                            if (cardArray[Row, columnCounter + 1] != 1)
                            {
                                validDirections[2] = false;
                                break;
                            }
                            else
                            {
                                validDirections[2] = true;
                                columnCounter++;
                            }
                        }
                        catch (Exception)
                        {

                            validDirections[2] = false;
                        }

                    } while (cardArray[Row, columnCounter] != 0);

                    // Check West - 3
                    do
                    {
                        try
                        {
                            if (cardArray[Row, columnCounter - 1] != 1)
                            {
                                validDirections[3] = false;
                                break;
                            }
                            else
                            {
                                validDirections[3] = true;
                                columnCounter--;
                            }
                        }
                        catch (Exception)
                        {

                            validDirections[3] = false;
                        }

                    } while (cardArray[Row, columnCounter] != 0);

                    // Check Northwest - 4
                    do
                    {
                        try
                        {
                            if (cardArray[rowCounter - 1, columnCounter - 1] != 1)
                            {
                                validDirections[4] = false;
                                break;
                            }
                            else
                            {
                                validDirections[4] = true;
                                rowCounter--;
                                columnCounter--;
                            }
                        }
                        catch (Exception)
                        {

                            validDirections[4] = false;
                        }

                    } while (cardArray[rowCounter, columnCounter] != 0);

                    // Check NorthEast - 5
                    do
                    {
                        try
                        {
                            if (cardArray[rowCounter - 1, columnCounter + 1] != 1)
                            {
                                validDirections[5] = false;
                                break;
                            }
                            else
                            {
                                validDirections[5] = true;
                                rowCounter--;
                                columnCounter++;
                            }
                        }
                        catch (Exception)
                        {

                            validDirections[5] = false;
                        }

                    } while (cardArray[rowCounter, columnCounter] != 0);

                    // Check SouthEast - 6
                    do
                    {
                        try
                        {
                            if (cardArray[rowCounter + 1, columnCounter + 1] != 1)
                            {
                                validDirections[6] = false;
                                break;
                            }
                            else
                            {
                                validDirections[6] = true;
                                rowCounter++;
                                columnCounter++;
                            }
                        }
                        catch (Exception)
                        {

                            validDirections[6] = false;
                        }

                    } while (cardArray[rowCounter, columnCounter] != 0);

                    // Check SouthWest - 7
                    do
                    {
                        try
                        {
                            if (cardArray[rowCounter + 1, columnCounter - 1] != 1)
                            {
                                validDirections[7] = false;
                                break;
                            }
                            else
                            {
                                validDirections[7] = true;
                                rowCounter++;
                                columnCounter--;
                            }
                        }
                        catch (Exception)
                        {

                            validDirections[7] = false;
                        }

                    } while (cardArray[rowCounter, columnCounter] != 0);

                }
            }

            return validDirections;
        }
    }
}
