using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalWebsite.Models
{
    public class NewsCollection : AbstractModelHeader
    {
        public NewsCollection()
            : base("NEWS_COLLECTION")
        {

        }
    }

    public class NewsModel
    {
        public DateTime PostedDate { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
    }
}