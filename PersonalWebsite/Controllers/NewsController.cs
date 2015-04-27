using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalWebsite.Controllers
{
    public class NewsController : Controller
    {
        [HttpGet]
        public JsonResult getMainNews()
        {
            Models.NewsCollection collection = new Models.NewsCollection();
            collection.Items = (from c in new PersonalWebsite.DB.DatabaseContextDataContext().News
                                orderby c.PostedDate descending
                                select new Models.NewsModel
                                {
                                    PostedDate = c.PostedDate,
                                    Text = c.Text,
                                    Title = c.Title,
                                }).ToList<object>();

            return Json(collection, JsonRequestBehavior.AllowGet);
        }

    }
}
