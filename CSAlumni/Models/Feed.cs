using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAlumni
{
    /// <summary>
    /// This class represents a Feed, such as "twitter".
    /// </summary>
   public class Feed
    {
       //Feed name, typically something like "twitter", "facebook", "email" etc. 
        public string name { get; set; }
        public Feed(string name) {
            this.name = name;
        }

    }
}
