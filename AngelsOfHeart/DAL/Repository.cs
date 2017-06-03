﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AngelsOfHeart.Models;

namespace AngelsOfHeart.DAL
{
    public class Repository
    {
        public VolunteerContext Context { get; set; }
        public Repository()
        {
            Context = new VolunteerContext();
        }
        public Repository(VolunteerContext _context)
        {
            Context = _context;
        }
        public void AddActivity(Activity _activity)
        {
            Context.Activities.Add(_activity);
            Context.SaveChanges();
        }
        public void AddDonor(Donor _donor)
        {
            Context.Donors.Add(_donor);
            Context.SaveChanges();
        }
        public void AddVolunteer(Volunteer _volunteer)
        {
            Context.Volunteers.Add(_volunteer);
            Context.SaveChanges();
        }
        public void AddSiteVisitor(SiteVisitor _siteVisitor)
        {
            Context.SiteVisitors.Add(_siteVisitor);
            Context.SaveChanges();
        }
        public void RemoveActivity(int _activityId)
        {
            if(_activityId != 0) { 

            var Activity = Context.Activities.Find(_activityId);
            Context.Activities.Remove(Activity);
            Context.SaveChanges();
            }
        }
        public void RemoveDonor(int _donorId)
        {
            if (_donorId != 0)
            {

                var Donor = Context.Donors.Find(_donorId);
                Context.Donors.Remove(Donor);
                Context.SaveChanges();
            }
        }
        public void RemoveVolunteer(int _volunteerId)
        {
            if (_volunteerId != 0)
            {

                var Volunteer = Context.Volunteers.Find(_volunteerId);
                Context.Volunteers.Remove(Volunteer);
                Context.SaveChanges();
            }
        }
        public void RemoveSiteVisitor(int _siteVisitorId)
        {
            if (_siteVisitorId != 0)
            {

                var SiteVisitor = Context.SiteVisitors.Find(_siteVisitorId);
                Context.SiteVisitors.Remove(SiteVisitor);
                Context.SaveChanges();
            }
        }
        public void UpdateActivity(Activity _activity)
        {
            Context.Entry(_activity).State = System.Data.Entity.EntityState.Modified;
            Context.SaveChanges();
        }
        public void UpdateDonor(Donor _donor)
        {
            Context.Entry(_donor).State = System.Data.Entity.EntityState.Modified;
            Context.SaveChanges();
        }
        public void UpdateVolunteer(Volunteer _volunteer)
        {
            Context.Entry(_volunteer).State = System.Data.Entity.EntityState.Modified;
            Context.SaveChanges();
        }
        public void UpdateSiteVisitor(SiteVisitor _siteVisitor)
        {
            Context.Entry(_siteVisitor).State = System.Data.Entity.EntityState.Modified;
            Context.SaveChanges();
        }




    }
}