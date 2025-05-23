using System;

public class TicTacToe
{
    private char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    private char currentPlayer = 'X';

    public void Play()
    {
        while (true)
        {
            DisplayBoard();
            MakeMove();
            if (CheckWin())
            {
                DisplayBoard();
                Console.WriteLine($"Игрок {currentPlayer} победил!");
                break;
            }
            else if (CheckDraw())
            {
                DisplayBoard();
                Console.WriteLine("Ничья!");
                break;
            }
            SwitchPlayer();
        }
    }

    private void DisplayBoard()
    {
        Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
    }

    private void MakeMove()
    {
        Console.Write($"Ход игрока {currentPlayer}: Введите номер ячейки (1-9): ");
        string input = Console.ReadLine();
        int move;

        if (int.TryParse(input, out move) && move >= 1 && move <= 9 && board[move - 1] != 'X' && board[move - 1] != 'O')
        {
            board[move - 1] = currentPlayer;
        }
        else
        {
            Console.WriteLine("Неверный ход. Попробуйте еще раз.");
            MakeMove(); 
        }
    }


    private bool CheckWin()
    {
        return (board[0] == board[1] && board[1] == board[2] && board[0] != ' ') ||
               (board[3] == board[4] && board[4] == board[5] && board[3] != ' ') ||
               (board[6] == board[7] && board[7] == board[8] && board[6] != ' ') ||
               (board[0] == board[3] && board[3] == board[6] && board[0] != ' ') ||
               (board[1] == board[4] && board[4] == board[7] && board[1] != ' ') ||
               (board[2] == board[5] && board[5] == board[8] && board[2] != ' ') ||
               (board[0] == board[4] && board[4] == board[8] && board[0] != ' ') ||
               (board[2] == board[4] && board[4] == board[6] && board[2] != ' ');
    }

    private bool CheckDraw()
    {
        foreach (char cell in board)
        {
            if (cell != 'X' && cell != 'O')
            {
                return false; 
            }
        }
        return true; 
    }

    private void SwitchPlayer()
    {
        currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
    }


    public static void Main(string[] args)
    {
        TicTacToe game = new TicTacToe();
        game.Play();
    }
}
