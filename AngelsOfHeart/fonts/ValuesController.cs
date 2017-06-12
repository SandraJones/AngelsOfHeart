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
    }
            
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
