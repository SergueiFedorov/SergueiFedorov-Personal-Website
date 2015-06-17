using PersonalWebsite.Code.Bussiness_Logic.DAL;
using PersonalWebsite.Code.Identifyers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;

namespace PersonalWebsite.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ResumeController : Controller
    {
        //
        // GET: /Resume/

        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Bare()
        {
            return PartialView();
        }

        public FileStreamResult PDF()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://html2pdfwebservice.com/api/convert");
            request.Method = "POST";
            request.Accept = "text/json";
            //request.Credentials = new NetworkCredential("Blackraven6@gmail.com", "1AD6A6D0-EE40-11E4-9F60-DFB90A3C2928");
            request.Headers.Add("X-API-Key", "1AD6A6D0-EE40-11E4-9F60-DFB90A3C2928");
            request.Headers.Add("X-API-Username", "Blackraven6@gmail.com");
            //request.ContentType = "application/json; charset=utf-8";
            
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write("{\"url\" : \"http://sergueifedorov.com/Resume/Bare\"}");
            }

            var response = request.GetResponse();

            return new FileStreamResult(response.GetResponseStream(), "application/pdf");
        }

        [HttpGet]
        public JsonResult Data()
        {
            ResumeDAL resumeDAL = new ResumeDAL();

            ResumeID resumeID = 0;

            var resume = resumeDAL.GetResume(resumeID);
            var education = resumeDAL.GetResumeEducation(resumeID);
            var technicalSkills = resumeDAL.GetResumeTechnicalSkills(resumeID);
            var workExperience = resumeDAL.GetWorkExperience(resumeID);
            var otherExperience = resumeDAL.GetOtherExperience(resumeID);

            return Json(new
            {
                Name = resume.Name,
                Phone = resume.Phone,
                Email = resume.Email,
                Address = resume.Address,

                Education = education,
                TechnicalSkills = technicalSkills,
                WorkExperience = workExperience,
                OtherExperience = otherExperience,

            }, JsonRequestBehavior.AllowGet);
        }

    }
}
