﻿using PersonalWebsite.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalWebsite.Controllers
{
    public class PortfolioController : Controller
    {
        //
        // GET: /Portfolio/

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult Items()
        {
            PersonalWebsite.DB.DatabaseContextDataContext context = new PersonalWebsite.DB.DatabaseContextDataContext(ConfigurationManager.ConnectionStrings["DBConnection"].ToString());

            var result =  (from portfolio in context.Portfolios
                           select new
                           {
                               Title = portfolio.Title,
                               Text = portfolio.Text,
                               Image = portfolio.ImageLink,
                               Links = (from link in context.PortfolioLinks
                                        join logo in context.LinkLogos on link.LinkLogo equals logo.LinkLogoCode
                                        where link.PortfolioItemID == portfolio.Id
                                        orderby link.LinkLogo
                                        select new
                                        {
                                            url = link.LinkURL,
                                            icon = logo.LogoURL,
                                        })
                           });

            return Json(result, JsonRequestBehavior.AllowGet);
        }

    }
}
