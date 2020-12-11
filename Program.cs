using System;
using ECommerce;
using ExLinq;

namespace CSharpExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i].ToUpper());
            }

            // var firstCustomer = new Customer();
            Customer firstCustomer = new Customer("Francesco", "Bacci", "madcatxxx@gmail.com");
            firstCustomer.Login();

            Customer secondCustomer = new Customer("Mario", "Rossi", "m.rossi99@hotmail.com");
            secondCustomer.Login();

            Customer.SaySomething();

            //class Article

            Article article = new Article("Face mask", 12.44);

            article.List();
            article.Retrieve(0);
            article.Destroy(0);

            Console.WriteLine(article.Description); // GET
            article.Description = "Notebook"; // SET

            Console.WriteLine($"{article.Description} price is : {article.Price}");

            // class OrderHeader

            OrderHeader orderHeader = new OrderHeader(20, DateTime.Now);

            orderHeader.List();
            orderHeader.Retrieve(0);
            orderHeader.Destroy(0);
            
            Console.WriteLine($"Date: {orderHeader.Date}, UserID: {orderHeader.UserId}");

            /* Console.WriteLine(args[0]);
            Console.WriteLine(args[1]);
            Console.WriteLine("Enter your name:");
            string tuoNome = Console.ReadLine();
            Console.WriteLine($"Il tuo nome è {tuoNome.ToUpper()}!"); */
        }
    }
}