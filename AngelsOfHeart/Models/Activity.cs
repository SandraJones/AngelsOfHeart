using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace AngelsOfHeart.Models
{
    public class Activity
    {
        public int ActivityId { get; set; }
        public string NameOfActivity { get; set; }
        public DateTime DateOfActivity { get; set; }
        public string NameOfActivityCoordinator { get; set; }
        public string EmailOfActivityCoordinator { get; set; }
        public int NoOfVolunteersNeeded { get; set; }
        public List<Activity> ActivitiesList { get; set; }

        [JsonIgnoreAttribute]
        public virtual AngelUser AngelUser { get; set; }        
    }

    public class AngelActivityViewModel
    {
        [Required]
        public string ActivityName { get; set; }
        public DateTime Date { get; set; }
        public virtual AngelUser AngelUser { get; set; }
    }
}