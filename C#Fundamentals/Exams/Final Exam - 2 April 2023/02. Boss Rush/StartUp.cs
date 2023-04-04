using System;
using System.Text;
using System.Text.RegularExpressions;
// Get num of lines
int N = int.Parse(Console.ReadLine());
// Patterns
string bossPattern = @"[|][A-Z]{4,}[|][:][#][A-Za-z]+\s[A-Za-z]+[#]";
// Output
StringBuilder sb = new StringBuilder();

for (int i = 0; i < N; i++)
{
    var line = Console.ReadLine();
    // Validate
    Regex bossRegEx = new Regex(bossPattern);
    bool isValid = bossRegEx.IsMatch(line);

    var boss = string.Empty;
    var title = string.Empty;
    if (isValid)
    {
        var splitted = line.Split(':');
        for (int b = 1; b < splitted[0].Length - 1; b++)
        {
            boss += splitted[0][b];
        }

        for (int t = 1; t < splitted[1].Length - 1; t++)
        {
            title += splitted[1][t];
        }

        Console.WriteLine($"{boss}, The {title}");
        Console.WriteLine($">> Strength: {boss.Length}");
        Console.WriteLine($">> Armor: {title.Length}");
    }
    else
    {
        Console.WriteLine("Access denied!");
    }
}
