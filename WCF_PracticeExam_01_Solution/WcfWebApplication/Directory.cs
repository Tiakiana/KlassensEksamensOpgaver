using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfWebApplication
{
    public class Directory
    {
        //Hvis ikke man gør listen statisk giver det ikke mening at trådsikre den.
        //Da listen ellers ville oprettes i en ny instans i alle klienter

        public static List<AuktionsVare> Inventory;

        //Sætter en nuværende vare på auktion
      //  public static AuktionsVare CurrentVare;
        public Directory() {
            if (Inventory == null)
            {
                Inventory = new List<AuktionsVare>();
                AuktionsVare a = new AuktionsVare(1, "Himstregims0", 123, 0, "", 0, DateTime.Now);
                AuktionsVare b = new AuktionsVare(2, "Himstregims1", 124, 0, "", 0, DateTime.Now);
                AuktionsVare c = new AuktionsVare(3, "Himstregims2", 125, 0, "", 0, DateTime.Now);
                AuktionsVare d = new AuktionsVare(4, "Himstregims3", 126, 0, "", 0, DateTime.Now);
                Inventory.Add(a);
                Inventory.Add(b);
                Inventory.Add(c);
                Inventory.Add(d);

            }


        }
    }
}