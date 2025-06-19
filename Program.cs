namespace ConnectFour;

public class Program
{
    public static void Main(string[] args)
    {
        // Create an instance of the Board class
        Board gameBoard = new Board();

        // Call the DisplayBoard method to show the empty board
        gameBoard.DisplayBoard();

        // Keep the console window open until a key is pressed
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}