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
    public class CoursesController : Controller
    {
        

        // GET: api/courses
        [HttpGet]
        public List<Course> Get()
        {
            List<Course> Courses = new List<Course>() {
            new Course {Id = 1, Name = "Course1", content = "this is the first course" },
            new Course {Id = 2, Name = "Course2", content = "this is the second course" },
            new Course {Id = 3, Name = "Course3", content = "this is the third course" },
            new Course {Id = 4, Name = "Course4", content = "this is the fourth course" }
            };

            return Courses;
        }

        // GET api/courses/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/courses
        [HttpPost]
        public void Post([FromBody] Course course)
        {

        }

        // PUT api/courses
        [HttpPut]
        public void Put([FromBody]Course course)
        {

        }

        // PUT api/courses/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Course course)
        {

        }

        // DELETE api/courses/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
           
        }
    }
}
