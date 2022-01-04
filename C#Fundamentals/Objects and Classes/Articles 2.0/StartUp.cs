namespace Articles_2._0
{
    using Articles;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int countArticles = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            string[] input;

            for (int i = 0; i < countArticles; i++)
            {
                input = Console.ReadLine().Split(", ");

                var article = new Article(input[0], input[1], input[2]);

                articles.Add(article);

            }

            string orderByWhat = Console.ReadLine();

            switch (orderByWhat)
            {
                case "title":
                    articles = articles.OrderBy(x => x.Title).ToList();
                    break;

                case "content":
                    articles = articles.OrderBy(x => x.Content).ToList();
                    break;

                case "author":
                    articles = articles.OrderBy(x => x.Author).ToList();
                    break;
            }

            Console.WriteLine(string.Join(Environment.NewLine, articles));
        }
    }
}
