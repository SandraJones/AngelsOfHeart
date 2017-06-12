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
        public List<Activity> Get()
        {
            var CurrentUser = User.Identity.Name;
            //use this list of activities of specific users
            var currentUserActivities = repo.GetAllActivitiesForCurrentUser(CurrentUser);
            return currentUserActivities;
        }

        // GET api/values
        //GetActivity
        public IEnumerable<string> Get(int id)
        {
            return repo.GetActivityById(id);
        }
        //GetDonor
        protected IEnumerable<string> Get(int id)
        {
            return repo.GetDonorById(id);
        }
        //GetVolunteer
        public IEnumerable<string> Get(int id)
        {
            return repo.GetVolunteerById(id);
        }
        //GetBoardMember
        public IEnumerable<string> Get(int id)
        {
            return repo.GetBoardMemberById(id);
        }

        //POST api/<controller>    
        public void Post(Activity activity)
        {
            var currentUser = repo.GetUserByUserName(currentUser.Identity.Name);
            activity.AngelUser = currentUser;
            repo.AddActivity(activity);
        }
        public void Post(Volunteer volunteer)
        {
            var currentUser = repo.GetUserByUserName(currentUser.Identity.Name);
            volunteer.AngelUser = currentUser;
            repo.AddVolunteer(volunteer);
        }
        protected void Post(Donor donor)
        {
            var currentUser = repo.GetUserByUserName(currentUser.Identity.Name);
            donor.AngelUser = currentUser;
            repo.AddDonor(donor);
        }
        public void Post(BoardMember boardMember)
        {
            var currentUser = repo.GetUserByName(currentUser.Identity.Name);
            boardMember.AngelUser = currentUser;
            repo.AddBoardMember(boardMember);
        }  
            
        // PUT api/values/5
        public void Put(int id, [FromBody]Activity value)
        {
            var activityToBeUpdated = repo.GetActivityById(Id);
            repo.UpdateActivity(value);
        }
        public void Put(int id, [FromBody]BoardMember value)
        {
            var boardMemberToBeUpdated = repo.GetBoardMemberById(Id);
            repo.UpdateBoardMember(value);
        }
        protected void Put(int id, [FromBody]Donor value)
        {
            var donorToBeUpdated = repo.GetDonorMemberById(Id);
            repo.UpdateDonor(value);
        }
        public void Put(int id, [FromBody]Volunteer value)
        {
            var volunteerToBeUpdated = repo.GetVolunteerById(Id);
            repo.UpdateVolunteer(value);
        }
                
        // DELETE api/values/5
        [HttpDelete]
        public void Delete(int id, [FromBody]Activity value)
        {
            repo.RemoveActivity(Id);
        }

        [HttpDelete]
        public void Delete(int id, [FromBody]BoardMember value)
        {
            repo.RemoveBoardMember(Id);
        }

        [HttpDelete]
        protected void Delete(int id, [FromBody]Donor value)
        {
            repo.RemoveDonor(Id);
        }

        [HttpDelete]
        public void Delete(int id, [FromBody]Volunteer value)
        {
            repo.RemoveVolunteer(id);
        }
    }
}
