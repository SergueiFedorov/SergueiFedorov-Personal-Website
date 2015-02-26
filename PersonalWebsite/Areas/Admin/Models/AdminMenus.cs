using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalWebsite.Areas.Admin.Models
{
    public class AdminMenuItemModel
    {
        public AdminMenuItemModel(string Name, string Image, string Href)
        {
            this.Name = Name;
            this.Image = Image;
            this.Href = Href;
        }

        public string Name { get; set; }
        public string Image { get; set; }
        public string Href { get; set; }
    }

    public class AdminMenusModel
    {
        public IEnumerable<AdminMenuItemModel> menuItems { get; private set; }
        public AdminMenusModel(IEnumerable<AdminMenuItemModel> items)
        {
            this.menuItems = items;
        }
    }
}