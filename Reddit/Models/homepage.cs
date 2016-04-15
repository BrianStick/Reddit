using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Reddit.Models
{
    public class post
    {

        public string id { get; set; }
        [Required]
        public string author { get; set; }
        public string title { get; set; }
        public int upvote { get; set; }
        public int downvote { get; set; }
        [Required]
        public string body { get; set; }
        public string link { get; set; }
        public string comment { get; set; }
        public DateTime posted { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }  = new List<Comment>();
    }
};
    