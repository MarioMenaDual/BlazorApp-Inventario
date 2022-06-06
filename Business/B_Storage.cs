using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Storage
    {
        //Metodo View
        public static List<StorageEntity> StorageList()
        {
            using (var db = new InventaryContext())
            {
                return db.Storages.ToList();
            }
        }

        public static StorageEntity StorageById(string id)
        {
            using (var db = new InventaryContext())
            {
                return db.Storages.ToList().LastOrDefault(e => e.StorageId == id);
            }
        }

        //Metodo Create

        public static void CreateStorage(StorageEntity oStorage)
        {
            using (var db = new InventaryContext())
            {
                db.Storages.Add(oStorage);
                db.SaveChanges();
            }
        }

        //Nuevo metodo para validar si existe
        public static bool IsProductInWareHouse(string idStorage)
        {
            using (var db = new InventaryContext())
            {
                var product = db.Storages.ToList().
                    Where(s => s.StorageId == idStorage);

                var x = product.Any();
                return x;
            }
        }


        public static List<StorageEntity> StorageProductsByWarehouse(string IdWarehouse)
        {
            using (var db = new InventaryContext())
            {
                return db.Storages
                    .Include(s => s.Product)
                    .Include(s => s.Warehouse)
                    .Where(s => s.WarehouseId == IdWarehouse)
                    .ToList();
            }
        }


        //Metodo Update
        public static void UpdateStorage(StorageEntity oStorage)
        {
            using (var db = new InventaryContext())
            {
                db.Storages.Update(oStorage);
                db.SaveChanges();
            }
        }
    }
}
