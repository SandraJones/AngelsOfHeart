using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AngelsOfHeart.Models;

namespace AngelsOfHeart.DAL
{
    public class AngelContext: ApplicationDbContext
    {
        public virtual DbSet<AngelUser> AngelUsers { get; set; }
        public virtual DbSet<Volunteer> Volunteers { get; set; }
        public virtual DbSet<Donor> Donors { get; set; }
        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<SiteVisitor> SiteVisitors { get; set; }
        public virtual DbSet<BoardMember> BoardMembers { get; set; }
        public virtual DbSet<Donation> Donations { get; set; }
        public virtual DbSet<Associate> Associates { get; set; }
    }
}