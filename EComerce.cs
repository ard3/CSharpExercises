using System;

namespace CSharpExercises
{
    class Customer
    {
        // Fields or Attributes
        protected int Id;
        protected string FirstName;
        protected string LastName;
        protected string Adress;
        protected int PostalCode;
        protected string Email;
        protected string Password;

        // Properties
        // getter - setter

        // Constructor
        public Customer(string firstName, string lastName, string email)
        {
            // Called on instantiation
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        // Methods
        // visibilit� - valore di ritorno - NomeMetodo()
        public void Login()
        {
            Console.WriteLine("You are logged in ...");
            Console.WriteLine($"Hi {FirstName} {LastName}, you are logged in.");
        }
        public void CheckOut()
        {
            Console.WriteLine("Product(s) purchased.");
        }
        public void MyOrders()
        {
            Console.WriteLine("These are your orders.");
        }
        public void WishList()
        {
            Console.WriteLine("This is your wishlist.");
        }
        public void AddToCart()
        {
            Console.WriteLine("Product added to cart!");
        }
        public void Signin()
        {
            Console.WriteLine("You are now signed in.");
        }
        public static void PrintSomething()
        {
            Console.WriteLine("Something");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
    class Article
    {
        private int Id;
        private string Description;
        private double Price;
        private int Stock;
        private int Taxes;

        // Constructor
        public Article(string description, double price)
        {
            Description = description;
            Price = price;
        }

        public void Create()
        {
            Console.WriteLine("Create new article");
        }
        public void List()
        {
            Console.WriteLine("List all articles");
        }
        public void Retrieve()
        {
            Console.WriteLine($"Id: {Id}, description: {Description}, price: {Price}");
        }
        public void Update()
        {
            Console.WriteLine("Update your article.");
        }
        public void Destroy()
        {
            Console.WriteLine("Destroy article.");
        }
    }
}