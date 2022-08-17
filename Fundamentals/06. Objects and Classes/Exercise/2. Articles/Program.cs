using System;

namespace _2._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            Article article = new Article(input[0], input[1], input[2]);
            int numOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfCommands; i++)
            {
                string[] commands = Console.ReadLine().Split();
                switch (commands[0])
                {
                    case "Edit:":
                        article.Content = commands[1];
                        for (int r = 2; r < commands.Length; r++)
                        {
                            article.Content += " " + commands[r];

                        }
                        break;
                    case "ChangeAuthor:": article.Author = commands[1];
                        for (int o = 2; o < commands.Length; o++)
                        {
                            article.Author += " " + commands[o];

                        }
                        break;

                    case "Rename:": article.Title = commands[1];
                        for (int p = 2; p < commands.Length; p++)
                        {
                            article.Title += " " + commands[p];

                        }
                        break;
                }
            }
            //Console.WriteLine($"{article.Title}, {article.Content},{article.Author}");
            Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
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

    }
}
