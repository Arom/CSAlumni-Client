using CSAlumni.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAlumni.Models {
    class Feeds {

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
        public Feeds(string twitter, string facebook, string rss, string atom, string email) {
            if (!StringHelper.isEmpty(twitter)) {
                this.Twitter = 1;
            }
            if (!StringHelper.isEmpty(facebook)) {
                this.Facebook = 1;
            }
            if(!StringHelper.isEmpty(rss)){
                this.Rss =1;
            }
            if(!StringHelper.isEmpty(atom)){
                this.Atom = 1;
            }
            if(!StringHelper.isEmpty(email)){
                this.Email = 1;
            }
           
        }
    }
}
