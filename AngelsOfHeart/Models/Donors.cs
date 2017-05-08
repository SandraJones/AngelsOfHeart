using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static System.Net.Mime.MediaTypeNames;

namespace AngelsOfHeart.Models
{
    public class Donors
    {
        public int DonorId { get; }
        protected string DonorLastName { get; set; }
        protected string FirstName { get; set; }
        protected string DonorTitle { get; set; }
        protected List<Donors> DonorList { get; set; }
        protected int LastDonation { get; set; }
        protected Tuple<T1, T2, T3, T4, T5, T6, T7, Text> DonorHistory { get; set; }
        
        protected string DonorEmail { get; set; }
        protected int DonorPhoneNumber { get; set; }
    }
}