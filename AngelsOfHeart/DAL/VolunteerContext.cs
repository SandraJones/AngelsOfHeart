using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AngelsOfHeart.Models;

namespace AngelsOfHeart.DAL
{
    public class VolunteerContext: ApplicationDbContext
    {
        public virtual DbSet<Volunteer> Volunteers { get; set; }
        public virtual DbSet<Donor> Donors { get; set; }
        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<SiteVisitor> SiteVisitors { get; set; }
    }
}