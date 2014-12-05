using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAlumni.Models {
    /// <summary>
    /// BroadcastToSend is used only to be parsed and sent to the server due to a weird 
    /// situation where received JSON format is different than one required for creation of new object.
    /// </summary>
   public class BroadcastToSend {
        //Content of the broadcast
        public string Content { get; set; }
       //Broadcast Feeds
        public Feeds Feeds { get; set; }
        public BroadcastToSend(string content, Feeds feed) {
            this.Content = content;
            this.Feeds = feed;
        }

 
    }
}
