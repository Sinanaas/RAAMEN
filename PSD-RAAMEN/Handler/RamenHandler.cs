using PSD_RAAMEN.Factory;
using PSD_RAAMEN.Model;
using PSD_RAAMEN.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_RAAMEN.Handler
{
    public class RamenHandler
    {
        public static void insertRamen(int meat_id, string name, string broth, int price)
        {
            Raman ramen = RamenFactory.createRamen(meat_id, name, broth, price);
            RamenRepository.insertRamen(ramen);
        }

        public static void updateUser(int id, int meat_id, string name, string broth, int price)
        {
            RamenRepository.updateRamen(id, meat_id, name, broth, price);
        }
    }
}