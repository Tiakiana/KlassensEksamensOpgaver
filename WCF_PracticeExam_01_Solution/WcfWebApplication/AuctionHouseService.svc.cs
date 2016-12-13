using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfWebApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AuctionHouseService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AuctionHouseService.svc or AuctionHouseService.svc.cs at the Solution Explorer and start debugging.
    public class AuctionHouseService : IAuctionHouseService
    {
        Directory dir = new Directory();
        public AuktionsVare GetWare(int IDNr)
        {
            lock (Directory.Inventory)
            {
                // Lambda udtryk for at finde et nummer frem
                return Directory.Inventory.Find(x => x.ItemNumber == IDNr);

                // nedenstående er forløkken som gør det samme som ovenstående Lambdaudtryk.
/*
                foreach (AuktionsVare item in Directory.Inventory)
                {
                    if (item.ItemNumber == IDNr)
                    {
                        return item;
                    }
                }
                return null;
                */
                            }
            }

        public List<AuktionsVare> GetWares()
        {
            lock (Directory.Inventory)
            {
                return Directory.Inventory;
            }
        }
        /*
         * 
         * En metode, der kan buges til at afgive bud. Metoden skal have
         *  følgende parametre: et Bid object. Metoden skal finde varen 
         *  og hvis den findes og prisen er større BidPrice skal BidPrice, 
         *  BidCustomName og BidCustomPhone ændres til data svarende til dem
         *   fra bid objektet, BidTimestamp sættes til aktuel tid og der skal 
         *   returneres ”OK”.
         *    Hvis varen ikke findes skal returneres ”Vare findes ikke”. 
         *   Hvis budet er for lavt returneres ”Bud for lavt”.
         * 
         * */


        public string GiveBid(BidObject bid)
        {
            lock (Directory.Inventory)
            {
                AuktionsVare current = GetWare(bid.ItemNumber);

                if (current !=null)
                {
                    if (bid.Price > current.BidPrice)
                    {
                        current.BidPrice = bid.Price;
                        current.BidCustomName = bid.CustomName;
                        current.BidCostumPhone = bid.CustomPhone;
                        current.BidTimeStamp = DateTime.Now;
                        return "OK";

                    }
                    else
                    {
                        return "Budet ist zu lavt";
                    }

                }
                else
                {
                    return "The vare findes not! Hay Otros prejuntas?";
                }


               
            }
        }
    }
}
