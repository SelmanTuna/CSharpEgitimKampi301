using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        //int x; // field

        //public int y { get; set; }   // property 

        //void test() // variable 
        //{
        //    int z;
        //}        

        public  int CategoryId { get; set; }
        public  string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; } // bire - çok ilişki mantığında ise bir kategoriye ait birden çok ürün olabilir.



    }
}
/* 
Field-Variable-Property
 */


/*
 int x; --> Field

int y; --> property

int z; --> variable 

 */