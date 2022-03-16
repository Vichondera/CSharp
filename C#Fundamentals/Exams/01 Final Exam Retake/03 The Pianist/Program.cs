namespace The_Pianist
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            Dictionary<string, string> keys = new Dictionary<string, string>();

            int numOfPieces = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfPieces; i++)
            {
                var piecesThemselves = Console.ReadLine().Split("|").ToArray();
                data.Add(piecesThemselves[0], piecesThemselves[1]);
                keys.Add(piecesThemselves[0], piecesThemselves[2]);
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Stop") break;

                var cmdArgs = input.Split("|");
                if (cmdArgs[0] == "Add")
                {
                    if (!data.ContainsKey(cmdArgs[1]))
                    {
                        data.Add(cmdArgs[1], cmdArgs[2]);
                        keys.Add(cmdArgs[1], cmdArgs[3]);
                        Console.WriteLine($"{cmdArgs[1]} by {cmdArgs[2]} in {cmdArgs[3]} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{cmdArgs[1]} is already in the collection!");
                        continue;
                    }
                }

                if (cmdArgs[0] == "Remove")
                {
                    if (data.ContainsKey(cmdArgs[1]))
                    {
                        data.Remove(cmdArgs[1]);
                        keys.Remove(cmdArgs[1]);
                        Console.WriteLine($"Successfully removed {cmdArgs[1]}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {cmdArgs[1]} does not exist in the collection.");
                        continue;
                    }
                }

                if (cmdArgs[0] == "ChangeKey")
                {
                    if (data.ContainsKey(cmdArgs[1]))
                    {
                        keys[cmdArgs[1]] = cmdArgs[2];
                        Console.WriteLine($"Changed the key of {cmdArgs[1]} to {cmdArgs[2]}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {cmdArgs[1]} does not exist in the collection.");
                        continue;
                    }
                }
            }

            foreach (var piece in data)
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value}, Key: {keys[piece.Key]}");
            }
        }
    }
}
