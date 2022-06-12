using BaltaPoo.ContentContext;
using System;
using System.Collections.Generic;

namespace BaltaPoo
{
    class Program
    {
        static void Main(string[] args) {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre POO", "Orientacao-objetos"));
            articles.Add(new Article("Artigo sobre C#", "csharp"));
            articles.Add(new Article("Artigo sobre SQL", "banco-dados"));
            articles.Add(new Article("Artigo sobre .net", "dotnet"));

            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }

            var course = new Course("Fundamentos OOP", "fundamentos-oop");
        }
    }
}