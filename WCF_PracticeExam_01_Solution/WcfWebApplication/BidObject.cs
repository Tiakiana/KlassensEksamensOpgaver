using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;


namespace WcfWebApplication
{
    [DataContract]
    public class BidObject
    {
        [DataMember]
        public int ItemNumber;
        [DataMember]
        public int Price;
        [DataMember]
        public string CustomName;
        [DataMember]
        public int CustomPhone;
    }
}