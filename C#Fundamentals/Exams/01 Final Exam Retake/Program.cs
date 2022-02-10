namespace The_Imitation_Game
{
    using System;
    using System.Text;
    class Program
    {
        static void Main(string[] args)
        {
           var encryptedMessage = new StringBuilder(Console.ReadLine());

           while (true)
           {
               string line = Console.ReadLine();
               if(line == "Decode") break;

               var cmdArgs = line.Split("|");
               string command = cmdArgs[0];

               if(command == "Move")
               {
                   for (int i = 0; i < int.Parse((cmdArgs[1])); i++)
                   {
                   encryptedMessage.Append(encryptedMessage[0]);
                   encryptedMessage.Remove(0,1);
                   }
               }
               else if(command == "Insert")
               {
                   int idx = int.Parse(cmdArgs[1]);
                   var newValue = cmdArgs[2];
                   encryptedMessage.Insert(idx,newValue);
               }
               else if(command == "ChangeAll")
               {
                   var subStr = cmdArgs[1];
                   var replacement = cmdArgs[2];
                  
                       encryptedMessage.Replace(subStr,replacement);
               } 
           }
                Console.WriteLine($"The decrypted message is: {encryptedMessage}");
        }
    }
}
