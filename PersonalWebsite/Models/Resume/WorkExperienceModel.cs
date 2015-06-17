using PersonalWebsite.Models.Resume;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalWebsite.Models
{
    public class WorkExperienceModel
    {
        public string Employer { get; set; }
        public string Title { get; set; }
        public DateTime? StartDate { get; set; }

        //TODO: This should be a datetime
        public string EndDate { get; set; }

        public IEnumerable<WorkRoleDescriptionModel> RoleDescriptions { get; set; }
    }
}