using AssignmentDDT.Data;
using AssignmentDDT.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentDDT.Controllers
{
   
    public class CategoryController : Controller
    {

        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }


   
        public IActionResult Index()
        {
            IEnumerable<Category> objList = _db.Category;
                return View(objList);
        }
       
    }


}
