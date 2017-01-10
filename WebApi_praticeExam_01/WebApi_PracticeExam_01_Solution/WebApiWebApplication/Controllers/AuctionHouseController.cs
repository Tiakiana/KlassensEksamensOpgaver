using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiWebApplication.Controllers
{
    public class AuctionHouseController : ApiController
    {

        Models.Directory Dir = new Models.Directory();



        // GET: api/AuctionHouse


        public IEnumerable<Models.AuctionItem> Get()
        {
            lock (Models.Directory.Wares)
            {

                
                return Models.Directory.Wares.ToArray();
            }
        }

        // GET: api/AuctionHouse/5
        public Models.AuctionItem Get(int id)
        {
            lock (Models.Directory.Wares)
            {
                return Models.Directory.Wares.Find(x => x.ItemNumber == id);
            }
        }

        // POST: api/AuctionHouse
        public string Post([FromBody]Models.AuctionBid bid)
        {
            lock (Models.Directory.Wares)
            {
                Models.AuctionItem current = Get(bid.ItemNumber);
                if (current != null)
                {
                    if (bid.Price > current.BidPrice)
                    {
                        current.BidCustomName = bid.CustomName;
                        current.BidCustomPhone = bid.CustomPhone;
                        current.BidPrice = bid.Price;
                        current.BidTimestamp = DateTime.Now;
                        return "Ok";
                    }
                    else
                    {
                        return "budet er for lavt";
                    }
                }
                else
                {
                    return "Varen findes ikke";
                }
            }
        }

        /*
          Ved brug af fiddler:
         

            Sådan sender du et objekt med ind i fiddler.
Header:  
User-Agent: Fiddler
Host: localhost:6771
Content-Length: 70
Content-Type: application/json 
Accept: application/json

Ved Requestbody:
{ItemNumber: 1, Price: 3, CustomName: "Hubert", CustomPhone: 53123432}

            Bare det, at du skriver det ind, med de rigtige formalia gør det, at den sagtens selv kan finde ud af
            at omdanne det til et Bid-Object.
         * 
         * */

        // PUT: api/AuctionHouse/5
        public string Put(Models.AuctionBid bid)
        {
            lock (Models.Directory.Wares)
            {
                Models.AuctionItem current = Get(bid.ItemNumber);
                if (current != null)
                {
                    if (bid.Price > current.BidPrice)
                    {
                        current.BidCustomName = bid.CustomName;
                        current.BidCustomPhone = bid.CustomPhone;
                        current.BidPrice = bid.Price;
                        current.BidTimestamp = DateTime.Now;
                        return "Ok";
                    }
                    else
                    {
                        return "budet er for lavt";
                    }
                }
                else
                {
                    return "Varen findes ikke";
                }
            }
        }

        // DELETE: api/AuctionHouse/5
        public void Delete(int id)
        {
        }
    }
}
