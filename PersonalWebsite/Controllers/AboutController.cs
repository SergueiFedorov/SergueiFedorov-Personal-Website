using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalWebsite.Controllers
{
    public class AboutController : Controller
    {
        public ActionResult Index()
        {


            return View();
        }

        [HttpGet]
        public JsonResult getProfileImage()
        {
            return Json(null);
        }

        [HttpGet]
        public JsonResult getProfile()
        {
            ProfileCollection collection = new ProfileCollection();
            collection.Items = new List<object>
            {
                new ProfileModel()
                {
                    Name = "Serguei Fedorov",
                    AboutText = "I will admit, I didn't understand anything in programming when I started. It's certainly been a very long journey with many abitious projects before I actually started to understand what I was doing. The field of software development is so vast and I just wanted to know it all. <br />",
                    ProfilePicture = "Content/SergueiFedorov.png"
                }
            };

            return Json(collection, JsonRequestBehavior.AllowGet);
        }
    }
}
