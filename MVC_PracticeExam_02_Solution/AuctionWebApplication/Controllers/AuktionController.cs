using AuctionWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuctionWebApplication.Controllers
{
    public class AuktionController : Controller
    {
        AuktionServiceReference.AuctionsServiceClient service = new AuktionServiceReference.AuctionsServiceClient();
        // GET: Auktion
        [HttpGet]
        public ActionResult ShowAllAuktions()
        {
            return View(service.GetAllAuctionItems());
        }
        [HttpGet]
        public ActionResult Bid(int id)
        {
            Bid b = new Bid();
            b.Auktion = service.GetAuctionItem(id);
            Session["Id"] = id;
            Session["CurrentBid"] = b.Auktion;
            return View(b);
        }
        [HttpPost]
        public ActionResult Bid(Bid bid)
        {
            if (Session["CurrentBid"] == null)
            {
                return RedirectToAction("ShowAllAuktions");
            }
            bid.Auktion = (AuktionServiceReference.AuctionItem)Session["CurrentBid"];
            bid.Auktion.BidTimestamp = DateTime.Now;
            service.ProvideBid(bid.Auktion.ItemNumber, bid.bidPrice, bid.bidCustomName, bid.bidCustomPhone.ToString());
            int id = int.Parse(Session["Id"].ToString());
            return RedirectToAction("Bid", id);
        }
        [HttpPost]
        public ActionResult SeAlleBud(string username)
        {
            if (username == null)
            {
                return RedirectToAction("ShowAllAuktions");
            }
            List<AuktionServiceReference.AuctionItem> result = new List<AuktionServiceReference.AuctionItem>();
            foreach (var item in service.GetAllAuctionItems())
            {
                if (item.BidCustomName == username)
                {
                    result.Add(item);
                }
            }
            return View(result);
        }

    }
}
