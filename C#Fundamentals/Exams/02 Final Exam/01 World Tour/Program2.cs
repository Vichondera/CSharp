using System.Text;

var stops = new StringBuilder(Console.ReadLine());

while (true)
{
    string line = Console.ReadLine();
    if (line == "Travel") break;

    var splitted = line.Split(":");

    if (splitted[0] == "Add Stop")
    {
        AddStop(stops, splitted);
        Console.WriteLine(stops.ToString());
    }
    else if (splitted[0] == "Remove Stop")
    {
        RemoveStop(stops, splitted);
        Console.WriteLine(stops.ToString());

    }
    else if (splitted[0] == "Switch")
    {
        SwitchStop(stops, splitted);
        Console.WriteLine(stops.ToString());

    }
}
Console.WriteLine($"Ready for world tour! Planned stops: {stops.ToString()}");

static void AddStop(StringBuilder stops, string[] splitted)
{
    int idx = int.Parse(splitted[1]);
    string str = splitted[2];

    if (idx >= 0 && idx <= stops.Length)
        stops.Insert(idx, str);
}

static void RemoveStop(StringBuilder stops, string[] splitted)
{
    int startIdx = int.Parse(splitted[1]);
    int endIdx = int.Parse(splitted[2]);

    if (startIdx >= 0 && endIdx <= stops.Length)
        stops.Remove(startIdx, (endIdx - startIdx) + 1);
}

static void SwitchStop(StringBuilder stops, string[] splitted)
{
    string oldStr = splitted[1];
    string newStr = splitted[2];
    var temp = stops.ToString();

    if (temp.Contains(oldStr))
        stops.Replace(oldStr, newStr);
}
