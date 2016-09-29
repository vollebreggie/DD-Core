
namespace DD.Models
{
    public class Comment
    {
        public int comment_id { get; set; }
        public string content { get; set; }
        public System.DateTime date { get; set; }
        public User user { get; set; }

    }
}
