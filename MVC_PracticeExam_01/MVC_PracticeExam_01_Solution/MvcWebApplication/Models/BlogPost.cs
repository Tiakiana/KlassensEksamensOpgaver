using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcWebApplication.Models
{
    public class BlogPost
    {

        public int ID;
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        public DateTime CreateDate;
        public string Author;

        public BlogPost(int iD, string title, string content, DateTime createDate, string author)
        {
            ID = iD;
            Title = title;
            
            Content = content;
            CreateDate = createDate;
            Author = author;
        }
        public BlogPost() { }

    
      
    }
}