using System;

namespace ConnectFour
{
    public class Board
    {
        // Attributes for the board dimensions and the grid itself
        private char[,] grid; // Using char to store 'X', 'O', or '#' (empty)
        private int rows = 6; // Connect Four has 6 rows 
        private int columns = 7; // Connect Four has 7 columns 

        // Constructor to initialize the board
        public Board()
        {
            grid = new char[rows, columns];
            InitializeBoard();
        }

        // Method to set all cells to empty (e.g., '#')
        private void InitializeBoard()
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    grid[r, c] = '#'; // Use '#' to represent an empty slot
                }
            }
        }

        // Method to display the current state of the board
        public void DisplayBoard()
        {
            Console.WriteLine("\nConnect 4 Game Development Project:"); // Matches example output 
            Console.WriteLine(); // Blank line for spacing

            // Display the grid
            for (int r = 0; r < rows; r++)
            {
                Console.Write("|");
                for (int c = 0; c < columns; c++)
                {
                    Console.Write($" {grid[r, c]}");
                }
                Console.WriteLine(" |");
            }

            //[cite_start]// Display column numbers at the bottom 
            Console.WriteLine("-----------------"); // Separator line
            Console.Write("  "); // Indent to align with columns
            for (int c = 1; c <= columns; c++)
            {
                Console.Write($" {c}");
            }
            Console.WriteLine("\n"); // Newline after column numbers
        }

        // --- Placeholders for other Board methods (will implement later) ---

        // public bool DropPiece(int column, char playerSymbol) { /* ... */ return false; }
        // public bool IsColumnFull(int column) { /* ... */ return false; }
        // public bool CheckWin(char playerSymbol) { /* ... */ return false; }
        // public bool CheckTie() { /* ... */ return false; }
    }
}