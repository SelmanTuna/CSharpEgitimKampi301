using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimKampi301.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T: class 
    {
        void Insert(T entity);
        void Update(T entity);
        void Delete (T entity);
        List<T> GetAll();
        T GetById(int id);       

    }
}
