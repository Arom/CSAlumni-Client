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

       public string surname { get; set; }
      public  string firstname { get; set; }
       public string phone { get; set; }
       public int grad_year { get; set; }
       public Boolean jobs { get; set; }
       public string email { get; set; }
     //  public string Created_At { get; set; }
     //   public string Updated_At { get; set; }

       public User(string firstname, string surname, string phone, int grad_year, Boolean jobs, string email)
       {
           this.firstname = firstname;
           this.surname = surname;
           this.phone = phone;
           this.grad_year = grad_year;
           this.jobs = jobs;
           this.email = email;
               
       }
    }
}
