using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcWebApplication.Models
{
    public class BlogPostRepository
    {
       private static List<BlogPost> blogPostList;
        public static List<BlogPost> GetblogPostList() {

            lock (blogPostList)
            {
                return blogPostList.ToList();

            }
        }

        public static void AddToList(BlogPost b) {
            lock (blogPostList) {
                blogPostList.Add(b);
            }

        }

        public BlogPostRepository()
        {
            lock (blogPostList)
            {

            
            if (blogPostList == null)
            {
                blogPostList = new List<BlogPost>();
               BlogPost a = new BlogPost(1, "Bo på spring1", "Bamse var en alfons1", DateTime.Now, "Jakob");
                BlogPost b = new BlogPost(2, "Bo på spring2", "Bamse var en alfons2", DateTime.Now, "Svend");
                BlogPost c = new BlogPost(3, "Bo på spring3", "Bamse var en alfons3", DateTime.Now, "Hubert");
                blogPostList.Add(a);
                blogPostList.Add(b);
                blogPostList.Add(c);

            }
            }

        }

    }
}