using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngelsOfHeart.Models
{
    public class BoardMember
    {
        public int BoardMemberId { get; }
        public string BdFirstName { get; set; }
        public string BdLastName { get; set; }
        public string BdTitle { get; set; }
        public int BdLastDonation { get; set; }
        public string BdMemberEmail { get; set; }
        public int BdMemberPhoneNumber { get; set; }
        public virtual AngelUser AngelUser { get; set; } 
    }
}