using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreService.Entities
{
    public class ExternalBook
    {
        public string Title { get; set; }
        public string Publisher { get; set; }
        public string Link { get; set; }
        public string ISBN { get; set; }
    }
}
