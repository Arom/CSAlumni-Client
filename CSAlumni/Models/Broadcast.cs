using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAlumni
{

 
    class Broadcast
    {
        public string content { get; set; }
        public Feeds Feeds { get; set; }
        public Broadcast(string content, Feeds feeds)
        {
            this.content = content;
            this.Feeds = feeds;
        }

    }
}
