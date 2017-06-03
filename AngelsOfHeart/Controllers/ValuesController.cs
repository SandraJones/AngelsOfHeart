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
        public IEnumerable<string> Get(int id)
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
       // public string Get(int id)
        //{
        //    return "value";
       // }

        // POST api/values
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
