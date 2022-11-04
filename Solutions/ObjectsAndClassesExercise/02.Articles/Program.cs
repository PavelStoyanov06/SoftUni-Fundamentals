using System;
using System.IO;
using System.Linq;

namespace _02.Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ").ToArray();

            Article article = new Article(input[0], input[1], input[2]);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(": ");
                string cmd = cmdArgs[0];

                string value = cmdArgs[1];

                if(cmd == "Edit")
                {
                    article.Edit(value);
                }
                else if(cmd == "ChangeAuthor")
                {
                    article.ChangeAuthor(value);
                }
                else if(cmd == "Rename")
                {
                    article.Rename(value);
                }
            }

            article.ToString();
        }
    }

    public class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit (string newContent)
        {
            this.Content = newContent;
        }

        public void ChangeAuthor (string newAuthor)
        {
            this.Author = newAuthor;
        }

        public void Rename (string newName)
        {
            this.Title = newName;
        }

        public void ToString()
        {
            Console.WriteLine($"{this.Title} - {this.Content}: {this.Author}");
        }
    }
}
