using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
   public class B_Warehouse
    { 
        //Metodo View
        public static List<WarehouseEntity> WarehouseList()
        {
            using (var db = new InventaryContext())
            {
                return db.Warehouses.ToList();
            }
        }

        public static WarehouseEntity WarehouseById(string id)
        {
            using (var db = new InventaryContext())
            {
                return db.Warehouses.ToList().LastOrDefault(p=>p.WarehouseId==id);
            }
        }

        //Metodo Create

        public static void CreateWarehouse(WarehouseEntity oWarehouse)
        {
            using (var db = new InventaryContext())
            {
                db.Warehouses.Add(oWarehouse);
                db.SaveChanges();
            }
        }

        //Metodo Update
        public static void UpdateWarehouse(WarehouseEntity oWarehouse)
        {
            using (var db = new InventaryContext())
            {
                db.Warehouses.Update(oWarehouse);
                db.SaveChanges();
            }
        }
    }
}
