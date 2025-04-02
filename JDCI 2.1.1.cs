class Player
{
    char piece;


}


class FourInARow
{
    int boardSize = 16;
    char[, ] board = new char[16, 16];
    Player[] players = new Player[2];

    private void InitializeBoard()
    {
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                board[i, j] = ' ';
            }
        }
    }


    private void DisplayBoard()
    {
        for (int i = 1; i <= boardSize; i++)
        {   
            Console.Write($"  {i.ToString("D2")}  ");
            //Console.Write(i.ToString("D2") + " ");
        }

        Console.WriteLine();

        for (int i = 0; i < boardSize; i++)
        {   
            for (int j = 0; j < boardSize; j++)
            {   
                if (j != boardSize - 1)
                {
                    Console.Write($"|  {board[i, j]}  ");
                }
                else
                {
                    Console.Write($"|  {board[i, j]}  |");
                }
            }
            Console.WriteLine();
        }
    }

    public void Play()
    {
        InitializeBoard();
        DisplayBoard();
    }

}

FourInARow fourInARow = new FourInARow();
fourInARow.Play();
