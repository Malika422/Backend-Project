using EduHome1.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome1.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class TeacherController : Controller
    {
        private readonly AppDbContext _dbContext;
        public TeacherController (AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IActionResult> Index()
        {
            var teachers = await _dbContext.Teachers.ToListAsync();

            return View (teachers);
        }

        public async Task<IActionResult> Create()
        {
            //var parentTeachers = await _dbContext.Teachers.Where(x => x.IsDeleted == false)
            //    ViewBag.ParentTeachers = parentTeachers;

            return View();
        }
    }
}
