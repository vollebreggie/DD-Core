using DD.Models;
using System.Collections.Generic;

namespace DD.ViewModels
{
    public class ViewStream
    {
        public List<Stream> streams { get; set; }
        public User user { get; set; }
        public List<Comment> comments { get; set; }
        public System.DateTime date { get; set; }

    }
}
