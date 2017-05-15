using BookstoreService.Entities;
using System.Data.SqlClient;
using System.Configuration;
using Dapper;
using System;
using System.Linq;
using System.Collections.Generic;

namespace BookstoreService.Services
{
    public class CartService : ICartService
    {
        private readonly SqlConnection db;

        public CartService()
        {
            db = new SqlConnection(ConfigurationManager.ConnectionStrings["bookstore"].ConnectionString);
        }

        public bool AddToCart(int cartId, int bookId)
        {
            int affected = db.Execute("UPDATE CartBooks SET Quantity=Quantity+1 WHERE CartID=@cartid AND BookID=@bookid", new { cartid = cartId, bookid = bookId });
            if (affected == 0)
            {
                return db.Execute("INSERT INTO CartBooks (CartID,BookID,Quantity) VALUES (@cartid,@bookid,@quantity)", new
                {
                    cartid = cartId,
                    bookid = bookId,
                    quantity = 1
                }) > 0;
            }
            else return true;
        }

        public Cart CreateCart(string userId)
        {
            int newCartId = db.ExecuteScalar<int>("INSERT INTO Carts (UserID) VALUES (@userid); SELECT CAST(SCOPE_IDENTITY() as int)", new { userid = userId });
            return GetCart(newCartId);
        }

        public Cart GetCart(int cartId)
        {
            var cart = db.QuerySingle<Cart>("SELECT CartID,UserID,CreatedOn,LastModification,IsPaid,PaymentMethodID,DeliveryOptionID FROM Carts WHERE CartID=@cartid", new { cartid = cartId });
            cart.PaymentMethod = db.QuerySingleOrDefault<PaymentMethod>("SELECT * FROM PaymentMethods WHERE PaymentMethodID=@id", new { id = cart.PaymentMethodID });
            cart.DeliveryOption = db.QuerySingleOrDefault<DeliveryOption>("SELECT * FROM DeliveryOptions WHERE DeliveryOptionID=@id", new { id = cart.DeliveryOptionID });
            cart.Books = db.Query<CartBook, Book, CartBook>("SELECT cb.CartID,cb.AddedOn,cb.Quantity,b.BookID,Title,Year,Price,ISBN,Description,CategoryID FROM CartBooks cb INNER JOIN Books b ON b.BookID=cb.BookID WHERE cb.CartID=@id",
                (cb, b) => { cb.BookID = b.BookID; cb.Book = b; return cb; },
                new { id = cart.CartID },
                splitOn: "BookID")
                .ToList();

            return cart;
        }

        public bool Purchase(int cartId)
        {
            throw new NotImplementedException();
        }

        public bool RemoveFromCart(int cartId, int bookId)
        {
            return db.Execute("DELETE FROM CartBooks WHERE CartID=@cartid AND BookID=@bookid", new
            {
                cartid = cartId,
                bookid = bookId
            }) > 0;
        }

        public bool SetDeliveryOptions(int cartId, DeliveryOption options)
        {
            return db.Execute("UPDATE Carts SET DeliveryOptionID=@doid WHERE CartID=@cartid", new { cartid = cartId, doid = options.DeliveryOptionID }) > 0;
        }

        public bool SetPaymentMethod(int cartId, PaymentMethod method)
        {
            return db.Execute("UPDATE Carts SET PaymentMethodID=@pmid WHERE CartID=@cartid", new { cartid = cartId, pmid = method.PaymentMethodID }) > 0;
        }

        public IEnumerable<DeliveryOption> GetDeliveryOptions()
        {
            return db.Query<DeliveryOption>("SELECT * FROM DeliveryOptions ORDER BY 1");
        }

        public IEnumerable<PaymentMethod> GetPaymentMethods()
        {
            return db.Query<PaymentMethod>("SELECT * FROM PaymentMethods ORDER BY 1");
        }
    }
}
