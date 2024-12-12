using EgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimKampi301.BusinessLayer.Abstract
{
    public interface IProductService:IGenericService<Product>
    {
        List<Object> TGetProductsWithCategory();
    }
}
