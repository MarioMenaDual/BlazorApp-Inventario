using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_InputOutput
    {
        public static List<InOutEntity> InOutList()

        //Metodo View
        {
            using (var db = new InventaryContext())
            {
                return db.InOuts.ToList();
            }
        }

        //Metodo Create

        public static void CreateInOut(InOutEntity oInOut)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Add(oInOut);
                db.SaveChanges();
            }
        }

        //Metodo Update
        public static void UpdateInOut(InOutEntity oInOut)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Update(oInOut);
                db.SaveChanges();
            }
        }
    }
}
