using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiWebApplication.Models
{
    
    public class Directory
    {
        
        public static List<Models.AuctionItem> Wares;

        public Directory() {
           
                if (Wares == null)
                {

                    Wares = new List<Models.AuctionItem>();
                    Models.AuctionItem a = new Models.AuctionItem(1, "Hulubuluu1", 1, 2, "", 0, DateTime.Now);
                    Models.AuctionItem b = new Models.AuctionItem(2, "Hulubuluu2", 1, 2, "", 0, DateTime.Now);
                    Models.AuctionItem c = new Models.AuctionItem(3, "Hulubuluu3", 1, 2, "", 0, DateTime.Now);
                    Models.AuctionItem d = new Models.AuctionItem(4, "Hulubuluu4", 1, 2, "", 0, DateTime.Now);

                    Wares.Add(a);
                    Wares.Add(b);
                    Wares.Add(c);
                    Wares.Add(d);
                }
        }
    }
}