using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urun_Otomasyonu.VM
{
    //Vm (Virtual Model) oluşturdum ki ekranda productId yi ve ismini alayım.Yansıması olarak kullanıcam.
    //DataGridView de göstermek istediğim değerleri buraya yazdım.Modelleme yaptım.
    public class VMProduct
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string SupplierName { get; set; }
        public string CategoryName { get; set; }
    }
}
