using BookstoreService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseAddressBooks = new Uri("http://localhost:8123/");
            var baseAddressCart = new Uri("http://localhost:8124/");
            var selfHostBooks = new ServiceHost(typeof(BooksService), baseAddressBooks);
            var selfHostCart = new ServiceHost(typeof(CartService), baseAddressCart);

            try
            {
                selfHostBooks.AddServiceEndpoint(typeof(IBooksService), new WSHttpBinding(SecurityMode.None), "BooksService");
                selfHostCart.AddServiceEndpoint(typeof(ICartService), new WSHttpBinding(SecurityMode.None), "CartService");

                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfHostBooks.Description.Behaviors.Add(smb);
                ((ServiceDebugBehavior)selfHostBooks.Description.Behaviors[typeof(ServiceDebugBehavior)]).IncludeExceptionDetailInFaults = true;
                selfHostCart.Description.Behaviors.Add(smb);
                ((ServiceDebugBehavior)selfHostCart.Description.Behaviors[typeof(ServiceDebugBehavior)]).IncludeExceptionDetailInFaults = true;

                selfHostBooks.Open();
                selfHostCart.Open();
                Console.WriteLine("The service is ready.");
                Console.ReadLine();

                selfHostBooks.Close();
                selfHostCart.Close();
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("An exception occurred: {0}", ce.Message);
                selfHostBooks.Abort();
                selfHostCart.Abort();
                Console.Read();
            }
        }
    }
}
