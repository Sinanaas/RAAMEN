using PSD_RAAMEN.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_RAAMEN.Controller
{
    public class RamenController
    {
        public static void insertRamen(int meat_id, string name, string broth, int price)
        {
            RamenHandler.insertRamen(meat_id, name, broth, price);
        }

        public static void updateRamen(int id, int meat_id, string name, string broth, int price)
        {
            RamenHandler.updateUser(id, meat_id, name, broth, price);
        }
    }
}