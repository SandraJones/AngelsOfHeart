using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngelsOfHeart.Models
{
    public class BoardMember
    {
        public int BoardMemberId { get; }
        public string BdTitle { get; set; }
        public int AssociateId { get; set; }
        public virtual AngelUser AngelUser { get; set; } 
    }
}