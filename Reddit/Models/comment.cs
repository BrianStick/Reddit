using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reddit.Models
{
    public class comment
    {
        public virtual post  Parentpost {get;set;}

        public string body { get; set; }
        public string comments { get; set; }
        public DateTime posted { get; set; }

    }
}