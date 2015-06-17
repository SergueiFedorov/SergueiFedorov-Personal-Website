using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalWebsite.Models.Resume
{
    public class WorkRoleDescriptionModel
    {
        public string GeneralDescription { get; set; }
        public IEnumerable<string> Details { get; set; }
    }
}