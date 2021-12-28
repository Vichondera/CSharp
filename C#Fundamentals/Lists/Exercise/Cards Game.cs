namespace CardsGame
{
     using System;
     using System.Linq;
     using System.Collections.Generic;
     
    class Program
    {
        static void Main(string[] args)
        {
            string firstPlayer = Console.ReadLine();
            string secondPlayer = Console.ReadLine();

            List<int> playerOne = firstPlayer
               .Split(" ")
               .Select(int.Parse)
               .ToList();

            List<int> playerTwo = secondPlayer
                    .Split(" ")
                    .Select(int.Parse)
                    .ToList();

            bool gameOver = false;

            while (!gameOver)
            {
                int cardsP1 = playerOne.Count;
                int cardsP2 = playerTwo.Count;
                if (cardsP1 <= 0 || cardsP2 <= 0)
                {
                    gameOver = true;
                    break;
                }
                
                int first = playerOne[0];
                int second = playerTwo[0];
                if (first > second)
                {
                    playerTwo.RemoveAt(0);
                    playerOne.RemoveAt(0);
                    playerOne.Add(first);
                    playerOne.Add(second);
                }
                if (first < second)
                {
                    playerOne.RemoveAt(0);
                    playerTwo.RemoveAt(0);
                    playerTwo.Add(second);
                    playerTwo.Add(first);
                }
                
                if(first == second)
                {
                    if (playerOne.Count >= 1 && playerTwo.Count >= 1)
                    {
                        playerOne.RemoveAt(0);
                        playerTwo.RemoveAt(0);
                    }
                    else
                    {
                        gameOver = true;
                        break;
                    }
                }
            }

            int total = 0;
            if (gameOver == true)
            {
                if (playerTwo.Count <= 0)
                {
                    total = playerOne.Sum(x => Convert.ToInt32(x));
                    Console.WriteLine($"First player wins! Sum: {total}");
                }
                else if(playerOne.Count <= 0)
                {
                    total = playerTwo.Sum(x => Convert.ToInt32(x));
                    Console.WriteLine($"Second player wins! Sum: {total}");

                }
            }
            
        }
    }
}
