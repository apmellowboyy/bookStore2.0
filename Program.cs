
namespace bookStore
{
    class book
    {
        private int _Id;
        private string _Title;
        private string _Author;


        public book()
        {
            _Id = 0;
            _Title = "";
            _Author = "";
        }
        public book(int id, string title, string author)
        {
            _Id=id;
            _Title=title;
            _Author=author;
        }
        public int Get_Id()
        {
            return _Id;
        }
        

        public string Get_Title()
        {
            return _Title;
        }
        
        public string Get_Author()
        {
            return _Author;
        }

        internal void Set_Id(int v)
        {
            _Id=v;
        }

        internal void Set_Title(string v)
        {
            _Title=v;
        }

        internal void Set_Author(string v)
        {
            _Author=v;
        }
    }
    class myStore
    {
        static void Main(string[] args)
        {
            book member1 = new book();
            member1.Set_Id(1);
            member1.Set_Title("Holes");
            member1.Set_Author("Louis Sachar");

            book member2 = new book();
            Console.WriteLine("Please enter your library ID");
            member2.Set_Id(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the Book title");
            member2.Set_Title(Console.ReadLine());
            Console.WriteLine("Please enter the Author of book");
            member2.Set_Author(Console.ReadLine());

            book member3 = new book(3, "Captain Underpants and the Invasion of the Incredibly Naughty Cafeteria Ladies from Outer Space (and the Subsequent Assault of the Equally Evil Lunchroom Zombie Nerds)", "Dav Pilkey");


            Console.WriteLine("Please enter Library ID:");
            int tempID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the book title:");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Please enter the Author of book:");
            string tempAuthor = Console.ReadLine();
            book member4 = new book(tempID, tempTitle, tempAuthor);

            displayBooks(member4);
            displayBooks(member3);
            displayBooks(member2);
            displayBooks(member1);
        }

        static void displayBooks(book member4)
        {
            Console.WriteLine("Here's ypur library ID, Book and Author");
            Console.WriteLine($"Library ID: {member4.Get_Id()}");
            Console.WriteLine($"Book:{member4.Get_Title()}");
            Console.WriteLine($"Author:{member4.Get_Author()}");
        }

    }
}
