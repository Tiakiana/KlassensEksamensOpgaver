using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWebApplication.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Models.BlogPostRepository Directory = new Models.BlogPostRepository();
        // Vi omdøber actionresult index
        //HttpGet og post er begge tokens, der går at mvc ved hvilke type metoder den skal læse dem som.
        [HttpGet]
        //Actionresult er et altmuligt interface der kan returnere mange forskellige ting. Det er en slags masterclass

        public ActionResult AllPosts()
        {
            
            //Sender blogpost listen, der er statisk til viewet.

            //Der højreklikkes på View her nedenunder og addes view.
            //Viewname skal have samme navn som metoden.
            //Template vælger vi liste, for at autogenerere en liste.
            //Ved models vælger man hvilken type der skal returneres. Som er BlogPost
            return View(Models.BlogPostRepository.GetblogPostList());
        }
        [HttpPost]
        //Bemærk her at den har samme 
        public ActionResult AllPosts(string AuthorName)
        {
            //Tjeck efter om den er tom. Hvis det er gå tilbage til 
            if (AuthorName == "")
            {
                return RedirectToAction("AllPosts");
            }
            else
            {
              List<Models.BlogPost> somelist = Models.BlogPostRepository.GetblogPostList().FindAll(x => x.Author == AuthorName);
                //SMider skidtet i en session som er et keyvaluepair
                Session["AuthorName"] = AuthorName;
                return View(somelist);

            }


           
        }

        [HttpGet]
        public ActionResult NewSite() {

            List<Models.BlogPost> newList = new List<Models.BlogPost>();
            foreach (Models.BlogPost item in Models.BlogPostRepository.GetblogPostList())
            {
                if (Session["AuthorName"]!=null && item.Author == Session["AuthorName"].ToString())
                {
                    newList.Add(item);
                }
            }

      //      List<Models.BlogPost> Specificblogs = Models.BlogPostRepository.blogPostList.FindAll(x => x.Author == Session["AuthorName"].);
            return View(newList);
        }

        [HttpGet]
        public ActionResult WholeNewSite()
        {
            Models.BlogPost B = new Models.BlogPost();
            B.Title = "";
            B.Content = "";
            if (Session["AuthorName"] == null)
            {
                return RedirectToAction("AllPosts");
            }
            return View(B);
        }
        [HttpPost]
        public ActionResult WholeNewSite(Models.BlogPost blogPost)
        {

            if (blogPost.Content != null && blogPost.Title!= null)
            {
                blogPost.CreateDate = DateTime.Now;
                blogPost.ID = Models.BlogPostRepository.GetblogPostList().Count+1;
                blogPost.Author = Session["AuthorName"].ToString();
                Models.BlogPostRepository.AddToList(blogPost);
            }
            if (Session["AuthorName"] == null)
            {
                return RedirectToAction("AllPosts");
            }
            return RedirectToAction("AllPosts");
        }
    }
    }