Stack<int> worms = new Stack<int>(Console.ReadLine()
    .Split(" ")
    .Select(int.Parse));

Queue<int> holes = new Queue<int>(Console.ReadLine()
    .Split(" ")
    .Select(int.Parse));

int matches = 0;
int wormsDefaultCount = worms.Count();

while (worms.Any() && holes.Any())
{
    int worm = worms.Peek();
    int hole = holes.Peek();

    if (worm == hole)
    {
        worms.Pop();
        holes.Dequeue();
        matches++;
    }
    else
    {
        holes.Dequeue();
        worm -= 3;

        if (worm <= 0)
        {
            worms.Pop();
        }
        else
        {
            worms.Pop();
            worms.Push(worm);
        }
    }
}

if(matches > 0)
{
    Console.WriteLine($"Matches: {matches}");
}
else
{
    Console.WriteLine("There are no matches.");
}

if(worms.Any() == false)
{
    if(matches == wormsDefaultCount)
    {
        Console.WriteLine("Every worm found a suitable hole!");
    }
    else
    {
        Console.WriteLine("Worms left: none");
    }
}
else
{
    Console.WriteLine($"Worms left: {string.Join(", ",worms)}");
}

if(holes.Any() == false)
{
    Console.WriteLine("Holes left: none");
}
else
{
    Console.WriteLine($"Holes left: {string.Join(", ", holes)}");
}
