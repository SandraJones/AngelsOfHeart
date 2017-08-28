using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngelsOfHeart.Models
{
    public class Associate
    {
        public int AssociateId { get; set; }
        public string AName { get; set; }
        public int APhoneNumber { get; set; }
        public string AEmail {get;set;}
        public string AAddress { get; set; }
        public virtual AngelUser AngelUser { get; set; }
    }
}