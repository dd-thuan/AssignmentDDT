using AssignmentDDT.Data;
using AssignmentDDT.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

using System;
using System.Threading.Tasks;

using System.Linq;

namespace AssignmentDDT.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _db ;

        public UserController(ApplicationDbContext db)
        {
           _db = db;
        }


        public ActionResult Index()
        {
            IEnumerable<Users> objList = _db.User;
            return View(objList);
        }
    }
}
