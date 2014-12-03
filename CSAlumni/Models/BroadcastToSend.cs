using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAlumni.Models {
   public class BroadcastToSend {
        public string Content { get; set; }
        public Feeds Feeds { get; set; }
        //public List<Object> Feeds { get; set; }
        public BroadcastToSend(string content, Feeds feed) {
            this.Content = content;
            this.Feeds = feed;
        }

 
    }
}
