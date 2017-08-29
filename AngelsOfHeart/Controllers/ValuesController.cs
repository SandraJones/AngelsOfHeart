using AngelsOfHeart.DAL;
using AngelsOfHeart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngelsOfHeart.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        Repository repo = new Repository();
        //GET api/<controller>

        //Methods referenced here are located in the Repository.cs file.
        public List<Activity> Get()
        {
            var CurrentUser = User.Identity.Name;
            //use this list of activities of specific users
            var currentUserActivities = repo.GetAllActivitiesForCurrentUser(CurrentUser);
            return currentUserActivities;
        }

        // GET api/values
        //GetActivity
        public Activity Get(int id, [FromBody]Activity value)
        {
            return repo.GetActivityById(id);
        }
        //GetDonor
        protected Donor Get(int id, [FromBody]Donor value)
        {
            return repo.GetDonorById(id);
        }
        //GetVolunteer
        public Volunteer Get(int id, [FromBody]Volunteer value)
        {
            return repo.GetVolunteerById(id);
        }
        //GetBoardMember
        public BoardMember Get(int id, [FromBody]BoardMember value)
        {
            return repo.GetBoardMemberById(id);
        }

        //GetDonation
        public Donation Get(int id, [FromBody]Donation value)
        {
            return repo.GetDonationById(id);
        }

        //GetAssociate
        public Associate Get(int id, [FromBody]Associate value)
        {
            return repo.GetAssociateById(id);
        }

        //POST api/<controller>    
        public void Post(Activity activity)
        {
            var currentUser = repo.GetUserByUserName(User.Identity.Name);
            activity.AngelUser = currentUser;
            repo.AddActivity(activity);
        }
        public void Post(Volunteer volunteer)
        {
            var currentUser = repo.GetUserByUserName(User.Identity.Name);
            volunteer.AngelUser = currentUser;
            repo.AddVolunteer(volunteer);
        }
        protected void Post(Donor donor)
        {
            var currentUser = repo.GetUserByUserName(User.Identity.Name);
            donor.AngelUser = currentUser;
            repo.AddDonor(donor);
        }
        public void Post(BoardMember boardMember)
        {
            var currentUser = repo.GetUserByUserName(User.Identity.Name);
            boardMember.AngelUser = currentUser;
            repo.AddBoardMember(boardMember);
        }

        public void Post(Donation donation)
        {
            var currentUser = repo.GetUserByUserName(User.Identity.Name);
            donation.AngelUser = currentUser;
            repo.AddDonation(donation);
        }

        public void Post(Associate associate)
        {
            var currentUser = repo.GetUserByUserName(User.Identity.Name);
            associate.AngelUser = currentUser;
            repo.AddAssociate(associate);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Activity value)
        {
            var activityToBeUpdated = repo.GetActivityById(id);
            repo.UpdateActivity(value);
        }
        public void Put(int id, [FromBody]BoardMember value)
        {
            var boardMemberToBeUpdated = repo.GetBoardMemberById(id);
            repo.UpdateBoardMember(value);
        }
        protected void Put(int id, [FromBody]Donor value)
        {
            var donorToBeUpdated = repo.GetDonorById(id);
            repo.UpdateDonor(value);
        }
        public void Put(int id, [FromBody]Volunteer value)
        {
            var volunteerToBeUpdated = repo.GetVolunteerById(id);
            repo.UpdateVolunteer(value);
        }

        public void Put(int id, [FromBody]Donation value)
        {
            var donationToBeUpdated = repo.GetDonationById(id);
            repo.UpdateDonation(value);
        }

        public void Put(int id, [FromBody]Associate value)
        {
            var associateToBeUpdated = repo.GetAssociateById(id);
            repo.UpdateAssociate(value);
        }


        // DELETE api/values/5
        [HttpDelete]
        public void Delete(int id, [FromBody]Activity value)
        {
            repo.RemoveActivity(id);
        }

        [HttpDelete]
        public void Delete(int id, [FromBody]BoardMember value)
        {
            repo.RemoveBoardMember(id);
        }

        [HttpDelete]
        protected void Delete(int id, [FromBody]Donor value)
        {
            repo.RemoveDonor(id);
        }

        [HttpDelete]
        public void Delete(int id, [FromBody]Volunteer value)
        {
            repo.RemoveVolunteer(id);
        }
        [HttpDelete]
        public void Delete(int id, [FromBody]Donation value)
        {
            repo.RemoveDonation(id);
        }
        [HttpDelete]
        public void Delete(int id, [FromBody]Associate value)
        {
            repo.RemoveAssociate(id);
        }
    }
}
