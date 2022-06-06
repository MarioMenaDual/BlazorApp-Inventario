using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
   public class B_Product
    {
        //Metodo View
        public static List<ProductEntity> ProductList()
        {
            using (var db = new InventaryContext())
            {
                return db.Products.ToList();
            }
        }

        public static ProductEntity ProductById(string id)
        {
            using (var db = new InventaryContext())
            {
                return db.Products.ToList().LastOrDefault(p => p.ProductId == id);
            }
        }

        //Metodo Create

        public static void CreateProduct(ProductEntity oProduct)
        {
            using (var db = new InventaryContext())
            {
                db.Products.Add(oProduct);
                db.SaveChanges();
            }
        }

        //Metodo Update
        public static void UpdateProduct(ProductEntity oProduct)
        {
            using (var db = new InventaryContext())
            {
                db.Products.Update(oProduct);
                db.SaveChanges();
            }
        }

    }
}
