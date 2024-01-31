using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Mission04_Team0108
{
    public class Support
    {
        // The supporting class will be written below:
        /*The supporting class (with whichever name you choose) will:
            • Receive the “board” array from the driver class
            • Contain a method that prints the board based on the information passed to it
            • Contain a method that receives the game board array as input and returns if there is a
                winner and who it was*/
        int[,] board = new int[3, 3];
        int rowIndex = 0;
        int columnIndex = 0;
        int turnTracker = 0;
        bool winnerFlag = false;
        bool[] winningSituations = new bool[8];
        string winningTeam = "";
        
        public Array UpdateBoard(board, row, column)
        {   
            //These if statements are changing the top, middle, bottom, left, middle, right into the numbers in the array
            if (row[0].lower() == 't')
            {
                rowIndex = 0;
            }
            else if (rowIndex[0].lower() =='m')
            {
                rowIndex = 1;
            }
            else if (rowIndex[0].lower() == 'b')
            {
                rowIndex = 2;
            }
            else
            {
                Console.WriteLine("Input for row is not valid");
            }

            if (column[0].lower() == 'l')
            {
                columnIndex = 0;
            }
            else if (column[0].lower(0) == 'm')
            {
                columnIndex = 1;
            }
            else if (column[0].lower() == 'r')
            {
                columnIndex = 2;
            }
            else
            {
                Console.WriteLine("Input for column is not valid");

            //This is deciding whether it gets changed with an O or an X using the turnTracker variable
            if (turnTracker == 0)
            {
                board[rowIndex, columnIndex] = 'X';
            }
            else if (turnTracker == 1)
                board[rowIndex, columnIndex] = 'O';

            
            }

            //This is what keeps the turntracker where it needs to be for changing turns
            turnTracker++;
            if (turnTracker == 2)
            {
                turnTracker = 0;
            }


            return (board);

        }

        public bool Winner(board)
        {
            //This is going through all of the winning situations and changing a boolean array I created to true if it is true.
            //This also determines the winning team
            if (board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2])
            {
                winningSituations[0] = true;
                winningTeam = board[0, 2].ToString();
            }
            else winningSituations[0] = false;

            if (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2])
            {
                winningSituations[1] = true;
                winningTeam = board[1, 2].ToString();
            }
            else winningSituations[1] = false;

            if (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2])
            {
                winningSituations[2] = true;
                winningTeam = board[2, 2].ToString();
            }
            else winningSituations[2] = false;

            if (board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0])
            {
                winningSituations[3] = true;
                winningTeam = board[2, 0].ToString();
            }
            else winningSituations[3] = false;

            if (board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1])
            {
                winningSituations[4] = true;
                winningTeam = board[2, 1].ToString();
            }
            else
            {
                winningSituations[4] = false;
            }

            if (board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2])
            {
                winningSituations[5] = true;
                winningTeam = board[2, 2].ToString();
            }
            else
            {
                winningSituations[5] = false;
            }

            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                winningSituations[6] = true;
                winningTeam = board[2, 2].ToString();
            }
            else 
            {
                winningSituations[6] = false; 
            }

            if (board[2, 0] == board[1, 1] && board[1, 1] == board[0, 2])
            {
                winningSituations[7] = true;
                winningTeam = board[0, 2].ToString();
            }
            else 
            {
                winningSituations[7] = false; 
            }
            // This goes through all of the winning situations array and if any of them are true it changes the winner flag to true.
            for (int i = 0; i < winningSituations.Length; i++)
            {
                if (winningSituations[i] == true)
                {

                    winnerFlag = true;
                    break; // Exit the loop since we found a true value
                }
            }

            return winnerFlag;

        }




    }
}
