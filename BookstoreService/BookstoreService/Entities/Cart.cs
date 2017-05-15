using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreService.Entities
{
    public class Cart
    {
        public int CartID { get; set; }
        public string UserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastModification { get; set; }
        public bool IsPaid { get; set; }
        public int? PaymentMethodID { get; set; }
        public int? DeliveryOptionID { get; set; }

        public virtual PaymentMethod PaymentMethod { get; set; }
        public virtual DeliveryOption DeliveryOption { get; set; }
        public virtual ICollection<CartBook> Books { get; set; } = new List<CartBook>();
    }
}
