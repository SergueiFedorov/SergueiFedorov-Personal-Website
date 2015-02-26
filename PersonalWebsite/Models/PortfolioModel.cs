using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalWebsite.Models
{
    public class PortfolioModelCollection : AbstractModelHeader
    {
        public PortfolioModelCollection()
            : base("PORTFOLIO_COLLECTION")
        {

        }
    }

    public class PortfolioModel
    {
        public string Title { get; set; }
        public string Text { get; set; }

        public string Image { get; set; }

        public string GitHub { get; set; }

        public string Facebook { get; set; }

        public string Website { get; set; }

        public IQueryable<DB.PortfolioLink> Links { get; set; }
    }
}