using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urun_Otomasyonu.Entities
{
    //databasede supplier tablosundaki değerleri ekliyorum.
   public class Supplier
    {
        public int SupplierID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
    }
}
