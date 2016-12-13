using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFPrøveeksamenTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lav en servicereference ved at højreklikke på references og vælg service reference. klik Discover og navngiv referencen
             // LAv en instans af auctionhouset.
            AuctionHouse.AuctionHouseServiceClient Auction = new AuctionHouse.AuctionHouseServiceClient();
            AuctionHouse.BidObject bid = new AuctionHouse.BidObject();

            Console.WriteLine("Gi navn mand!");
            bid.CustomName = Console.ReadLine();
            bid.CustomPhone  = 53123432;
            bid.ItemNumber = 1;
            Console.WriteLine("Gi pris mand!");
            bid.Price = int.Parse(Console.ReadLine());

            Console.WriteLine(Auction.GiveBid(bid));
            Console.WriteLine(Auction.GetWare(1).BidCustomName);
            Console.ReadKey();
        }
    }
}
