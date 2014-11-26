using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAlumni
{
    class User
    {
        //{"surname":"Loftus","firstname":"Chris","phone":"01970 622422","grad_year":1985,"jobs":false,"email":"cwl@aber.ac.uk","created_at":"2013-09-04T13:51:00.316Z","updated_at":"2013-09-04T13:51:00.316Z"}

       public string Surname { get; set; }
      public  string Firstname { get; set; }
       public string Phone { get; set; }
       public int Grad_Year { get; set; }
       public Boolean Jobs { get; set; }
       public string Email { get; set; }
       public string Created_At { get; set; }
        public string Updated_At { get; set; }
    }
}
