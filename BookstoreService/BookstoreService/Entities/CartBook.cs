using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreService.Entities
{
    public class CartBook
    {
        public int CartID { get; set; }
        public int BookID { get; set; }
        public int Quantity { get; set; }
        public DateTime AddedOn { get; set; }

        public virtual Book Book { get; set; }
    }
}
