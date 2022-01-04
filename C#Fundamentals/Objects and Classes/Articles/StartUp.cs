namespace Articles
{
    using System;

    class StartUp
    {
        static void Main(string[] args)
        {
            string[] articleData = Console.ReadLine().Split(", ");

            Article article = new Article
            {
                Title = articleData[0],
                Content = articleData[1],
                Author = articleData[2],
            };

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] cmdParts = Console.ReadLine().Split(": ");

                string cmd = cmdParts[0];
                string arg = cmdParts[1];

                if (cmd == "Edit")
                {
                    article.Edit(arg);
                }
                else if (cmd == "ChangeAuthor")
                {
                    article.ChangeAuthor(arg);
                }
                else
                {
                    article.Rename(arg);
                }
            }

            Console.WriteLine(article);
        }

    }
}
