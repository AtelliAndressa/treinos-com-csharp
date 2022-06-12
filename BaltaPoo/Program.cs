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

            var courses = new List<Course>();
            var courseOop = new Course("Fundamentos OOP", "fundamentos-oop");
            var courseCsharp = new Course("Fundamentos csharp", "fundamentos-csharp");
            var courseAspNet = new Course("Fundamentos Asp.net", "fundamentos-asp.net");
            courses.Add(courseOop);
            courses.Add(courseCsharp);
            courses.Add(courseAspNet);
            
            var careers = new List<Career>();
            var career = new Career("Especialista em .Net", "especialista-dotNet");
            var careerItem = new CareerItem(1, "comece agora", "", null);
            career.Items.Add(careerItem);
            careers.Add(career);
        }
    }
}