using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AngelsOfHeart.Models;

namespace AngelsOfHeart.DAL
{
    public class Repository
    {
        public AngelContext Context { get; set; }
        public Repository()
        {
            Context = new AngelContext();
        }
        public Repository(AngelContext _context)
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
        public Activity GetActivityById(int activity_Id)
        {
            Activity found_activity = Context.Activities.FirstOrDefault(i => i.ActivityId == activity_Id);
            if (found_activity != null)
            {
                return found_activity;
            }
            else
            {
                return null;
            }
        }
        public Donor GetDonorById(int donor_Id)
        {
            Donor found_donor = Context.Donors.FirstOrDefault(i => i.DonorId == donor_Id);
            if (found_donor != null)
            {
                return found_donor;
            }
            else
            {
                return null;
            }
        }
        public Volunteer GetVolunteerById(int vol_Id)
        {
            Volunteer found_volunteer = Context.Volunteers.FirstOrDefault(i => i.VolId == vol_Id);
            if (found_volunteer != null)
            {
                return found_volunteer;
            }
            else
            {
                return null;
            }
        }
        public SiteVisitor GetSiteVisitorById(int _siteVisitorId)
        {
            SiteVisitor found_siteVisitor = Context.SiteVisitors.FirstOrDefault(v => v.SiteVisitorId == _siteVisitorId);
            if (found_siteVisitor != null)
            {
                return found_siteVisitor;
            }
            else
            {
                return null;
            }
        }
        public List<Activity> GetAllActivitiesForAllUsers()
        {
            return Context.Activities.ToList();
        }
        public List<Activity> GetAllActivitiesForCurrentUser(string UserName)
        {
            return Context.Activities.Where(activity => activity.AngelUser.BaseUser.UserName == UserName).ToList();
        }
        public AngelUser GetUserByUserName(string UserName)
        {
            return Context.AngelUsers.Where(a => a.BaseUser.UserName == UserName).FirstOrDefault();
        }


        public void CreateAngelUser(string UserName)
        {
            var user = GetAppUserByUserName(UserName);
            var AngelUserFirst = new AngelUser();
            AngelUserFirst.BaseUser = user;
            Context.AngelUsers.Add(AngelUserFirst);
            Context.SaveChanges();
        }

        public ApplicationUser GetAppUserByUserName(string UserName)
        {
            return Context.Users.FirstOrDefault(u => u.UserName == UserName);
        }
        //check to see if UserName exists in DB
        public bool UserNameExists(string e)
        {
            AngelUser found_User = Context.AngelUsers.FirstOrDefault(r => r.BaseUser.UserName.ToLower() == e.ToLower());
            if (found_User != null)
            {
                return true;
            }
            return false;

        }

    }
}