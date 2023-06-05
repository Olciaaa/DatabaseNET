using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AleksandraPoskrobekEFProducts
{
    public class CompanyInfo
    {
         public int ID { get; set; }
         public string Type { get; set; }
        public virtual Company Company { get; set; }
    }
}
