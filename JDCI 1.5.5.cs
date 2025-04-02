using System;
using System.Buffers;
using System.Text;
using System.Threading;

class TickTacToe
{
    char[,] board = new char[3, 3];

    string playerOne;
    string playerTwo;
    int playerTurn = 0;



    private void InitializeBoard()
    {
        char position = '1';
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                board[i, j] = position;
                position++;
            }
        }
    }

    private void GetPlayers()
    {
        Console.WriteLine("Player's one name: ");
        playerOne = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Player's two name: ");
        playerTwo = Console.ReadLine();
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{playerOne} will be ×");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{playerTwo} will be o");
        Console.ResetColor();

        Console.WriteLine("\nThe game will start in 2 seconds...");
        Thread.Sleep(2000);
        Console.Clear();
    }

    /* The player will select a number from 1 to 9, we need to convert it to a position in a [3,3] array */
    private (int, int) TranslatePosToArray(int move)
    {
        int x = move / 3;
        int y = move % 3;
        return (x, y);
    }

    private bool isMoveValid(int x, int y)
    {
        if (board[x, y] == 'x' || board[x, y] == 'o')
        {
            Console.WriteLine("The movement isn't valid");
            return false;
        }

        return true;
    }

    private void MakeMoves()
    {
        (int, int) arrayPos;

        do
        {
            Console.WriteLine();
            Console.Write("Type position: ");
            int movePosition = Convert.ToInt32(Console.ReadLine()) - 1;
            arrayPos = TranslatePosToArray(movePosition);
        } while (!isMoveValid(arrayPos.Item1, arrayPos.Item2));

        if (playerTurn % 2 == 0)
        {
            board[arrayPos.Item1, arrayPos.Item2] = 'x';
        }
        else
        {
            board[arrayPos.Item1, arrayPos.Item2] = 'o';
        }

        Console.Clear();

        playerTurn++;
    }
    private void DisplayBoard()
    {

        // The board should display the color of the past movement.
        if (playerTurn % 2 != 0)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{playerOne}'S TURN");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{playerTwo}'S TURN");
        }

        Console.WriteLine();
        Console.WriteLine();

        Console.ResetColor();

        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                switch (board[i, j])
                {
                    case 'o':
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case 'x':
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    default:
                        Console.ResetColor();
                        break;
                }
                Console.Write(" " + board[i, j] + " ");


            }
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("---------");
        }
    }

    private bool IsVictory()
    {

        bool hasWinner = false;
        char winnerPiece = ' ';

        /*
        [@][@][@]
        [ ][ ][ ]
        [ ][ ][ ]
        */
        if (board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2])
        {
            hasWinner = true;
            winnerPiece = board[0, 0];
        }
        /*
        [ ][ ][ ]
        [@][@][@]
        [ ][ ][ ]
        */
        else if (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2])
        {
            hasWinner = true;
            winnerPiece = board[1, 0];
        }

        /*
        [ ][ ][ ]
        [ ][ ][ ]
        [@][@][@]
        */
        else if (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2])
        {
            hasWinner = true;
            winnerPiece = board[2, 0];
        }

        /*
        [@][ ][ ]
        [@][ ][ ]
        [@][ ][ ]
        */
        else if (board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0])
        {
            hasWinner = true;
            winnerPiece = board[0, 0];
        }
        /*
        [ ][@][ ]
        [ ][@][ ]
        [ ][@][ ]
        */
        else if (board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1])
        {
            hasWinner = true;
            winnerPiece = board[0, 1];
        }
        /*
        [ ][ ][@]
        [ ][ ][@]
        [ ][ ][@]
        */
        else if (board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2])
        {
            hasWinner = true;
            winnerPiece = board[0, 2];
        }
        /*
        [ ][ ][@]
        [ ][@][ ]
        [@][ ][ ]
        */
        else if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
        {
            hasWinner = true;
            winnerPiece = board[0, 2];
        }
        /*
        [@][ ][ ]
        [ ][@][ ]
        [ ][ ][@]
        */
        else if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
        {
            hasWinner = true;
            winnerPiece = board[0, 0];
        }

        if (hasWinner)
        {
            if (winnerPiece == 'x')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Congratulations {playerTwo}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Congratulations {playerOne}");
            }

            Console.ResetColor();
            return true;
        }

        Console.ResetColor();
        return false;
    }

    private bool IsDraw()
    {
        if (playerTurn > 8)
        {
            Console.WriteLine("Draw!");
            return true;
        }
        Console.ResetColor();
        return false;
    }

    public void Play()
    {
        GetPlayers();
        InitializeBoard();

        while (!IsDraw() && !IsVictory())
        {
            DisplayBoard();
            MakeMoves();
        }

    }
}

/*
class Program
{
    static void Main()
    {
        TickTacToe game = new TickTacToe();
        game.Play();
    }
}
*/

TickTacToe game = new TickTacToe();
game.Play();