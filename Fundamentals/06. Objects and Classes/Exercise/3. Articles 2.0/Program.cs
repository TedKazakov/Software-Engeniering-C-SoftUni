using System;
using System.Collections.Generic;

namespace _3._Articles_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();
            int numOfArticles = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfArticles; i++)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

                Article article = new Article(input[0], input[1], input[2]);

                articles.Add(article);
            }
            //Console.WriteLine($"{article.Title}, {article.Content},{article.Author}");
            foreach (Article article in articles)
            {
                Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");

            }
        }
    }

    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
        //•	Title – a string
        //•	Content – a string
        //•	Author – a string
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public override string ToString() => $"{Title} - {Content}: {Author}";
    }
}
