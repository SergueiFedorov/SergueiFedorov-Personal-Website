using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace PersonalWebsite.Areas.Admin.Controllers
{
    public class IndexController : Controller
    {
        //
        // GET: /Admin/Index/

        public ActionResult Index()
        {
            Models.AdminMenusModel model = new Models.AdminMenusModel(
                new Models.AdminMenuItemModel[]
                {
                    new Models.AdminMenuItemModel("News", Code.Tools.RootURL + "content/news.png", "news"),
                    new Models.AdminMenuItemModel("Blog", Code.Tools.RootURL + "content/blog.png", "blog")
                }
            );

            return View(model);
        }

    }
}
