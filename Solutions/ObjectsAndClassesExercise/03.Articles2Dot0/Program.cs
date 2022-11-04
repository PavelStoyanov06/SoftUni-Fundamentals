using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Articles2Dot0
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numArticles = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();

            for (int i = 0; i < numArticles; i++)
            {
                string[] input = Console.ReadLine().Split(", ").ToArray();

                articles.Add(new Article(input[0], input[1], input[2]));
            }

            for (int i = 0; i < numArticles; i++)
            {
                articles[i].ToString();
            }
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

        public void ToString()
        {
            Console.WriteLine($"{this.Title} - {this.Content}: {this.Author}");
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
    }
}
