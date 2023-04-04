using System.Text;

string input = Console.ReadLine();
var sb = new StringBuilder(input);

while (true)
{
    string line = Console.ReadLine();
    if (line == "Done") break;

    var splitted = line.Split(" ");
    if (splitted[0] == "Change")
    {
        sb.Replace(splitted[1], splitted[2]);
        Console.WriteLine(sb.ToString());
    }
    else if (splitted[0] == "Includes")
    {
        if (sb.ToString().Contains(splitted[1]))
            Console.WriteLine("True");
        else 
            Console.WriteLine("False");
    }
    else if (splitted[0] == "End")
    {
        if (sb.ToString().EndsWith(splitted[1]))
            Console.WriteLine("True");
        else
            Console.WriteLine("False");
    }
    else if (splitted[0] == "Uppercase")
    {
        var temp = sb.ToString().ToUpper();
        sb = new StringBuilder(temp);
        Console.WriteLine(sb.ToString());
    }
    else if (splitted[0] == "FindIndex")
    {
        int idx = sb.ToString().IndexOf(splitted[1]);
        Console.WriteLine(idx);
    }
    else if (splitted[0] == "Cut")
    {
        int startIdx = int.Parse(splitted[1]);
        int len = int.Parse(splitted[2]);

        for (int i = startIdx; i < startIdx + len; i++)
        {
            Console.Write(sb[i] + "");
        }
        Console.WriteLine();
        sb.Remove(startIdx, len);
    }
}
