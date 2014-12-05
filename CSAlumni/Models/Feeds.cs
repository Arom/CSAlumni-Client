using CSAlumni.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAlumni.Models {
    /// <summary>
    /// This class represents all feeds for BroadcastToSend class.
    /// </summary>
    public class Feeds {

        public string Alumni_email { get; set; }
        public int Twitter { get; set; }
        public int Facebook { get; set; }
        public int Rss { get; set; }
        public int Atom { get; set; }
        public int Email { get; set; }
         /// <summary>
         /// If int = 1, it means that Twitter is to be added, int = 0 means the opposite, of course.
         /// </summary>
        public Feeds(int twitter, int facebook, int rss, int atom, int email, string alumni_email)
        {
            this.Twitter = twitter;
            this.Facebook = facebook;
            this.Rss = rss;
           this.Atom = atom;
            this.Email = email;
            this.Alumni_email = alumni_email;
        }
        // Following 'ShouldSerialize*' methods are used to not add the feeds that are not required.
        // This is done due to the nature in which the server receives Broadcasts, generally it does not like
        // unnecessary stuff attached into the request.
        public bool ShouldSerializeFacebook() {
            return (Facebook != 0);
        }
        public bool ShouldSerializeRss() {
            return (Rss != 0);
        }
        public  bool ShouldSerializeAtom(){
            return(Atom!=0);
        }
        public bool ShouldSerializeTwitter() {
            return (Twitter != 0);
        }
        public bool ShouldSerializeEmail() {
            return (Email != 0);
        }
        
   
        
    }
}
