using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AngelsOfHeart.Models
{
    public class AngelUser
    {
        [Key]
        public int AngelUserId { get; set; }
        public ApplicationUser BaseUser { get; set; }
        public virtual List<Activity> Activities { get; set; }
    }
}