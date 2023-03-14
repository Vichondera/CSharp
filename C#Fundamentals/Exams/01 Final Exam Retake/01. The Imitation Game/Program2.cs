using System.Text;

string encryptedMsg = Console.ReadLine();
string line = Console.ReadLine();

var decrypted = new StringBuilder(encryptedMsg);
while (true)
{
    if(line == "Decode")
    {
        break;
    }

    var instruction = line.Split("|");
    if (instruction[0] == "Move")
    {
        int n = int.Parse(instruction[1]);
        MoveCommand(n,decrypted);
    }
    else if (instruction[0] == "Insert")
    {
        int idx = int.Parse(instruction[1]);
        var v = instruction[2];
        InsertCommand(idx,v);
    }
    else if (instruction[0] == "ChangeAll")
    {
        var subStr = instruction[1];
        var newStr = instruction[2];
        ChangeAllCommand(subStr,newStr);
    }

    line= Console.ReadLine();
}

    Console.WriteLine($"The decrypted message is: {decrypted.ToString()}");

void ChangeAllCommand(string subStr,string newStr)
{
    if(encryptedMsg.Contains(subStr))
        {
        decrypted.Replace(subStr, newStr);
        }
}

void InsertCommand(int idx,string v)
{
    decrypted.Insert(idx,v);
}

void MoveCommand(int n,StringBuilder decrypted)
{
    for (int i = 0; i < n; i++)
    {
            decrypted.Append(decrypted[i]);
    }
        decrypted.Remove(0, n);
}
