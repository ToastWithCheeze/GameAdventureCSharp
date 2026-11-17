namespace TicTacToe
{
    public class Game
    {
        private readonly string[] board = ["1", "2", "3", "4", "5", "6", "7", "8", "9"];
        public void Start()
        {
            Console.WriteLine("Welcome to the Tic Tac Toe!");
            Print_board();
        }

        private void Print_board()
        {
            Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
        }
        private void Move()
        {

        }
        static void Check_winner()
        {

        }

    }
}
