﻿using System;
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

        //ADD ACTIVITY
        public void AddActivity(Activity _activity)
        {
            Context.Activities.Add(_activity);
            Context.SaveChanges();
        }

        //ADD DONOR
        public void AddDonor(Donor _donor)
        {
            Context.Donors.Add(_donor);
            Context.SaveChanges();
        }

        //ADD VOLUNTEER
        public void AddVolunteer(Volunteer _volunteer)
        {
            Context.Volunteers.Add(_volunteer);
            Context.SaveChanges();
        }

        //ADD BOARDMEMBER
        public void AddBoardMember(BoardMember _boardMember)
        {
            Context.BoardMembers.Add(_boardMember);
            Context.SaveChanges();
        }

        //ADD SITEVISITOR
        public void AddSiteVisitor(SiteVisitor _siteVisitor)
        {
            Context.SiteVisitors.Add(_siteVisitor);
            Context.SaveChanges();
        }

        //ADD DONATION
        public void AddDonation (Donation _donation)
        {
            Context.Donations.Add(_donation);
            Context.SaveChanges();
        }

        //ADD ASSOCIATE
        public void AddAssociate(Associate _associate)
        {
            Context.Associates.Add(_associate);
            Context.SaveChanges();
        }

        //REMOVE ACTIVITY
        public void RemoveActivity(int _activityId)
        {
            if(_activityId != 0) { 

            var Activity = Context.Activities.Find(_activityId);
            Context.Activities.Remove(Activity);
            Context.SaveChanges();
            }
        }

        //REMOVE DONOR
        public void RemoveDonor(int _donorId)
        {
            if (_donorId != 0)
            {

                var Donor = Context.Donors.Find(_donorId);
                Context.Donors.Remove(Donor);
                Context.SaveChanges();
            }
        }

        //REMOVE VOLUNTEER
        public void RemoveVolunteer(int _volunteerId)
        {
            if (_volunteerId != 0)
            {

                var Volunteer = Context.Volunteers.Find(_volunteerId);
                Context.Volunteers.Remove(Volunteer);
                Context.SaveChanges();
            }
        }

        //REMOVE BOARDMEMBER
        public void RemoveBoardMember(int _boardMemberId)
        {
            if (_boardMemberId != 0)
            {
                var BoardMember = Context.BoardMembers.Find(_boardMemberId);
                Context.BoardMembers.Remove(BoardMember);
                Context.SaveChanges();
            }
        }

        //REMOVE SITEVISITOR
        public void RemoveSiteVisitor(int _siteVisitorId)
        {
            if (_siteVisitorId != 0)
            {

                var SiteVisitor = Context.SiteVisitors.Find(_siteVisitorId);
                Context.SiteVisitors.Remove(SiteVisitor);
                Context.SaveChanges();
            }
        }
        //REMOVE DONATION
        public void RemoveDonation(int _donationId)
        {
            if (_donationId != 0)
            {

                var Donation = Context.Donations.Find(_donationId);
                Context.Donations.Remove(Donation);
                Context.SaveChanges();
            }
        }
        //REMOVE ASSOCIATE
        public void RemoveAssociate(int _associateId)
        {
            if (_associateId != 0)
            {

                var Associate = Context.Associates.Find(_associateId);
                Context.Associates.Remove(Associate);
                Context.SaveChanges();
            }
        }

        //UPDATE ACTIIVTY
        public void UpdateActivity(Activity _activity)
        {
            Context.Entry(_activity).State = System.Data.Entity.EntityState.Modified;
            Context.SaveChanges();
        }

        //UPDATE DONOR
        public void UpdateDonor(Donor _donor)
        {
            Context.Entry(_donor).State = System.Data.Entity.EntityState.Modified;
            Context.SaveChanges();
        }

        //UPDATE VOLUNTEER
        public void UpdateVolunteer(Volunteer _volunteer)
        {
            Context.Entry(_volunteer).State = System.Data.Entity.EntityState.Modified;
            Context.SaveChanges();
        }

        //UPDATE BOARDMEMBER
        public void UpdateBoardMember(BoardMember _boardMember)
        {
            Context.Entry(_boardMember).State = System.Data.Entity.EntityState.Modified;
        }

        //UPDATE SITEVISITOR
        public void UpdateSiteVisitor(SiteVisitor _siteVisitor)
        {
            Context.Entry(_siteVisitor).State = System.Data.Entity.EntityState.Modified;
            Context.SaveChanges();
        }

        //UPDATE DONATION
        public void UpdateDonation(Donation _donation)
        {
            Context.Entry(_donation).State = System.Data.Entity.EntityState.Modified;
            Context.SaveChanges();
        }

        //UPDATE ASSOCIATE
        public void UpdateAssociate(Associate _associate)
        {
            Context.Entry(_associate).State = System.Data.Entity.EntityState.Modified;
            Context.SaveChanges();
        }

        //GET ACTIVITY BY ID
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

        //GET DONOR BY ID
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

        //GET VOLUNTEER BY ID
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

        //GET BOARDMEMBER BY ID
        public BoardMember GetBoardMemberById(int _boardMemberId)
        {
            BoardMember found_boardMember = Context.BoardMembers.FirstOrDefault(b => b.BoardMemberId == _boardMemberId);
            if (found_boardMember != null)
            {
                return found_boardMember;
            }
            else
            {
                return null;
            }
        }

        //GET SITEVISITOR BY ID
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

        //GET DONATION BY ID
        public Donation GetDonationById(int _donationId)
        {
            Donation found_donationId = Context.Donations.FirstOrDefault(v => v.DonationId == _donationId);
            if (found_donationId != null)
            {
                return found_donationId;
            }
            else
            {
                return null;
            }
        }

        //GET ASSOCIATE BY ID
        public Associate GetAssociateById(int _associateId)
        {
            Associate found_associateId = Context.Associates.FirstOrDefault(v => v.AssociateId == _associateId);
            if (found_associateId != null)
            {
                return found_associateId;
            }
            else
            {
                return null;
            }
        }

        //GET ALL ACTIVITIES FOR ALL USERS
        public List<Activity> GetAllActivitiesForAllUsers()
        {
            return Context.Activities.ToList();
        }

        //GET ALL ACTIVITIES FOR CURRENT USER
        public List<Activity> GetAllActivitiesForCurrentUser(string UserName)
        {
            return Context.Activities.Where(activity => activity.AngelUser.BaseUser.UserName == UserName).ToList();
        }

        //GET USER BY USERNAME
        public AngelUser GetUserByUserName(string UserName)
        {
            return Context.AngelUsers.Where(a => a.BaseUser.UserName == UserName).FirstOrDefault();
        }

        //GET ALL VOLUNTEERS
        public List<Volunteer> GetAllVolunteers()
        {
            return Context.Volunteers.ToList();
        }

        //GET ALL DONORS
        public List<Donor> GetAllDonors()
        {
            return Context.Donors.ToList();
        }

        //GET ALL BOARDMEMBERS
        public List<BoardMember> GetAllBoardMembers()
        {
            return Context.BoardMembers.ToList();
        }

        //GET ALL SITEVISITORS
        public List<SiteVisitor> GetAllSiteVisitors()
        {
            return Context.SiteVisitors.ToList();
        }

        //GET ALL DONATIONS
        public List<Donation> GetAllDonations()
        {
            return Context.Donations.ToList();
        }

        //GET ALL ASSOCIATES
        public List<Associate> GetAllAssociates()
        {
            return Context.Associates.ToList();
        }

        //CREATE ANGELUSER
        public void CreateAngelUser(string UserName)
        {
            var user = GetAppUserByUserName(UserName);
            var AngelUserFirst = new AngelUser();
            AngelUserFirst.BaseUser = user;
            Context.AngelUsers.Add(AngelUserFirst);
            Context.SaveChanges();
        }

        //GET APP USER BY USERNAME
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