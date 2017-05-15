using System.Collections.Generic;
using BookstoreService.Entities;
using System.ServiceModel;

namespace BookstoreService.Services
{
        [ServiceContract(Namespace = "http://unwe.bg")]
        public interface IBooksService
        {
            [OperationContract]
            IEnumerable<Book> GetAllBooks();
            [OperationContract]
            IEnumerable<Category> GetAllCategories();
            [OperationContract(Name = "GetBooksByCategoryId")]
            IEnumerable<Book> GetBooksByCategory(int categoryId);
            [OperationContract]
            IEnumerable<Book> GetBooksByCategory(Category category);
            [OperationContract]
            Book GetBook(int id);
            [OperationContract]
            Book GetBookByISBN(string isbn);
            [OperationContract]
            IEnumerable<ExternalBook> GetSimilarBooks(int id);

        [OperationContract]
            Book CreateBook(Book book);
            [OperationContract]
            Book UpdateBook(Book book);
            [OperationContract]
            void RemoveBook(int bookId);
    }
    }
