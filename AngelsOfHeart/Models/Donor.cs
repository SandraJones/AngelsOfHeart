using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static System.Net.Mime.MediaTypeNames;

namespace AngelsOfHeart.Models
{
    public class Donor
    {
        public int DonorId { get; }
        public int DonationId { get; set; }
        public int AssociateId {get;set;}
        protected int TotalDonationsToDate { get; set; }
        protected int LastDonation { get; set; }
        public virtual AngelUser AngelUser { get; set; }
        protected List<Donor> DonorList { get; set; }
    }
}