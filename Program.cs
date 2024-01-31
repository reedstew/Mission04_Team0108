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

        // Ask each player in turn for their choice and update the game board array
        Console.WriteLine("Player One: Choose a row. Type 'TOP', 'MIDDLE', or 'BOTTOM'.");
        string pOneRow = Console.ReadLine();

        
        Console.WriteLine("Player One: Choose a column. Type 'LEFT', 'CENTER', or 'RIGHT'.");
        string pOneColumn  = Console.ReadLine();

    }

    public static void Validate(string choice)
    {

    }
}
    