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

using Mission04_Team0108;
using System.Numerics;
using System.Threading.Tasks;

public class Driver
    {
    public static void Main()
    {
        int gameTracker = 0;
        bool GameWon = false;
        int turnTracker = 0;
        // Welcome the user to the game
        Console.Write("Welcome to the game of Tic-Tac-Toe");
        Thread.Sleep(400);
        Console.Write(".");
        Thread.Sleep(400);
        Console.Write(".");
        Thread.Sleep(400);
        Console.Write('.');
        Console.WriteLine("");
        Support s = new Support();
        //Create a game board array to store the players’ choices

        //Define 3x3
        char[,] board = new char[3, 3];
        // Player arrays
        bool WinnerFlag = false;

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
            string row = "";
            string column = "";

            // Ask each player in turn for their choice and update the game board array

            // First players turn
            if (turnTracker == 0)
            {
                Console.WriteLine("Player One: Choose a row. Type 'TOP', 'MIDDLE', or 'BOTTOM'.");
                row = Console.ReadLine();
                row = ValidateRow(row);
                Console.WriteLine("Player One: Choose a column. Type 'LEFT', 'CENTER', or 'RIGHT'.");
                column = Console.ReadLine();
                column = ValidateColumn(column);
            }
            else if (turnTracker == 1)
            {
                Console.WriteLine("Player Two: Choose a row. Type 'TOP', 'MIDDLE', or 'BOTTOM'.");
                row = Console.ReadLine();
                row = ValidateRow(row);

                Console.WriteLine("Player Two: Choose a column. Type 'LEFT', 'CENTER', or 'RIGHT'.");
                column = Console.ReadLine();
                column = ValidateColumn(column);


            }

            turnTracker++;
            
            if (turnTracker == 2)
            {
                turnTracker = 0;
                board = s.UpdateBoard(board, row, column, turnTracker);
            }
            else
            {
                board = s.UpdateBoard(board, row, column, turnTracker);
            }

            GameWon = s.Winner(board, WinnerFlag);
            gameTracker++;
            if (gameTracker == 9 && !GameWon)
            {
                GameWon = true;
                Console.WriteLine("Womp. Womp. You ended in a tie...");
            }
        } while (!GameWon);
    }
    public static string ValidateRow(string choice)
    {
        string validRow = "";
        bool valid = false;
        do
        {
            choice = choice.ToUpper();
            if ((choice == "TOP" || choice == "MIDDLE" || choice == "BOTTOM"))
            {
                validRow = choice;
                valid = true;
            }
            else
            {
                Console.WriteLine("Please choose a valid row. Type 'TOP', 'MIDDLE', or 'BOTTOM'.");
                choice = Console.ReadLine();
            }
        } while (!valid);
        return validRow;
    }

    public static string ValidateColumn(string choice)
    {
        string validColumn = "";
        bool valid = false;
        do
        {
            choice = choice.ToUpper();
            if ((choice == "LEFT" || choice == "CENTER" || choice == "RIGHT"))
            {
                validColumn = choice;
                valid = true;
            }
            else
            {
                Console.WriteLine("Please choose a valid column. Type 'LEFT', 'CENTER', or 'RIGHT'.");
                choice = Console.ReadLine();
            }
        } while (!valid);
        return validColumn;
    }
}
    