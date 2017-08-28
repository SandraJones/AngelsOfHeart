using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngelsOfHeart.Models
{
    public class Donation
    {
        public int DonationId { get; set; }
        public DateTime DonationDate { get; set; }
        public int DonationAmt { get; set; }
        public virtual AngelUser AngelUser { get; set; }
    }
}