using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using DD.Models;
using System.Collections;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DD.API_controller
{

    [Route("api/[controller]")]
    public class MembersController : Controller
    {


        // GET: api/members
        [HttpGet]
        public List<Member> Get()
        {
            List<Member> Members = new List<Member>() {
            new Member {user_id = 1, member_type = "Course1", biography = "this is the first course" },
            new Member {user_id = 1, member_type = "Course2", biography = "this is the second course" },
            new Member {user_id = 1, member_type = "Course3", biography = "this is the third course" },
            new Member {user_id = 1, member_type = "Course4", biography = "this is the fourth course" }
            };

            return Members;
        }

        // GET api/members/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/members
        [HttpPost]
        public void Post([FromBody] Member member)
        {

        }

        // PUT api/members
        [HttpPut]
        public void Put([FromBody]Member member)
        {

        }

        // PUT api/members/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Member member)
        {

        }

        // DELETE api/members/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
