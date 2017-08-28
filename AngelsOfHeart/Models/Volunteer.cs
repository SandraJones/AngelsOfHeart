using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngelsOfHeart.Models
{
    public class Volunteer
    {
        public int VolId { get; }
        public int AssociateId { get; set; }
        protected string InterestArea { get; set; }
        protected int VolLastActivity { get; set; }
        protected List<Volunteer> VolList { get; set; }
        public virtual AngelUser AngelUser { get; set; }
    }
}