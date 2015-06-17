using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonalWebsite.Code;

namespace PersonalWebsite.Controllers
{
    public class NavigationController : Controller
    {
        

        //
        // GET: /Navigation/
        [HttpGet]
        public JsonResult getWebsiteLinks()
        {
            string root = Tools.RootURL;

            LinksModelCollection collection = new LinksModelCollection();
            collection.Items = new List<object>
            {
                new LinksModel() { Link = root + "Index", Text = "Home" },
                new LinksModel() { Link = root + "Portfolio", Text = "Portfolio" },
                new LinksModel() { Link = root + "Resume", Text = "Resume" },
                //new LinksModel() { Link = root + "About", Text = "About Me" },
                //new LinksModel() { Link = root + "API", Text = "API" }
            };

            return Json(collection, JsonRequestBehavior.AllowGet);
        }

    }
}
