using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace livep.api.Controllers
{
    public class FriendController : ApiController
    {
        // GET api/friend
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/friend/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/friend
        public void Post([FromBody]string value)
        {
        }

        // PUT api/friend/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/friend/5
        public void Delete(int id)
        {
        }
    }
}
