using System;
using System.Collections.Generic;
using System.Linq;

namespace ECommerce
{
    //class customer
    class Customer
    {
        // Fields or Attributes
        // Più privati possibili

        // Properties
        // getter - setter

        // private string _X
        // _X -> Underscore convenzione che indica attributo privato

        protected int Id;
        protected string FirstName;
        protected string LastName;
        protected string Adress;
        protected int PostalCode;
        protected string Email;
        protected string Password;
        public int Age { get; set;}

        // Constructor
        public Customer(string firstName, string lastName, string email)
        {
            // Called on instantiation
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
        }

        // Methods
        // visibility - returned value - MethodName()
        public void Login()
        {
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
                Console.WriteLine("article added to cart!");
        }
        public void Signin()
        {
            Console.WriteLine("You are now signed in.");
        }

        public static void SaySomething()
        {
            Console.WriteLine("Something");
        }
    }  //end class customer

          //class admin
        class Admin {

            //field or atributes
            protected int Id;
        protected string FirstName;
        protected string LastName;
        protected string Adress;
        protected int PostalCode;
        protected string Email;
        protected string Password;
        private int age;

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int value)
        {
            age = value;
        }

        // Constructor
        public Admin(string firstName, string lastName, string email)
        {
            // Called on instantiation
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;    
        }

         public void Login()
        {
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
                Console.WriteLine("article added to cart!");
        }
        public void Signin()
        {
            Console.WriteLine("You are now signed in.");
        }

        public static void SaySomething()
        {
            Console.WriteLine("Something");
        }

        public void ManageOrders()
        {
            Console.WriteLine("Manage orders");
        }
        public void ManageArticles()
        {
            Console.WriteLine("Manage articles");
        }
        public void ManageCustomers()
        {
            Console.WriteLine("Manage customers");
        }
        }


        //class customers
class Customers {

    private List<Customer> _Customerlist;

    public Customers(){
        this._Customerlist = new List<Customer>();
    }

    public void AddCustomer(Customer customer){

        this._Customerlist.Add(customer);
    }

    public void RemoveCustomer(Customer customer){
        this._Customerlist.Remove(customer);
    }
   
}
        //end class customers

    //class article
    class Article
    {
        // private int Id; // Field
        // private int Id { get; set; }; // Property
        public int Id { get; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        private int Taxes;
        
        public Article(string description, double price)
        {
            this.Description = description;
            this.Price = price;
        }

        public void Create()
        {
            Console.WriteLine("Create new article");
        }
        public void List() 
        {
            Console.WriteLine("List all articles");
        }
        public void Retrieve(int id)
        {
            Console.WriteLine($"Id: {this.Id}, description: {this.Description}, price: {this.Price}");
        }
        public void Update()
        {
            Console.WriteLine("Update your article.");
        }
        public void Destroy(int id)
        {
            Console.WriteLine($"You just destroyed item #{id}");
        }
    } //end class article

    //OrderHeader
    class OrderHeader 
    {
        public int Id { get; }
        public string OrderNumber { get; }
        public DateTime Date { get; }
        public int UserId { get; }

        public OrderHeader(int userId, DateTime date)
        {
            //this.UserId or UserId 
            this.UserId = userId;
            this.Date = date;
        }

        public void Create()
        {
            Console.WriteLine("Create new order");
        }
        public void List() 
        {
            Console.WriteLine("List all orders");
        }
        public void Retrieve(int id)
        {
            Console.WriteLine($"Id: {this.Id}, OrderNumber: {this.OrderNumber}, UserId: {this.UserId}, Date: {this.Date}");
        }
        public void Update()
        {
            Console.WriteLine("Update your order");
        }
        public void Destroy(int id)
        {
            Console.WriteLine("You have cancelled this order ");
        }
    }  //end class orderHeader

    //class cart
     class Cart
    {
        // Fields
        private int Id;
        private int Id_article;
        private int UserId;
        private int Qta;
        public static List<Cart> ListCart = new List<Cart>();
        public List<Article> AllItems = new List<Article>();

        //constructor


        public Cart(Article article, Customer users, int qta)
        {

            this.Id_article = Id_article;
            this.UserId = UserId;
            this.Qta = Qta;
        }

        //Methods
        public void Buy()
        {
            Console.WriteLine("You will soon redirected to the payment page");
        }

        public void Empty()
        {
            Console.WriteLine("You removed all articles from cart");
        }

        public void ListOfCart()
        {
            Console.WriteLine("This is the list of your carts");
        }

        public void addMultiplyArticle(Article article)
        {

            AllItems.Add(article);

        }

        public void Total()
        {

            var total = AllItems.Aggregate(0.00, (acc, val) => acc + val.Price);

            Console.WriteLine("Prices {0}", total);

        }

    } //end class cart

    // class Articles

    class Articles
    {
        private int _Id;
        public string _Description;
        public double Price;
        public int _Stock;
        private List<Article> ListOfItems;
        public int Vat;



        public Articles()
        {

            ListOfItems = new List<Article>();
        }
        public void addToListOfArticles(Article article)
        {

            ListOfItems.Add(article);

        }

        public Article search(string description)
        {

            foreach (Article items in ListOfItems)
            {
                if (items.Description == description)
                {
                    return items;
                }

            }
            return null;
        }


        /*
            public List<Article> Search(string description){


            }
        */
        public void CreateArticles()
        {


        }
        public void ReadArticles()
        {

        }
        public void UpdateArticle()
        {

        }

        public void Delete()
        {

        }
        public void List()
        {

            foreach (var items in this.ListOfItems)
            {
                Console.WriteLine("{0}", items.Description);
            }

        }
    }
}