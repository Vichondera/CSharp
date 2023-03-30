using System.Text.RegularExpressions;
using System.Text;

string inputPlaces = Console.ReadLine();
string pattern = @"(?<location>[=][A-Za-z]{2,}[=]|[\/][A-Za-z]{2,}[\/])";

Regex r = new Regex(pattern);

MatchCollection matches = r.Matches(inputPlaces);
int len = 0;

var m = new List<string>();

for (int i = 0; i < matches.Count; i++)
{
    var sb = new StringBuilder(matches[i].ToString());
    sb.Remove(0, 1);
    sb.Remove(sb.Length - 1, 1);
    if (sb.ToString().Length >= 3)
    {
        len += sb.ToString().Length;
        m.Add(sb.ToString());
    }
}
Console.WriteLine($"Destinations: {string.Join(", ", m)}");
Console.WriteLine($"Travel Points: {len}");
