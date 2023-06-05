using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AleksandraPoskrobekEFProducts
{
    public class Company
    {
        public int ID {  get; set; }

        public string CompanyName { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public int ZipCode { get; set; }
    }
}
