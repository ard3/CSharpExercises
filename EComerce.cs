namespace EComerce {
    class Costumer {
        protected int id;
        protected string name;
        protected string surname;
        protected string city;
        protected int cap;
        protected string email;
        protected string password;
            public void login()
            {
                Console.WriteLine("You are logged in ..");
            }
            public void acquista()
            {
                Console.WriteLine("Acquista");
            }
            public void iMieiOrdini()
            {
                Console.WriteLine("I miei ordini..");
            }
            public void WishList()
            {
                Console.WriteLine("wishList");
            }
            public void carrello()
            {
                Console.WriteLine("carrello");
            }
            public void registrazione()
            {
                Console.WriteLine("registrazione");
            }
    }

}   
