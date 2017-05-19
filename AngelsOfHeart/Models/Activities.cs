using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace AngelsOfHeart.Models
{
    public class Activities
    {
        public int ActivityId { get; set; }
        public string NameOfActivity { get; set; }
        public DateTime DateOfActivity { get; set; }
        public string NameOfActivityCoordinator { get; set; }
        public string EmailOfActivityCoordinator { get; set; }
        public int NoOfVolunteersNeeded { get; set; }
        public List<Activities> ActivitiesList { get;}
        
    }
}