using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalWebsite.Controllers
{
    public class SiteInformationController : Controller
    {
        [HttpGet]
        public JsonResult getHowThisSiteWorks()
        {
            HowThisSiteWorksCollection collection = new HowThisSiteWorksCollection();
            collection.Items = new List<object>()
            {
                new HowThisSiteWorksModel() { Brief = "This website works by utilizing MVC as a web service. To display the data on the web page, the frontend Javascript calls the API to construct the page. The web service data can be utilized using any platform (such as Android) which is capable of createing REST calls to a web service. To see the public API for this website, please consult the API page" },
            };

            return Json(collection, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Index()
        {
            return View();
        }

    }
}
