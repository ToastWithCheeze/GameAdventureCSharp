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
            int _turns = 1;
            bool _x_turn = true;
            string player;
            Console.WriteLine("Welcome to the Tic Tac Toe!");


            while (_running)
            {
                Print_board();
                //Checks whos turn it is
                if (_x_turn == true)
                {
                    player = "X";
                }
                else
                {
                    player = "O";
                }

                Move(player);
                //Checks winner after every move and continues if none has won
                if (Check_winner("X") == true)
                {
                    Win_message("X");
                    _running = false;
                    break;
                }
                else if (Check_winner("O") == true)
                {
                    Win_message("O");
                    _running = false;
                    break;
                }
                else
                {
                    Console.Clear();
                }
                //Keeps tracks of how many turns the game is on
                if (_turns++ == 9)
                {
                    Console.WriteLine("Yall ran out of turns...");
                    _running = false;
                    break;
                }

                //Sets next turn
                if (_x_turn == true)
                {
                    _x_turn = false;
                }
                else if (_x_turn == false)
                {
                    _x_turn = true;
                }


            }

        }

        private void Win_message(string _player)
        {
            Console.WriteLine($"You Won! ({_player})");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

        }
        private void Print_board()
        {
            Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
        }
        private void Move(string _player)
        {
            while (true)
            {
                Console.Write($"Make your move ({_player}): ");
                int _position = Convert.ToInt32(Console.ReadLine());
                if (board[_position - 1] != "X" && board[_position - 1] != "O")
                {
                    board[_position - 1] = _player; // case senstivity important!!
                    break;
                }
                else
                {
                    Console.WriteLine("Idiot someones already there!!");
                    continue;
                }
            }



        }
        private bool Check_winner(string _player) //borde return true of false, lägger till senare nog
        {
            for (int i = 0; i < win_combination.GetLength(0); i++)
            {
                if (board[win_combination[i, 0]] == _player &&
                    board[win_combination[i, 1]] == _player &&
                    board[win_combination[i, 2]] == _player)
                {
                    return true; //ger tillbaka true och slutar kollar

                }
            }
            return false; // ger tillbaka false om ingen match hittades
        }

    }
}
