string xArt = " _  _ \n" +
            "( \\/ )\n" +
            " )  ( \n" +
            "(_/\\_)\n";

string asciiArt = "__  \n" +
                " /  \\ \n" +
                "(  O )\n" +
                " \\__/ \n";

void DisplayBoard(char[,] tictactoe)
{

    Console.WriteLine(xArt + xArt + xArt);

}


char[,] tictactoe = new char[3, 3]
{
    {' ', ' ', ' '},
    {' ', ' ', ' '},
    {' ', ' ', ' '},
};

DisplayBoard(tictactoe);
