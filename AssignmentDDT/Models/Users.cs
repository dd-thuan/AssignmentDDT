using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AssignmentDDT.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


namespace AssignmentDDT.Models
{
    public class Users : IdentityUser
    {
   
        public string Name { get; set; }

        public string Course { get; set; }
    }
}
