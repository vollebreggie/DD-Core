using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using DD.Models;
using System.Collections;
using DD.ViewModels;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DD.API_controller
{
    
    [Route("api/[controller]")]
    public class StreamsController : Controller
    {
        

        // GET: api/streams
        [HttpGet]
        public List<ViewStream> Get()
        {
            List<Stream> Streams = new List<Stream>()
            {
                new Stream { stream_id = 1, content = "STREAMPIE", picture = "build/images/profilepicture.jpg", titel = "StreamTitel"},
                new Stream { stream_id = 2, content = "stroom", picture = "build/images/test.png", titel = "tweede stroom"}
            };

            User mike = new User()
            {
                user_id = 1,
                name = "mike",
                picture = "build/images/profilepicture.jpg"
            };

            List<Comment> Comments = new List<Comment>()
            {
                new Comment {comment_id = 1, content = "dit is een reactie", date = DateTime.Now, user = mike }
            };

            List<ViewStream> ViewStreams = new List<ViewStream>() {
                new ViewStream { comments = Comments, streams = Streams, user = mike}
                
            };


            return ViewStreams;
        }

        // GET api/streams/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/streams
        [HttpPost]
        public void Post([FromBody] Stream stream)
        {

        }

        // PUT api/streams
        [HttpPut]
        public void Put([FromBody]Stream stream)
        {

        }

        // PUT api/streams/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Stream stream)
        {

        }

        // DELETE api/streams/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
           
        }
    }
}
