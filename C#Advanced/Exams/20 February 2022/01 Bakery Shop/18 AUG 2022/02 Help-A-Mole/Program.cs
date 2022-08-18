namespace HelpAMole
{
    using System;
    using System.Collections.Generic;

    class Program
    {
       public const string outOfFieldErrorMsg = "Don't try to escape the playing field!";

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[][] field = new char[n][];
            bool isReachScore = false;

            int moleRow = -1,moleCol = -1;
            int frstSymbolRow = -1, frstSymbolCol = -1;
            int secSymbolRow = -1, secSymbolCol = -1;
            int score = 0;

            for (int row = 0; row < n; row++)
            {
                field[row] = new char[n];
                var colsInput = Console.ReadLine().ToCharArray();

                for (int col = 0; col < n; col++)
                {
                    if(colsInput[col] == 'M')
                    {
                        moleRow = row;
                        moleCol = col;
                    }
                    else if(colsInput[col] == 'S')
                    {
                        if(frstSymbolRow == -1 && frstSymbolCol == -1)
                        {
                            frstSymbolRow = row;
                            frstSymbolCol = col;
                        }
                        else
                        {
                            secSymbolRow = row;
                            secSymbolCol = col;
                        }
                    } // End IF-ELSE
                    field[row][col] = colsInput[col];
                } // end col loop
            } // end row loop

            string line = Console.ReadLine();
            while (true)
            {
                if (line == "End") break;

                if (score >= 25)
                {
                    isReachScore = true;
                    break;
                }

                if (line == "up")
                {
                    var nxtRowIdx = moleRow - 1;
                    if (IndexChecker(field, nxtRowIdx, moleCol))
                    {
                        field[moleRow][moleCol] = '-';
                        field[nxtRowIdx][moleCol] = 'M';
                        moleRow--;
                    }
                    else
                    {
                        Console.WriteLine(outOfFieldErrorMsg);
                    }
                }
                else if (line == "down")
                {
                    var nxtRowIdx = moleRow + 1;
                    if (IndexChecker(field, nxtRowIdx, moleCol))
                    {
                        field[moleRow][moleCol] = '-';
                        field[nxtRowIdx][moleCol] = 'M';
                        moleRow++;
                    }
                    else
                    {
                        Console.WriteLine(outOfFieldErrorMsg);
                    }
                }
                else if (line == "left")
                {
                    var nxtColIdx = moleCol - 1;
                    if (IndexChecker(field, moleRow, nxtColIdx))
                    {
                        field[moleRow][moleCol] = '-';
                        field[moleRow][nxtColIdx] = 'M';
                        moleCol--;
                    }
                    else
                    {
                        Console.WriteLine(outOfFieldErrorMsg);
                    }
                }
                else if (line == "right")
                {
                    var nxtColIdx = moleCol + 1;

                    if (IndexChecker(field, moleRow, nxtColIdx))
                    {
                        field[moleRow][moleCol] = '-';
                        field[moleRow][nxtColIdx] = 'M';
                        moleCol++;
                    }
                    else
                    {
                        Console.WriteLine(outOfFieldErrorMsg);
                    }
                }
                else
                {
                    continue;
                }

                if(char.IsLetter(field[moleRow][moleCol]))
                    {
                    int bar = field[moleRow][moleCol] - '0';
                    score += bar;
                    field[moleRow][moleCol] = '-';
                }
                
                if(field[moleRow][moleCol] == 'S')
                {
                    if(frstSymbolRow == moleRow && frstSymbolCol == moleCol)
                    {
                        field[moleRow][moleRow] = '-';
                        field[secSymbolRow][secSymbolCol] = 'M';
                        field[frstSymbolRow][frstSymbolCol] = '-';
                        moleRow = secSymbolRow;
                        moleCol = secSymbolCol;
                    }
                    else
                    {
                        field[moleRow][moleRow] = '-';
                        field[frstSymbolRow][frstSymbolCol] = 'M';
                        field[secSymbolRow][secSymbolCol] = '-';

                        moleRow = frstSymbolRow;
                        moleCol = frstSymbolCol;
                    }
                }
                line = Console.ReadLine();
            }

            if (isReachScore)
            {
                Console.WriteLine("Yay! The Mole survived another game!");
                Console.WriteLine($"The Mole managed to survive with a total of {score} points.");
            }
            else
            {
                Console.WriteLine("Too bad! The Mole lost this battle!");
                Console.WriteLine($"The Mole lost the game with a total of {score} points.");
            }

            PrintField(field);
        }

        private static bool IndexChecker(char[][] field,int moleRow, int moleCol)
        {
            return (moleRow > 0 && moleRow < field[1].Length) && (moleCol > 0
                && moleCol < field[1].Length);
        }

        private static void PrintField(char[][] field)
        {
            for (int r = 0; r < field[0].Length; r++)
            {
                for (int c = 0; c < field[1].Length; c++)
                {
                    Console.Write(field[r][c]);
                }
                Console.WriteLine();
            }
        }

    }
}
