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
        int user_id { get; set; }

        public Broadcast(string content, int user_id)
        {
            this.content = content;
            this.user_id = user_id;
        }
    }
}
