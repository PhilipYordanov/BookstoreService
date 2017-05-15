using BookstoreService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new BooksService();
            var allBooks = service.GetAllBooks();
            foreach (var b in allBooks)
            {
                Console.WriteLine($"Book: {b.Title} - Price: {b.Price} - Category: {b.Category.Name}");
            }

            var fantasyBooks = service.GetBooksByCategory(1);
            Console.WriteLine();
            Console.WriteLine("Fantasy Books: ");
            foreach (var b in fantasyBooks)
            {
                Console.WriteLine($"Book: {b.Title} - Price: {b.Price}");
            }

            Console.Read();
        }
    }
}
