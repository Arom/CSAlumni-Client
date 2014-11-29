using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAlumni
{
    class User
    {
       public string Surname { get; set; }
      public  string Firstname { get; set; }
       public string Phone { get; set; }
       public int Grad_year { get; set; }
       public Boolean Jobs { get; set; }
       public string Email { get; set; }
      public string Url {  set;  get; }

       public User(string firstname, string surname, string phone, int grad_year, Boolean jobs, string email)
       {
           this.Firstname = firstname;
           this.Surname = surname;
           this.Phone = phone;
           this.Grad_year = grad_year;
           this.Jobs = jobs;
           this.Email = email;
           
       }
    }
}
