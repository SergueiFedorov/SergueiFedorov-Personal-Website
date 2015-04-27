using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalWebsite.Controllers
{
    public class IndexController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult Modules()
        {
            List<Models.DisplayItemModel> models = new List<Models.DisplayItemModel>
            {
                new Models.DisplayItemModel() { Width = 600, DataController="news/getMainNews" },
                new Models.DisplayItemModel() { Width = 300, DataController="about/getProfile" },
                new Models.DisplayItemModel() { Width = 300, DataController="SiteInformation/getHowThisSiteWorks" },
            };

            return Json(models, JsonRequestBehavior.AllowGet);
        }
    }
}
