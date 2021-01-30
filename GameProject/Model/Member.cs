using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Model
{
    public class Member
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }
        public int BirthYear { get; set; }
        public string Password { get; set; }
    }
}
