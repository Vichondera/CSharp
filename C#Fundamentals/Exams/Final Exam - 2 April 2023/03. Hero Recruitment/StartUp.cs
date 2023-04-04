using System.Text;

string input = Console.ReadLine();

var heroesSpells = new Dictionary<string, List<string>>();

while (true)
{
    if (input == "End") break;

    var splitted = input.Split(" ");
    var cmd = splitted[0];
    var heroName = splitted[1];

    if (cmd == "Enroll")
    {
        if (!heroesSpells.ContainsKey(heroName))
        {
            heroesSpells.Add(heroName, new List<string>());
        }
        else
        {
            Console.WriteLine($"{heroName} is already enrolled.");
        }

    }
    else if (cmd == "Learn")
    {
        if (!heroesSpells.ContainsKey(heroName))
        {
            Console.WriteLine($"{heroName} doesn't exist.");
        }
        else if (heroesSpells[heroName].Contains(splitted[2]))
        {
            Console.WriteLine($"{heroName} has already learnt {splitted[2]}.");
        }
        else
        {
            heroesSpells[heroName].Add(splitted[2]);
        }
    }
    else if (cmd == "Unlearn")
    {
        if (!heroesSpells.ContainsKey(heroName))
        {
            Console.WriteLine($"{heroName} doesn't exist.");
        }
        else if (!heroesSpells[heroName].Contains(splitted[2]))
        {
            Console.WriteLine($"{heroName} doesn't know {splitted[2]}.");
        }
        else
        {
            heroesSpells[heroName].Remove(splitted[2]);
        }
    }
    input = Console.ReadLine();
}
Console.WriteLine("Heroes:");
foreach (var hero in heroesSpells)
{
    Console.WriteLine($"== {hero.Key}: {string.Join(", ",hero.Value)}");
    // == {name1}: {spell1}, {spell2}, {spelln}
}
