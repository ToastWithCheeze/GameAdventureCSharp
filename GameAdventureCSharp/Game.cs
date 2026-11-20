namespace TicTacToe
{
    public class Game
    {
        private string[] board = ["1", "2", "3", "4", "5", "6", "7", "8", "9"];
        private int[,] win_combination = {
            { 0, 1, 2 },
            { 3, 4, 5 },
            { 6, 7, 8 },
            { 0, 3, 6 },
            { 1, 4, 7 },
            { 2, 5, 8 },
            { 0, 4, 8 },
            { 2, 4, 6 }
        };

        public void Start()
        {
            bool _running = true;
            Console.WriteLine("Welcome to the Tic Tac Toe!");
            while (_running)
            {
                Print_board();
                Move();
                if (Check_winner() == true)
                {
                    Console.WriteLine("You Won!");
                    _running = false;
                }

            }

        }

        public void debug()
        {

        }

        private void Game_loop()
        {

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
            Console.Write("Make your move ({player}): ");
            int _position = Convert.ToInt32(Console.ReadLine());
            if (board[_position - 1] != "X")
            {
                board[_position - 1] = "X"; // case senstivity important!!
            }


        }
        private bool Check_winner() //borde return true of false, lägger till senare nog
        {
            for (int i = 0; i < win_combination.GetLength(0); i++)
            {
                if (board[win_combination[i, 0]] == "X" && 
                    board[win_combination[i, 1]] == "X" && 
                    board[win_combination[i, 2]] == "X")
                {
                    return true; //ger tillbaka true och slutar kollar

                }
            }
            return false; // ger tillbaka false om ingen match hittades
        }

    }
}
