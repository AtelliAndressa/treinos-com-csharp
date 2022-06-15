using BaltaPoo.ContentContext;
using BaltaPoo.SubscriptionContext;
using System;
using System.Collections.Generic;
using System.Linq;

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
            var careerDotNet = new Career("Especialista em .Net", "especialista-dotNet");
            var careerItem1 = new CareerItem(1, "comece aqui", "", courseAspNet);
            var careerItem2 = new CareerItem(1, "csharp", "", courseCsharp);
            var careerItem3 = new CareerItem(1, "poo", "", courseOop);
            careerDotNet.Items.Add(careerItem1);
            careerDotNet.Items.Add(careerItem2);
            careerDotNet.Items.Add(careerItem3);
            careers.Add(careerDotNet);

            foreach (var career in careers){
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course?.Title);
                    Console.WriteLine(item.Course?.Level);

                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }
                 
                var payPalSubscription = new PayPalSubscription();
                var student = new Student();
                student.CreateSubscription(payPalSubscription);

            }


        }
    }
}