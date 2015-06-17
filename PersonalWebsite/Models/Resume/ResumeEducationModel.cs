using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalWebsite.Models
{
    public class ResumeEducationModel
    {
        public string Description { get; set; }
        public decimal GPA { get; set; }
        public string DegreeType { get; set; }
        public string University { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

    }
}