using PSD_RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_RAAMEN.Repository
{
    public class RamenRepository
    {
        static DatabaseEntities1 db = new DatabaseEntities1();
        public static void insertRamen(Raman ramen)
        {
            db.Ramen.Add(ramen);
            db.SaveChanges();
        }

        public static void updateRamen(int id, int meat_id, string name, string broth, int price)
        {
            int c = (from x in db.Ramen where x.Ramen_Id.Equals(id) select x.Ramen_Id).ToList().FirstOrDefault();
            Raman ramen = db.Ramen.Find(c);
            ramen.Meat_Id = meat_id;
            ramen.Name = name;
            ramen.Broth = broth;
            ramen.Price = price;
            db.SaveChanges();
        }
    }
}