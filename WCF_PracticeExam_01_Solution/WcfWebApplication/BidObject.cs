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
        //Datamembers er ikke strengt nødvendige når man sender fra klienten til serveren.
        //Det er til gengæld super vigtigt hvis det går fra serveren til klienten.

        [DataMember]
        public int ItemNumber;
        // Men de kan anvendes til at sætte sådan noget som navn og is required osv.

        //Dette tjekkes på clientsiden, inden der sendes videre til selve servicen.
        [DataMember(IsRequired = true)]
        
        public int Price;
        [DataMember]
        public string CustomName;
        [DataMember]
        public int CustomPhone;
    }
}