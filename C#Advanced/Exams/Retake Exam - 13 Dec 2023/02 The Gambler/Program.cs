int n = int.Parse(Console.ReadLine());
string[,] board = new string[n, n];

string[] gamblerDefaultPosition = InitializeGameBoard(n).Split().ToArray();

int currRow = int.Parse(gamblerDefaultPosition[0]);
int currCol = int.Parse(gamblerDefaultPosition[1]);

int cash = 100;
bool jackpot = false;

string command;
while ((command = Console.ReadLine()) != "end")
{
    if (IsOutOfGameBoard(n, currRow, currCol, command) == true)
    {
        Console.WriteLine($"Game over! You lost everything!");
        continue;
    }

     if (jackpot)
    {
        continue;
    }
    else
    {
        if (command == "up")
        {
            board[currRow, currCol] = "-";
            currRow--;
        }
        else if (command == "down")
        {
            board[currRow, currCol] = "-";
            currRow++;
        }
        else if (command == "left")
        {
            board[currRow, currCol] = "-";
            currCol--;
        }
        else
        {
            board[currRow, currCol] = "-";
            currCol++;
        }
    }

        if (board[currRow, currCol] == "W")
        {
            cash += 100;
        }
        else if (board[currRow, currCol] == "P")
        {
            cash -= 200;
        }
        else if (board[currRow, currCol] == "J")
        {
            cash += 100000;
            Console.WriteLine($"You win the Jackpot!");
            jackpot = true;
        }
        board[currRow, currCol] = "G";
    if (cash <= 0)
    {
        Console.WriteLine($"Game over! You lost everything!");
        break;
    }
}

if (cash > 0)
{
    Console.WriteLine($"End of the game. Total amount: {cash}$");
    PrintBoard();
}

void PrintBoard()
{
    for (int r = 0; r < board.GetLength(0); r++)
    {
        for (int c = 0; c < board.GetLength(1); c++)
        {
            Console.Write(board[r, c] + "");
        }
        Console.WriteLine();
    }
}

string InitializeGameBoard(int n)
{
    string gamblerPosition = string.Empty;

    for (int r = 0; r < n; r++)
    {
        var rowData = Console.ReadLine().ToCharArray();

        for (int c = 0; c < rowData.Length; c++)
        {
            if (rowData[c].ToString() == "G")
            {
                gamblerPosition = r + " " + c;
            }
            board[r, c] = rowData[c].ToString();
        }
    }

    return gamblerPosition;
}

static bool IsOutOfGameBoard(int size, int currRow, int currCol, string command)
{
    if (command == "up" && currRow == 0 ||
       command == "down" && currRow == size - 1 ||
       command == "left" && currCol == 0 ||
       command == "right" && currCol == size - 1)
    {
        return true;
    }
    return false;
}
