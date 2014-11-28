using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAlumni
{
    class Feeds
    {
        public string alumni_email { get; set; }
        public int twitter { get; set; }
        public int facebook { get; set; }
        public int rss { get; set; }
        public int atom { get; set; }
        public int email { get; set; }
        
        public Feeds(int twitter, int facebook, int rss, int atom, int email, string alumni_email)
        {
            this.twitter = twitter;
            this.facebook = facebook;
            this.rss = rss;
            this.atom = atom;
            this.email = email;
            this.alumni_email = alumni_email;
        }
        public Feeds()
        {

        }

    }
}
