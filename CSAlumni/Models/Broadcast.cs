using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using CSAlumni.Models;

namespace CSAlumni
{
   public class Broadcast
    {
        public string content { get; set; }
        public List<Feed> Feeds { get; set; }
        public string created_at { get; set; }
        public int id { get; set; }
        public Broadcast(string content, List<Feed> feeds, int id,string created_at="")
        {
            this.content = content;
            this.Feeds = feeds;
            this.created_at = created_at;
            this.id = id;
        }

    }
}
