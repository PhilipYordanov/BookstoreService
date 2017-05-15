using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreService.Entities
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public byte[] Cover { get; set; }
        public string ISBN { get; set; }
        public string Description { get; set; }
        public int CategoryID { get; set; }
        
        public Category Category { get; set; } 
    }
}
