using System;
namespace EComerce {
    class Costumer {
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
        public Costumer(string firstName, string lastName, string email)
        {
            // Called on instantiation
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
        }

        // Methods
        // visibilit� - valore di ritorno - NomeMetodo()
        public void Login()
        {
            Console.WriteLine("You are logged in ...");
            Console.WriteLine($"Hi {this.FirstName} {this.LastName}, you are logged in.");
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
        // Constructor
        public override string ToString()
        {
            return base.ToString();
        }
    }
    class Article
    {
        // Fields or Attributes
        int Id;
        string Description;
        int Price;
        int Stock;
        int TaxRate;

                // Constructor
        public Article(int id, string description, int price, int stock, int taxRate)
        {
            // Called on instantiation
            this.Id = id;
            this.Description = description;
            this.Price = price;
            this.Stock = stock;
            this.TaxRate = taxRate;
        }
             // Methods
        // Visibility� - valore di ritorno - NomeMetodo()
        public void Create()
        {
            Console.WriteLine("Your article");
        }
        public void Read()
        {
            Console.WriteLine("Read");
        }
        public void Update()
        {
            Console.WriteLine("Update");
        }
        public void Delete()
        {
            Console.WriteLine("Detele.");
        }
        public void List()
        {
            Console.WriteLine("This is the list of your articles.");
        }
    }
}

