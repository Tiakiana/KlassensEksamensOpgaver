using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;


namespace WcfWebApplication
{
    [DataContract]
    public class AuktionsVare
    {
        [DataMember]
        public int ItemNumber;
        [DataMember]
        public string ItemDescription;
        [DataMember]
        public int RatingPrice;
        [DataMember]
        public int BidPrice;
        [DataMember]
        public string BidCustomName;
        [DataMember]
        public int BidCostumPhone;
        [DataMember]
        public DateTime BidTimeStamp;

        public AuktionsVare(int itemNumber, string itemDescription, int ratingPrice, int bidPrice, string bidCustomName, int bidCostumPhone, DateTime bidTimeStamp)
        {
            ItemNumber = itemNumber;
            ItemDescription = itemDescription;
            RatingPrice = ratingPrice;
            BidPrice = bidPrice;
            BidCustomName = bidCustomName;
            BidCostumPhone = bidCostumPhone;
            BidTimeStamp = bidTimeStamp;
        }
    }
}