using CSAlumni.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAlumni.Models {
    public class Feeds {

        public string Alumni_email { get; set; }
        public int Twitter { get; set; }
        public int Facebook { get; set; }
        public int Rss { get; set; }
        public int Atom { get; set; }
        public int Email { get; set; }
         
        public Feeds(int twitter, int facebook, int rss, int atom, int email, string alumni_email)
        {
            this.Twitter = twitter;
            this.Facebook = facebook;
            this.Rss = rss;
           this.Atom = atom;
            this.Email = email;
            this.Alumni_email = alumni_email;
        }

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
