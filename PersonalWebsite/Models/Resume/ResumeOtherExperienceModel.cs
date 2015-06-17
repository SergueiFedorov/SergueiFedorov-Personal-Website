using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalWebsite.Models.Resume
{
    public class ResumeOtherExperienceModel
    {
        public string  Title {get; set; }
        public string Platform { get; set; }
        public string Role { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public IEnumerable<WorkRoleDescriptionModel> RoleDescriptions { get; set; }
    }
}