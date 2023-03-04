using System;
namespace bookStoreClass
{
    class Program
    {
        public record Bookstore(int ID, string Title, string Author, double Price);

        public static void Main()
        {
            Bookstore bookstore = new(01, "A Million Little Pieces", "James Frey", 14.99);
            Console.WriteLine($"ID = {bookstore.ID}");
            Console.WriteLine($"Title = {bookstore.Title}");
            Console.WriteLine($"Author = {bookstore.Author}");
            Console.WriteLine($"Price = {bookstore.Price}");

            Bookstore bookstore1 = new(02, "Luna", "Julie Anne Peters", 8.99);
            Console.WriteLine($"ID = {bookstore1.ID}");
            Console.WriteLine($"Title = {bookstore1.Title}");
            Console.WriteLine($"Author = {bookstore1.Author}");
            Console.WriteLine($"Price = {bookstore1.Price}");

            Bookstore bookstore2 = new(03, "Flygirl", "Sherri L. Smith", 11.99);
            Console.WriteLine($"ID = {bookstore2.ID}");
            Console.WriteLine($"Title = {bookstore2.Title}");
            Console.WriteLine($"Author = {bookstore2.Author}");
            Console.WriteLine($"Price = {bookstore2.Price}");
        }
    }
}
