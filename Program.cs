using System;
using ECommerce;
using ExLinq;
using Mountain;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace CSharpExercises
{
    class Program
    {
        static void Main(string[] args)
        {
           /*IEnumerable<string> lines = File.ReadAllLines("order-details.csv");
           var query = 
           from line in lines 
            let row = line.Split(",")
            let fourthColumn = row[3]
            select int.Parse(fourthColumn);
            Console.WriteLine(query.Sum());
            var max = query.Max();
            Console.WriteLine(max);

            //scriviamo in un file
            File.WriteAllText("max.text", max.ToString());*/

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

            //mountain #8

            Peaks.FirstColumn(";","Monte Falco, 1658, Parco Foreste Casentinesi ; Monte Falterona, 1654, Parco Foreste Casentinesi; Monte Fumaiolo, 1407, Appennino Tosco Emiliano");

            /* Console.WriteLine(args[0]);
            Console.WriteLine(args[1]);
            Console.WriteLine("Enter your name:");
            string tuoNome = Console.ReadLine();
            Console.WriteLine($"Il tuo nome è {tuoNome.ToUpper()}!"); */


            /* public static void Main(string[] args){

             var prices = new List<Article>{};

             Article article1 = new Article(45.56, "felpa");
             Article article2 = new Article(52.55, "jeans");

             prices.Add(article1);
             prices.Add(article2);

             Console.WriteLine(prices[1].Description);

             var total = prices.Aggregate(0.00, (acc , val) => acc + val.Price);
             Console.WriteLine(total);
             }

             class Article 
             {
                 public double Price {get;} = 52.12;
                 public string Description = "Description example";

                 public Article(double price, string description)
                 {
                     this.Price = price;
                     this.Description = description;
                 }*/

            // issue 8 millestone 1------------------------------------------------------------------------
            // we can create new customers
            // Create a new users or a list of users.....

            // Create a new users or a list of users.....

            Customer User1 = new Customer("user1", "surname1", "user1surname1@gmail.com"); // Create a new customers;
            Customer User2 = new Customer("user2", "surname2", "user2surname2@yahoo.com");

            Customers insert = new Customers(); // Create a new List of customers

            insert.AddCustomer(User1);
            insert.AddCustomer(User2); //With this method we can add users in a list of users


            //Now we can create a new Article and add to a list of articles

            Article scarpe = new Article("scarpe blu", 55.2); // Article take description, stock and price as arguments
            Article felpa = new Article("felpa bianca", 88.1);
            Article maglia = new Article("maglia nera", 24.9);

            Articles CreateList = new Articles(); //Set an istance to create a list of article

            CreateList.addToListOfArticles(scarpe);
            CreateList.addToListOfArticles(felpa);   //Add article to articles
            CreateList.addToListOfArticles(maglia);

            CreateList.List();  //Add a method to diplay all articles add

            //millestone 2------------------------------

            //we can search for an article by its description, and we can print its price

            //we can add the searched article to the Cart

            Console.WriteLine(CreateList.search("felpa binca").Price);  //search an article and print his price 

            //Add article

            var myarticle = CreateList.search("felpa bianca");
            Cart Cart = new Cart(myarticle, User1, 20);

            // Milestone 3 -----------------------------

            //We can add multiple article to the cart

            Cart newCart1 = new Cart(scarpe, User1, 10);
            Cart newCart2 = new Cart(maglia, User2, 20); //Create a new istance of a cart

            newCart1.addMultiplyArticle(scarpe);  //Add multiply article to cart
            newCart1.addMultiplyArticle(maglia);

            newCart1.Total();  //Calculate the total from the cart1
        }


    }
}