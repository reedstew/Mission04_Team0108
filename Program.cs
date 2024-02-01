// Authors: Reed Stewart, Matt Cooper. Jake Millet, Caleb Reese
// Description: The game of Tic-Tac-Toe in C#.


// The "Driver" Class will be written below:
/* The “Driver” class (the Program.cs class with the main method where the program begins)
will:
• Welcome the user to the game
• Create a game board array to store the players’ choices
• Ask each player in turn for their choice and update the game board array
• Print the board by calling the method in the supporting class
• Check for a winner by calling the method in the supporting class, and notify the players
when a win has occurred and which player won the game */

using System.Numerics;
using System.Threading.Tasks;

public class Driver
    {
    public static void Main()
    {
        bool GameWon = false;

        // Welcome the user to the game
        Console.Write("Welcome to the game of Tic-Tac-Toe");
        Thread.Sleep(400);
        Console.Write(".");
        Thread.Sleep(400);
        Console.Write(".");
        Thread.Sleep(400);
        Console.Write('.');
        Console.WriteLine("");

        //Create a game board array to store the players’ choices

        //Define 3x3
        char[,] board = new char[3, 3];
        // Player arrays
        char[,] playerOne = new char[3, 3];
        char[,] playerTwo = new char[3, 3];

        // Populate
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                board[i, j] = '#';
            }
        }
        // Begin the game:

        do
        {


            // Ask each player in turn for their choice and update the game board array

            // First players turn
            Console.WriteLine("Player One: Choose a row. Type 'TOP', 'MIDDLE', or 'BOTTOM'.");
            string pOneRow = Console.ReadLine();
            ValidateRow(pOneRow);
            pOneRow = pOneRow.ToUpper();

            Console.WriteLine("Player One: Choose a column. Type 'LEFT', 'CENTER', or 'RIGHT'.");
            string pOneColumn = Console.ReadLine();
            ValidateColumn(pOneColumn);
            pOneColumn = pOneColumn.ToUpper();

            if (pOneRow.Equals("TOP"))
            {
                playerOne[0, 1] = "X";
            }
            else if (pOneRow.Equals("MIDDLE"))
            {

            }
            else
            {

            }

            // Second players turn
            Console.WriteLine("Player Two: Choose a row. Type 'TOP', 'MIDDLE', or 'BOTTOM'.");
            string pTwoRow = Console.ReadLine();
            ValidateRow(pTwoRow);
            pTwoRow = pTwoRow.ToUpper();

            Console.WriteLine("Player Two: Choose a column. Type 'LEFT', 'CENTER', or 'RIGHT'.");
            string pTwoColumn = Console.ReadLine();
            ValidateColumn(pTwoColumn);
            pTwoColumn = pTwoColumn.ToUpper();

            if (pTwoRow.Equals("TOP"))
            {

            }
            else if (pTwoRow.Equals("MIDDLE"))
            {

            }
            else
            {

            }

        } while (!GameWon);
    }
    public static void ValidateRow(string choice)
    {
        bool valid = false;
        do
        {
            choice = choice.ToUpper();
            if ((choice == "TOP" || choice == "MIDDLE" || choice == "BOTTOM"))
            {
                valid = true;
            }
            else
            {
                Console.WriteLine("Please choose a valid row. Type 'TOP', 'MIDDLE', or 'BOTTOM'.");
                choice = Console.ReadLine();
            }
        } while (valid);
    }

    public static void ValidateColumn(string choice)
    {
        bool valid = false;
        do
        {
            choice = choice.ToUpper();
            if ((choice == "LEFT" || choice == "CENTER" || choice == "RIGHT"))
            {
                valid = true;
            }
            else
            {
                Console.WriteLine("Please choose a valid column. Type 'LEFT', 'CENTER', or 'RIGHT'.");
                choice = Console.ReadLine();
            }
        } while (valid);
    }

    public static bool CheckForWinner(char[,] board)
    {
        // Check rows, columns, and diagonals for a winner
        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != ' ')
                return true;
            if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != ' ')
                return true;
        }
        if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != ' ')
            return true;
        if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != ' ')
            return true;

        return false;
    }
}
    