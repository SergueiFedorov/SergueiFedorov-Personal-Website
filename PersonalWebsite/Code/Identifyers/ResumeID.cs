using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalWebsite.Code.Identifyers
{
    public struct ResumeID
    {
        int _ID;

        private ResumeID(int ID)
        {
            this._ID = ID;
        }

        public static explicit operator int(ResumeID ID)
        {
            return ID._ID;
        }

        public static implicit operator ResumeID(int ID)
        {
            return new ResumeID(ID);
        }

    }
}