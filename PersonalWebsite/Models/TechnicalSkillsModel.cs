using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalWebsite.Models
{
    public class TechnicalSkillsModel
    {
        public string Title { get; set; }
        public IEnumerable<string> Items { get; set; }
    }
}