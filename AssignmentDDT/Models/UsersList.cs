using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentDDT.Models
{
    public class UsersList : IdentityUser
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public DateTime BoD { get; set; }

    }
}
