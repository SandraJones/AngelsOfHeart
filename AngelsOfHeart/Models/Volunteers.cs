using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngelsOfHeart.Models
{
    public class Volunteers
    {
        public int VolId { get; }
        protected string VolLastName { get; set; }
        protected string VolFirstName { get; set; }
        protected string VolTitle { get; set; }
        protected List<Volunteers> VolList { get; set; }
        protected int VolLastActivity { get; set; }
        protected string VolEmail { get; set; }
        protected int VolPhoneNumber { get; set; }
        protected string InterestArea { get; set; }
    }
}