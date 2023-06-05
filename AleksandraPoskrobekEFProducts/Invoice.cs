using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AleksandraPoskrobekEFProducts
{
    public class Invoice
    {
        public Invoice() { 
            this.SoldProducts = new HashSet<Product>();
        }
        public int InvoiceID { get; set; }
        public int InvoiceNumber { get; set; }
        public int Quantity { get; set; }

        public ICollection<Product> SoldProducts { get; set; }
    }
}
