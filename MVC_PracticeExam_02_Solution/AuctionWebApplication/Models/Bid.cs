using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuctionWebApplication.Models
{
    public class Bid
    {
        [Required]
        public int itemNumber { get; set; }
        [Required]
        public int bidPrice { get; set; }
        [Required]
        [MinLength(4)]
        public string bidCustomName { get; set; }
        [Required]
        [Range(8,8)]
        public int bidCustomPhone { get; set; }
        public AuktionServiceReference.AuctionItem Auktion { get; set; }
    }
}