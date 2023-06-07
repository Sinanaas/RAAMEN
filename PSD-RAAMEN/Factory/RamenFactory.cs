using PSD_RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_RAAMEN.Factory
{
    public class RamenFactory
    {
        public static Raman createRamen(int meat_id, string name, string broth, int price)
        {
            Raman ramen = new Raman();
            ramen.Meat_Id = meat_id;
            ramen.Name = name;
            ramen.Broth = broth;
            ramen.Price = price;

            return ramen;
        }
    }
}