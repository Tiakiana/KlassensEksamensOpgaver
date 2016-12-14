using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiWebApplication.Models
{
    public class AuctionItem
    {
        public int ItemNumber;
        public string ItemDescription;
        public int RatingPrice;
        public int BidPrice;
        public string BidCustomName;
        public int BidCustomPhone;
        public DateTime BidTimestamp;

        public AuctionItem(int itemNumber, string itemDescription, int ratingPrice, int bidPrice, string bidCustomName, int bidCustomPhone, DateTime bidTimestamp)
        {
            ItemNumber = itemNumber;
            ItemDescription = itemDescription;
            RatingPrice = ratingPrice;
            BidPrice = bidPrice;
            BidCustomName = bidCustomName;
            BidCustomPhone = bidCustomPhone;
            BidTimestamp = bidTimestamp;
        }
    }
}