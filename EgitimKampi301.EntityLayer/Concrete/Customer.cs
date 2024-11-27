using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimKampi301.EntityLayer.Concrete
{
    public class Customer
    {
        public int CutomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string  CustomerDistrict { get; set; }
        public string CustomerCity { get; set; }
        public List<Order> Orders { get; set; } 
    }

    /*
     SOLİD
     S==> SİNGLE RESPONSİBİLİTY 
     O==> OPEN CLOSED
     L==> LİSKOV SUBSTİTUTİON
     İ==> INTERFACE SEGREGATİON
     D==> DEPENDENCY INVERSİON 
     */
}
