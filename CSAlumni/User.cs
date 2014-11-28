using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAlumni
{
    class User
    {
       public string surname { get; set; }
      public  string firstname { get; set; }
       public string phone { get; set; }
       public int grad_year { get; set; }
       public Boolean jobs { get; set; }
       public string email { get; set; }
      public string url {  set;  get; }

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
