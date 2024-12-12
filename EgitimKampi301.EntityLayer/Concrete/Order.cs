using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimKampi301.EntityLayer.Concrete
{
    public class Order
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public  virtual Product Product { get; set; } // code first yaklaşımında bire-çok ilişiye göre bir order da bir çok ürün olabilir.
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public int CustomerId { get; set; } // bire-çok ilişkide bir sipariş de bir çok müşteri olabilir.
        public virtual Customer Customer{ get; set; } 
    }
}
