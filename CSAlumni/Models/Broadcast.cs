using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using CSAlumni.Models;

namespace CSAlumni{
    /// <summary>
    /// Broadcast class, used for general Broadcast handling such as receiving.
    /// </summary>
   public class Broadcast
    {
       //Broadcast content
        public string Content { get; set; }
       //List of Broadcast Feed object.
        public List<Feed> Feeds { get; set; }
       //Date when the Broadcast was created.
        public string Created_at { get; set; }
       //Broadcast id
        public int id { get; set; }
        public Broadcast(string content, List<Feed> feeds, int id,string created_at="")
        {
            this.Content = content;
            this.Feeds = feeds;
            this.Created_at = created_at;
            this.id = id;
        }

    }
}
